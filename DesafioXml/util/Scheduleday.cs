using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DesafioXml.util
{
    internal class Scheduleday
    {
  
        public Scheduleday()
        {
         
        }
        public void print_schday()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            XmlDocument document = new XmlDocument();
            document.Load(@"C:\DesafioXml\DesafioXml\xml\26-07-2023.xml");
            XmlNodeList scheduleNodes = document.SelectNodes("Playlist");
            Console.WriteLine("Break:");


            foreach (XmlNode scheduleNode in scheduleNodes)
            {
                var tt = scheduleNode.ChildNodes;
                Console.WriteLine("\t" + scheduleNode.OuterXml);

            }
        }
    }
}
