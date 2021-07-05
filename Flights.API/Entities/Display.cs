using System;
using System.Collections.Generic;

namespace Flights.API
{
    public partial class Display
    {
        public int Rowid { get; set; }
        public string Cname { get; set; }
        public int? KundenId { get; set; }
        public string Monnummer { get; set; }
        public string Ipcom { get; set; }
        public int? Monid { get; set; }
        public string Macadr { get; set; }
        public string MonName { get; set; }
        public string MonGruppe { get; set; }
        public string MonZeitGruppe { get; set; }
        public string Remote { get; set; }
        public string Quelle { get; set; }
        public string FormatI { get; set; }
        public string FormatM { get; set; }
        public string FormatC { get; set; }
        public string Hersteller { get; set; }
        public string Modell { get; set; }
        public string SerNr { get; set; }
        public string Software { get; set; }
        public string Diagonale { get; set; }
        public string ResX { get; set; }
        public string ResY { get; set; }
    }
}
