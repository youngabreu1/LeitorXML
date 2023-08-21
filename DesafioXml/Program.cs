using DesafioXml.util;
using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Insira o caminho do XML: \n");
        string path = Console.ReadLine();
        bool t = true;
        ScheduleDay readSchDay = new ScheduleDay(path);
        Console.WriteLine(readSchDay.ToString());

        do
        {
            Console.WriteLine("----------------------------------------Escolha uma opcao----------------------------------------");
            Console.WriteLine("\n1- Imprimir Scheduleday\n2- Imprimir Breaks\n3- Imrpimir Insercao\n4- Sair");
            int option;

            try
            {
                option = int.Parse(Console.ReadLine());
                Console.Clear();

            }
            catch (Exception)
            {
                Console.WriteLine("Insira uma opcao valida!");
                continue;

            }
          
       
    

            switch (option)
            {
                case 1:
                    Console.WriteLine("Schedule Day!!!");
                    break;
                case 2:
                    readSchDay.breakTeste();
                    break;
                case 3:
                    Console.WriteLine("Inserções!!!");
                    break;
                case 4:
                    t = false;
                    break;
                default:
                    Console.WriteLine("Insira uma opcao valida!");
                    break;
            }
        } while (t == true);
       
    }
}