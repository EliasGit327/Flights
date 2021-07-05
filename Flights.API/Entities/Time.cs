using System;
using System.Collections.Generic;

namespace Flights.API
{
    public partial class Time
    {
        public int Rowid { get; set; }
        public string Cname { get; set; }
        public int? KundenId { get; set; }
        public string ZeitNummer { get; set; }
        public string Zeitname { get; set; }
        public string Moauf { get; set; }
        public string Mozu { get; set; }
        public string Diauf { get; set; }
        public string Dizu { get; set; }
        public string Miauf { get; set; }
        public string Mizu { get; set; }
        public string Doauf { get; set; }
        public string Dozu { get; set; }
        public string Frauf { get; set; }
        public string Frzu { get; set; }
        public string Saauf { get; set; }
        public string Sazu { get; set; }
        public string Soauf { get; set; }
        public string Sozu { get; set; }
    }
}
