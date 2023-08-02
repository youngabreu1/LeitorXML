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
        public string Pathfile { get; set; }
        private XmlDocument document;


        public Insercao(string path)
        {
            document = new XmlDocument();
            Pathfile = path;
        }
        public void print_ins()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            XmlDocument document = new XmlDocument();
            document.Load(Pathfile);
            Console.WriteLine("Inserção");

            XmlNodeList breakNodes = document.SelectNodes("Playlist/Break1100C");

            Console.WriteLine("Break:");


            foreach (XmlNode breakNode in breakNodes)
            {
                //TODO: alterar lógica pra identificar quantos nós de Inserção o Break possui, e percorrer esse número.
                for (int i = 0; i <= 4; i++)
                {
                    string nodeName = "Ins" + i;
                    XmlNodeList insNodes = breakNode.SelectNodes(nodeName);

                    foreach (XmlNode insNode in insNodes)
                    {
                        var tt = insNode.ChildNodes;
                        XmlElement element = (XmlElement)insNode;

                        Console.WriteLine(element);
                        // Acessar a propriedade OuterXml do nó individual
                        Console.WriteLine("\t" + insNode.OuterXml);
                    }

                }
            }
        }
    }
}
