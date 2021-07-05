using System;
using System.Collections.Generic;

namespace Flights.API
{
    public partial class Pwd
    {
        public int Rowid { get; set; }
        public int? Recid { get; set; }
        public double? Ts { get; set; }
        public int? Pwdgrp { get; set; }
        public string Benutzer { get; set; }
        public string Pwd1 { get; set; }
    }
}
