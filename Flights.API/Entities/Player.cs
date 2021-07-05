using System;
using System.Collections.Generic;

namespace Flights.API
{
    public partial class Player
    {
        public int Rowid { get; set; }
        public string Cname { get; set; }
        public string Cip { get; set; }
        public int? Pwdgrp { get; set; }
        public int? Status { get; set; }
        public int? Cunit { get; set; }
        public string FilNr { get; set; }
        public int? KundenId { get; set; }
        public string Playername { get; set; }
        public string Position { get; set; }
        public string Positiontype { get; set; }
        public int? Aktiv { get; set; }
        public string SerienNr { get; set; }
        public string Modell { get; set; }
        public string Hersteller { get; set; }
        public string Prozessor { get; set; }
        public string Os { get; set; }
        public string Ostyp { get; set; }
        public string Osversion { get; set; }
        public string Monapp { get; set; }
    }
}
