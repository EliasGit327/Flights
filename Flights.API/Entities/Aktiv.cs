using System;
using System.Collections.Generic;

namespace Flights.API
{
    public partial class Aktiv
    {
        public int Rowid { get; set; }
        public int? Id { get; set; }
        public int? Status { get; set; }
        public string Bezeichnung { get; set; }
    }
}
