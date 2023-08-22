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
        public XmlDocument document;

        public ScheduleDay(string path)
        {

            Pathfile = path;
            ReadXML();
        }

        public void ReadXML()
        {

            XmlDocument document = new XmlDocument();
            document.Load(Pathfile);

            //void printInsercoes()
            //{

            //    XmlNodeList insercaoElements = document.SelectNodes("//*[starts-with(local-name(), 'Ins')]");
            //    foreach (XmlNode insercaoElement in insercaoElements)
            //    {
            //        Insercao insInstance = new Insercao(insercaoElement);
            //        Console.WriteLine(insInstance);
            //    }

            //}

            XmlNodeList breakElements = document.SelectNodes("//*[starts-with(local-name(), 'Break')]");
            foreach (XmlNode breakElement in breakElements)
            {

                Break breakInstance = new Break(breakElement);
                Console.WriteLine(breakInstance);

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
