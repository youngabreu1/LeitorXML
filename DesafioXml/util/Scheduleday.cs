using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Xml;
using System.IO.Compression;



namespace DesafioXml.util
{

    public class ScheduleDay
    {
        public string Pathfile { get; set; }

        public List<Break> Breaks { get; set; }
        public XmlDocument document;

        public ScheduleDay(string path)
        {

            Pathfile = path;
            path = path + @"\Montagem";
            Breaks = new List<Break>();
            GetFiles(path);

        }
        void GetFiles(string path)
        {
            string[] arquivos = Directory.GetFiles(path);
            Console.WriteLine("Arquivos:");
            int i = 0;

            foreach (string arq in arquivos)
            {
                Console.WriteLine($"({i})"+arq);
                i++;

            }

            Console.WriteLine("Escolha o número referente a data do montagem que você deseja visualizar:");
            i = int.Parse(Console.ReadLine());
            ZipFile.ExtractToDirectory(arquivos[i], path);

            arquivos = Directory.GetFiles(path,"*.xml");
            ReadXML(arquivos[0]);

            //Deletar os arquivos XML que foram descompactados durante a execução do programa para não prejudicar execuções futuras.
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
                Console.WriteLine(breakInstance);
                XmlNode copyBreakElement = breakElement.CloneNode(true);
                breakInstance.ListaInsercao(copyBreakElement);
            }
        }

    }
}
