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
        public static string PathVerification()
        {
            string path;  
            while (true) 
            {
                Console.WriteLine("Insira o caminho da pasta pgm do Playlist: \n");
                path = Console.ReadLine();
                path += @"\Montagem";
                if (!Directory.Exists(path))
                {
                    Console.Clear();
                    Console.WriteLine("Insira um caminho válido!");
                    continue;
                }
                break;                
            }
            return path;
        }
        public static string DataVerification()
        {
            string inputDate;
            while (true)
            {
                Console.WriteLine("Escolha a data do montagem que você deseja visualizar:\nExemplo: dd-mm-yyyy ");
                inputDate = Console.ReadLine();
                if (!DateTime.TryParseExact(inputDate, "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime data))
                {
                    Console.Clear();
                    Console.WriteLine("Formato de data inválido.");
                    continue;
                } 
                break;
            }
            return inputDate;
        }

        public static string TimeVerification()
        {
            string inputTime;
            while (true)
            {
                Console.WriteLine("Escolha a hora e quantos blocos acima você deseja visualizar:\nExemplo: 20:30");
                inputTime = Console.ReadLine();
                if (!DateTime.TryParseExact(inputTime, "HH:mm", null, System.Globalization.DateTimeStyles.None, out DateTime time))
                {
                    Console.Clear();
                    Console.WriteLine("Formato inválido.");
                    continue;
                }
                
                break;
            }
            return inputTime;
        }
    }
}
