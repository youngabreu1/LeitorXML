using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DesafioXml.util
{
    
    public class ScheduleDay
    {
        public string Pathfile { get; set; }
        private XmlDocument document;
        
        public ScheduleDay(string path)
        {
            
            Pathfile = path;
            readXML();
            
        }
        public void readXML()
        {
            document = new XmlDocument();
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            document.Load(Pathfile);
        }
        public XmlNodeList printBreak()
        {
            
            XmlNodeList breakNodes = document.SelectNodes("//*[starts-with(local-name(), 'Break')]");
            Console.WriteLine("Break:");

            foreach (XmlNode breakNode in breakNodes)
            {
                //var tt = breakNode.ChildNodes;
                Console.WriteLine("\t" + breakNode.OuterXml);

            }
            return breakNodes;
 
            
        }
        public void breakTeste()
        {
            Break breaks = new Break(printBreak());
        }


    }
}

//public override string ToString()
//{
//    return "penis";
//}