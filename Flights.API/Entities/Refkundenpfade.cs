using System;
using System.Collections.Generic;

namespace Flights.API
{
    public partial class Refkundenpfade
    {
        public int Id { get; set; }
        public int DelFiles { get; set; }
        public long? Kundenid { get; set; }
        public string Pfad { get; set; }
        public string Backuppfad { get; set; }
    }
}
