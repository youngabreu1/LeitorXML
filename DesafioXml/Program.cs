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
        string inputOption = Utils.OptionVerification();
        string montagemFile = path + @"\" + inputDate + ".zip";
        if (inputOption == "1")
        {
            ScheduleDay readSchDay = new ScheduleDay(path, montagemFile);
        }
        else
        {
            string inputTime = Utils.TimeVerification();
            ScheduleDay readSchDay = new ScheduleDay(path, montagemFile, inputTime);
        }
    }

}