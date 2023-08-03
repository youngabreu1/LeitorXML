using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using DesafioXml.util;

namespace DesafioXml.util
{
    internal class Break
    {
       public Break() {
            
        }
        public void print_break()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            XmlDocument document = new XmlDocument();
            document.Load(@"C:\DesafioXml\DesafioXml\xml\26-07-2023.xml");
            XmlNodeList breakNodes = document.SelectNodes("//*[starts-with(local-name(), 'Break')]");


            foreach (XmlNode breakNode in breakNodes)
            {
                var tt = breakNode.ChildNodes;

                
                Console.WriteLine("\t" + breakNode.OuterXml);
            }

        }
    }
}
