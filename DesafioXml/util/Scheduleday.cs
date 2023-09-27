using System.Xml;
using System.IO.Compression;
using System.Diagnostics;
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Newtonsoft.Json;

namespace DesafioXml.util
{

    public class ScheduleDay
    {
        public string Date { get; set; }
        public List<Break> Breaks { get; set; }
        public XmlDocument document;
        public List<Insertion> Insercoes { get; set; } = new List<Insertion>();

        public ScheduleDay(string path, DateTime inputDate)
        {
            string data = inputDate.ToString("dd-MM-yyyy");
            string montagemFile = path + @"\" + data + ".zip";

            Breaks = new List<Break>();
            DeleteXMLFile(path);
            UnzipFiles(path, montagemFile);

            string json = JsonConvert.SerializeObject(Breaks);
            string jsonPath = path + @"\" + "Jsonfile.json";
            File.WriteAllText(jsonPath, json);

            DeleteXMLFile(path);
        }

        public ScheduleDay(string path, DateTime inputDate, DateTime inputTime)
        {
            string data = inputDate.ToString("dd-MM-yyyy");
            string time = inputTime.ToString("HH:mm");
            string montagemFile = path + @"\" + data + ".zip";

            Breaks = new List<Break>();
            DeleteXMLFile(path);
            UnzipFiles(path, montagemFile, time);

            string json = JsonConvert.SerializeObject(Breaks);
            string jsonPath = path + @"\" + "Jsonfile.json";
            File.WriteAllText(jsonPath, json);

            DeleteXMLFile(path);
        }


        void UnzipFiles(string path, string inputDate, string inputTime)
        {
            bool condition = false;
            string[] files = Directory.GetFiles(path);
            foreach (string file in files)
            {
                if (inputDate == file)
                {
                    string[] spltedPath = file.Split('\\', '.');
                    string splitedFile = spltedPath[4];
                    ZipFile.ExtractToDirectory(file, path);
                    ReadXML(path + @"\" + splitedFile + ".xml", condition);
                    SearchListElement(Breaks, inputTime);
                    break;
                }
            }
        }
        void UnzipFiles(string path, string inputDate)
        {
            bool condition = true;
            string[] files = Directory.GetFiles(path);
            foreach (string file in files)
            {
                if (inputDate == file)
                {
                    string[] spltedPath = file.Split('\\', '.');
                    string splitedFile = spltedPath[4];
                    ZipFile.ExtractToDirectory(file, path);
                    ReadXML(path + @"\" + splitedFile + ".xml", condition);
                    break;
                }
            }
        }


        void ReadXML(string path, bool condition)
        {
            XmlDocument document = new XmlDocument();
            document.Load(path);

            XmlNodeList breakElements = document.SelectNodes("//*[starts-with(local-name(), 'Break')]");
            foreach (XmlNode breakElement in breakElements)
            {
                Break breakInstance = new Break(breakElement);
                Breaks.Add(breakInstance);
                if (condition == true)
                {
                    Console.WriteLine(breakInstance);
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


        void SearchListElement(List<Break> breaks, string inputTime)
        {
            Break _break = breaks.FirstOrDefault(x => x.Hora[0].Contains(inputTime));
            Console.WriteLine(_break);
        }
    }
}
