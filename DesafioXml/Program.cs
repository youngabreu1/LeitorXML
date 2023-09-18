using DesafioXml.util;
using System;
using System.Linq.Expressions;
using System.Text;

class Program
{
    static void Main(string[] args)
    {

        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        do
        {  
           

                Console.WriteLine("Insira o caminho da pasta pgm do Playlist: \n");
                string path = Console.ReadLine();
                path += @"\Montagem";
            if (!Directory.Exists(path))
            {
                continue;
            }
            ScheduleDay readSchDay = new ScheduleDay(path);
            Console.WriteLine("Escolha a data do montagem que você deseja visualizar:\nExemplo: dd-mm-yyyy ");
            string inputDate = Console.ReadLine();
           
            var t = Console.ReadLine();
            break;
        }
        while (true);
        
        
          
    }
}