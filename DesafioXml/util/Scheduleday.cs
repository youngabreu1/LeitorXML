using System.Xml;
using System.IO.Compression;


namespace DesafioXml.util
{

    public class ScheduleDay
    {
        public string Pathfile { get; set; }
        public string Date { get; set; }
        public List<Break> Breaks { get; set; }
        public XmlDocument document;

        public ScheduleDay(string path)
        {
            Pathfile = path;
            path = path + @"\Montagem";
            Breaks = new List<Break>();
            DeleteXMLFile(path);
            GetFiles(path);
            DeleteXMLFile(path);
        }

        void GetFiles(string path)
        {
            string[] files = Directory.GetFiles(path);
            path += @"\";
            bool condition = false;
            while (!condition)
            {
                Console.WriteLine("Escolha a data do montagem que você deseja visualizar:\nExemplo: dd-mm-yyyy ");
                string inputDate = Console.ReadLine();

                if (!DateTime.TryParseExact(inputDate, "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime date))
                {
                    Console.Clear();
                    Console.WriteLine("Formato de data inválido.");
                    continue;
                }
                string directoryToUnzip = path;
                path += date.ToString("dd-MM-yyyy") + ".zip";
                condition = !condition;

                foreach (string file in files)
                {
                    if (path == file)
                    {
                        ZipFile.ExtractToDirectory(file, directoryToUnzip);
                        files = Directory.GetFiles(directoryToUnzip, "*.xml");
                        ReadXML(files[0]);
                    }
                }
            }

        }
        //Deletar os arquivos XML que foram descompactados durante a execução do programa para não prejudicar execuções futuras.
        void DeleteXMLFile(string path)
        {
            string deleteUnzip = ".xml";
            string[] filesToDelete = Directory.GetFiles(path, $"*{deleteUnzip}");
            foreach (string fileToDelete in filesToDelete)
            {
                File.Delete(fileToDelete);
                Console.WriteLine($"Deleted: {fileToDelete}");
            }
        }

        void ReadXML(string path)
        {
            XmlDocument document = new XmlDocument();
            document.Load(path);

            XmlNodeList breakElements = document.SelectNodes("//*[starts-with(local-name(), 'Break')]");
            foreach (XmlNode breakElement in breakElements)
            {
                Break breakInstance = new Break(breakElement);
                Breaks.Add(breakInstance);
                breakInstance.PrintBreak(breakInstance);
                breakInstance.ListInsertions(breakElement);
            }
        }

    }
}
