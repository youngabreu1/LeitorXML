
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using DesafioXml.util;

namespace DesafioXml.util
{
    public class Break
    {
        public string Ins { get; set; }
        public string Locked { get; set; }
        public string Changed { get; set; }
        public string Filetime { get; set; }
        public string Filetime2 { get; set; }
        public string Time { get; set; }
        public string Type { get; set; }
        public string Id { get; set; }
        public string Id_Edited { get; set; }
        public string Fixo { get; set; }
        public string Descarte { get; set; }
        public string Net { get; set; }
        public string Dur { get; set; }
        public string Slots { get; set; }
        public string Orig { get; set; }

        public Break(XmlNode breakElement)
        {
            Ins = breakElement.Attributes["Ins"]?.Value;
            Locked = breakElement.Attributes["Locked"]?.Value;
            Changed = breakElement.Attributes["Changed"]?.Value;
            Filetime = breakElement.Attributes["Filetime"]?.Value;
            Filetime2 = breakElement.Attributes["Filetime2"]?.Value;
            Time = breakElement.Attributes["Time"]?.Value;
            Type = breakElement.Attributes["Type"]?.Value;
            Id = breakElement.Attributes["Id"]?.Value;
            Id_Edited = breakElement.Attributes["Id_Edited"]?.Value;
            Fixo = breakElement.Attributes["Fixo"]?.Value;
            Descarte = breakElement.Attributes["Descarte"]?.Value;
            Net = breakElement.Attributes["Net"]?.Value;
            Dur = breakElement.Attributes["Dur"]?.Value;
            Slots = breakElement.Attributes["Slots"]?.Value;
            Orig = breakElement.Attributes["Orig"]?.Value;
        }

        public override string ToString()
        {
            return $"Ins: {Ins}\n" +
                   $"Locked: {Locked}\n" +
                   $"Changed: {Changed}\n" +
                   $"Filetime: {Filetime}\n" +
                   $"Filetime2: {Filetime2}\n" +
                   $"Time: {Time}\n" +
                   $"Type: {Type}\n" +
                   $"Id: {Id}\n" +
                   $"Id_Edited: {Id_Edited}\n" +
                   $"Fixo: {Fixo}\n" +
                   $"Descarte: {Descarte}\n" +
                   $"Net: {Net}\n" +
                   $"Dur: {Dur}\n" +
                   $"Slots: {Slots}\n" +
                   $"Orig: {Orig}\n";
        }
    }
}
