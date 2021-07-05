using System;
using System.Collections.Generic;

namespace Flights.API
{
    public partial class Flag
    {
        public int Id { get; set; }
        public int? Fileid { get; set; }
        public string Bname { get; set; }
        public double? TsB { get; set; }
        public int? Datei { get; set; }
        public int? Dateizeile { get; set; }
        public int? Gebucht { get; set; }
        public string Version { get; set; }
        public string Datumzeit { get; set; }
        public string Cname { get; set; }
        public string Cip { get; set; }
        public string Kunde { get; set; }
        public double? TsC { get; set; }
        public string Ipcom { get; set; }
        public string Bezug { get; set; }
        public string Soll { get; set; }
        public string Ist { get; set; }
        public int? Status { get; set; }
        public string Statustext { get; set; }
        public string Endezeit { get; set; }
    }
}
