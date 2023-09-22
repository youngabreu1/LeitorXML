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
        public List<Insertion> Insercoes;
        public ScheduleDay(string path, string inputDate, string inputTime)
        {
            Breaks = new List<Break>();
            DeleteXMLFile(path);
            UnzipFiles(path, inputDate, inputTime);
            DeleteXMLFile(path);
        }

        void UnzipFiles(string path, string inputDate, string inputTime)
        {
            string[] files = Directory.GetFiles(path);
            foreach (string file in files)
            {
                if (inputDate == file)
                {
                    string[] spltedPath = file.Split('\\', '.');
                    string splitedFile = spltedPath[4];
                    ZipFile.ExtractToDirectory(file, path);
                    ReadXML(path + @"\" + splitedFile + ".xml");
                    SearchListElement(Breaks, inputTime);
                    break;
                }
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
                foreach (XmlNode insertionElement in breakElement.ChildNodes)
                {
                    Insertion insertionInstance = new Insertion(insertionElement);
                    Insercoes.Add(insertionInstance);
                    //Console.WriteLine(insertionInstance);
                }
                //breakInstance.PrintBreak(breakInstance);
                //breakInstance.ListInsertions(breakElement);
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


        void SearchListElement(List<Break> breaks, string inputTime)
        {
            int j = 0;
            for (int i = 0; i < breaks.Count; i++)
            {
                var actualBreak = breaks[i];

                if (actualBreak.Orig.Trim() == inputTime)
                {
                    foreach (var item in actualBreak.Insercoes)
                    {
                        Console.WriteLine("teste: " + item.Title);
                    }
                }
            }
        }
    }
}
