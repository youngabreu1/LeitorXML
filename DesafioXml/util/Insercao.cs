using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DesafioXml.util
{
    internal class Insercao
    {
       
        public Insercao() {
        }
        public void print_ins()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            XmlDocument document = new XmlDocument();
            document.Load(@"C:\DesafioXml\DesafioXml\xml\26-07-2023.xml");
            XmlNodeList insNodes = document.SelectNodes("//*[starts-with(local-name(), 'Ins')]");

                    foreach (XmlNode insNode in insNodes)
                    {
                        var tt = insNode.ChildNodes;
                       
                        Console.WriteLine("\t" + insNode.OuterXml);
                    } 
        }
    }
}
