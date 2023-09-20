using DesafioXml.util;
using System;
using System.IO;
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

            Console.WriteLine("Escolha a data do montagem que você deseja visualizar:\nExemplo: dd-mm-yyyy ");
            string inputDate = Console.ReadLine() ;
            if (!DateTime.TryParseExact(inputDate, "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime date))
            {
                Console.Clear();
                Console.WriteLine("Formato de data inválido.");
                continue;
            }

            path += inputDate + ".zip";
            ScheduleDay readSchDay = new ScheduleDay(path);
            var t = Console.ReadLine();
            break;
        }
        while (true);



    }
    
}