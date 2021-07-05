using System;
using System.Collections.Generic;

namespace Flights.API
{
    public partial class Kunde
    {
        public int Id { get; set; }
        public long? Kundenid { get; set; }
        public string Bezeichnung { get; set; }
        public int Aktiv { get; set; }
    }
}
