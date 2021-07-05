using System;
using System.Collections.Generic;

namespace Flights.API
{
    public partial class Filiale
    {
        public int Rowid { get; set; }
        public string FilNr { get; set; }
        public int? KundenId { get; set; }
        public string Bezeichnung { get; set; }
        public string Ort { get; set; }
        public string Plz { get; set; }
        public string Strasse { get; set; }
        public int? Aktiv { get; set; }
        public int? WeclapNr { get; set; }
    }
}
