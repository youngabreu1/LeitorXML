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
        DateTime inputDate = Utils.DataVerification();
        string inputOption = Utils.OptionVerification();
        if (inputOption == "1")
        {
            ScheduleDay readSchDay = new ScheduleDay(path, inputDate);
        }
        else
        {
            DateTime inputTime = Utils.TimeVerification();
            ScheduleDay readSchDay = new ScheduleDay(path, inputDate, inputTime);
        }
    }

}