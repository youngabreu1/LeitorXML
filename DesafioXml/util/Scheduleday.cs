using System.Xml;
using System.IO.Compression;
using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DesafioXml.util
{

    public class ScheduleDay
    {
        public string Date { get; set; }
        public List<Break> Breaks { get; set; }
        public XmlDocument document;

        public ScheduleDay(string path)
        {
           
            Breaks = new List<Break>();
            DeleteXMLFile(path);
        }

        void GetFiles(string path, string data)
        {
            string[] files = Directory.GetFiles(path);
            path += @"\";
            string directoryToUnzip = path;
            //path += date.ToString("dd-MM-yyyy") + ".zip";

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
        //Validar data
        void InputDate(string data)
        {
            bool condition = false;
            string inputDate = data;
            while (!condition)
            {
                if (!DateTime.TryParseExact(inputDate, "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime date))
                {
                    Console.Clear();
                    Console.WriteLine("Formato de data inválido.");
                    continue;
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
