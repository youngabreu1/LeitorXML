
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using DesafioXml.util;
using System.Collections.Generic;

namespace DesafioXml.util
{
    public class Break
    {
        public string Name { get; set; }    
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
        public List<Insertion> Insercoes { get; set; }

        public Break(XmlNode breakElement)
        {
            Insercoes = new List<Insertion>();
            Name = breakElement.Name;
            Ins = breakElement.Attributes["Ins"]?.Value;
            Locked = breakElement.Attributes["Locked"]?.Value;
            Changed = breakElement.Attributes["Changed"]?.Value;
            Filetime = breakElement.Attributes["Filetime"]?.Value;
            Filetime2 = breakElement.Attributes["Filetime2"]?.Value;
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
        public void ListInsertions(XmlNode breakNode)
        {
            foreach (XmlNode insertionElement in breakNode.ChildNodes)
            {
                Insertion insertionInstance = new Insertion(insertionElement);
                Insercoes.Add(insertionInstance);
                Console.WriteLine(insertionInstance);
            }
        }

        public override string ToString()
        {
            return $": {Name}, " +
            $"Ins: {Ins}, " +
            $"Locked: {Locked}, " +
            $"Changed: {Changed}, " +
            $"Filetime: {Filetime}, " +
            $"Filetime2: {Filetime2}, " +
            $"Time: {Time}, " +
            $"Type: {Type}, " +
            $"Id: {Id}, " +
            $"Id_Edited: {Id_Edited}, " +
            $"Fixo: {Fixo}, " +
            $"Descarte: {Descarte}, " +
            $"Net: {Net}, " +
            $"Dur: {Dur}, " +
            $"Slots: {Slots}, " +
            $"Orig: {Orig}\n\n";

        }
        public void PrintBreak(Break breaks)
        {
            Console.WriteLine(breaks);
        }
    }
}
