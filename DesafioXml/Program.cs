using DesafioXml.util;
using System;
using System.Linq.Expressions;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        Console.WriteLine("Insira o caminho do XML: \n");
        string path = Console.ReadLine();
        bool t = true;
        ScheduleDay readSchDay = new ScheduleDay(path);

    }
}