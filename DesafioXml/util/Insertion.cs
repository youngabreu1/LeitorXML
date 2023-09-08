using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace DesafioXml.util
{
    public class Insertion
    {
        public string Id { get; set; }
        public string CTA { get; set; }
        public string Source { get; set; }
        public string MovedTo { get; set; }
        public string Type { get; set; }
        public string Title { get; set; }
        public string File { get; set; }
        public string Folder { get; set; }
        public string Text { get; set; }
        public string Checked { get; set; }
        public string Err { get; set; }
        public string sErr { get; set; }
        public string HoraAudio { get; set; }
        public string HoraPK { get; set; }
        public string IsAudioFile { get; set; }
        public string DurOrig { get; set; }
        public string Dur { get; set; }
        public string Refr { get; set; }
        public string DurRefr { get; set; }
        public string PtVh { get; set; }
        public string PtMx { get; set; }
        public string MxIni { get; set; }
        public string Intro { get; set; }
        public string PtLoc { get; set; }
        public string Vol { get; set; }
        public string Bitrate { get; set; }
        public string Reg { get; set; }
        public string MD5 { get; set; }
        public Insertion(XmlNode insElement)
        {

            Id = insElement.Attributes["Id"]?.Value;
            CTA = insElement.Attributes["CTA"]?.Value;
            Source = insElement.Attributes["Source"]?.Value;
            MovedTo = insElement.Attributes["MovedTo"]?.Value;
            Type = insElement.Attributes["Type"]?.Value;
            Title = insElement.Attributes["Title"]?.Value;
            File = insElement.Attributes["File"]?.Value;
            Folder = insElement.Attributes["Folder"]?.Value;
            Text = insElement.Attributes["Text"]?.Value;
            Checked = insElement.Attributes["Checked"]?.Value;
            Err = insElement.Attributes["Err"]?.Value;
            sErr = insElement.Attributes["sErr"]?.Value;
            HoraAudio = insElement.Attributes["HoraAudio"]?.Value;
            HoraPK = insElement.Attributes["HoraPK"]?.Value;
            IsAudioFile = insElement.Attributes["IsAudioFile"]?.Value;
            DurOrig = insElement.Attributes["DurOrig"]?.Value;
            Dur = insElement.Attributes["Dur"]?.Value;
            Refr = insElement.Attributes["Refr"]?.Value;
            DurRefr = insElement.Attributes["DurRefr"]?.Value;
            PtVh = insElement.Attributes["PtVh"]?.Value;
            PtMx = insElement.Attributes["PtMx"]?.Value;
            MxIni = insElement.Attributes["MxIni"]?.Value;
            Intro = insElement.Attributes["Intro"]?.Value;
            PtLoc = insElement.Attributes["PtLoc"]?.Value;
            Vol = insElement.Attributes["Vol"]?.Value;
            Bitrate = insElement.Attributes["Bitrate"]?.Value;
            Reg = insElement.Attributes["Reg"]?.Value;
            MD5 = insElement.Attributes["MD5"]?.Value;

        }
        public override string ToString()
        {
            return $"Id: {Id}, " +
               $"Source: {Source}, " +
               $"Type: {Type}, " +
               $"Title: {Title}, " +
               $"File: {File}, " +
               $"Folder: {Folder}, " +
               $"Text: {Text}, " +
               $"Checked: {Checked}, " +
               $"Err: {Err}, " +
               $"sErr: {sErr}, " +
               $"HoraAudio: {HoraAudio}, " +
               $"HoraPK: {HoraPK}, " +
               $"IsAudioFile: {IsAudioFile}, " +
               $"DurOrig: {DurOrig}, " +
               $"Dur: {Dur}, " +
               $"Refr: {Refr}, " +
               $"DurRefr: {DurRefr}, " +
               $"PtVh: {PtVh}, " +
               $"PtMx: {PtMx}, " +
               $"MxIni: {MxIni}, " +
               $"Intro: {Intro}, " +
               $"PtLoc: {PtLoc}, " +
               $"Vol: {Vol}, " +
               $"Bitrate: {Bitrate}, " +
               $"Reg: {Reg}, " +
               $"MD5: {MD5}, \n\n";
        }
    }
}