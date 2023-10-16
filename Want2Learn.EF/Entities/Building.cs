using System;
using System.Collections.Generic;
using System.Text;

namespace Want2Learn.EF.Entities
{
    public class Building
    {
        public int BuildingId { get; set; }
        public int Number { get; set; }
        public string AdditionalName { get; set; }

        public int StreetId { get; set; }
        public Street Street { get; set; }

        public ICollection<Flat> Flats { get; set; }
    }
}
