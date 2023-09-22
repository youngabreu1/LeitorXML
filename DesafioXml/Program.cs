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

        string path = Utils.PathVerification();
        string inputDate = Utils.DataVerification();
        string inputTime = Utils.TimeVerification();
        string montagemFile = path + @"\" + inputDate + ".zip";
        
        ScheduleDay readSchDay = new ScheduleDay(path, montagemFile, inputTime);

    }

}