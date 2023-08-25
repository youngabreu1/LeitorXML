using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;


namespace DesafioXml.util
{

    public class ScheduleDay
    {
        public string Pathfile { get; set; }
        public List<Break> Breaks { get; set; }
        public XmlDocument document;

        public ScheduleDay(string path)
        {
            Breaks = new List<Break>();
            ReadXML(path);

        }

        void ReadXML(string path)
        {
            XmlDocument document = new XmlDocument();
            document.Load(path);
            //XmlNodeList insercaoElements = document.SelectNodes("//*[starts-with(local-name(), 'Ins')]");
            
            XmlNodeList breakElements = document.SelectNodes("//*[starts-with(local-name(), 'Break')]");
            foreach (XmlNode breakElement in breakElements)
            {
                Break breakInstance = new Break(breakElement);
                Breaks.Add(breakInstance);
                Console.WriteLine(breakInstance);
                XmlNode copyBreakElement = breakElement.CloneNode(true); // Cria uma cópia do nó
                breakInstance.ListaInsercao(copyBreakElement);
            }
        }

        //public XmlNodeList printBreak()
        //{

        //    XmlNodeList breakNodes = document.SelectNodes("//*[starts-with(local-name(), 'Break')]");
        //    Console.WriteLine("Break:");

        //    foreach (XmlNode breakNode in breakNodes)
        //    {
        //        //var tt = breakNode.ChildNodes;
        //        Console.WriteLine("\t" + breakNode.OuterXml);

        //    }
        //    return breakNodes;


        //}
        //public void breakTeste()
        //{
        //    Break breaks = new Break(printBreak());
        //}


    }
}
