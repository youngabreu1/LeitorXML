using DesafioXml.util;
using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {

        Boolean t = true;
        Scheduleday read_schday = new Scheduleday();
        Break read_break = new Break();
        Insercao read_ins = new Insercao();

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
                read_schday.print_schday();
                break;
            case 2:
                read_break.print_break();
                break;
            case 3:
                read_ins.print_ins();
                break;
                case 4:
                    t = false;
                    break;
                default:
                    Console.WriteLine("Insira uma opcao valida!");
                    break;
        }
         } while (t==true);

    }
}