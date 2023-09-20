using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioXml.util
{
    class Utils
    {
        public Utils()
        {
        }
        public static string PathVerification(string path)
        {
            path += @"\Montagem";
            while (true)
            {
                if (!Directory.Exists(path))
                {
                    Console.Clear();
                    Console.WriteLine("Insira um caminho válido!");
                    continue;
                }
                break;
            }
        }
    }
}
