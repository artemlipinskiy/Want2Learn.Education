using System;
using System.Collections.Generic;
using System.Text;

namespace Want2Learn.EF.Entities
{
    public class Street
    {
        public int StreetId { get; set; }
        public string Name { get; set; }

        public int CityId { get; set; }
        public City City { get; set; }

        public ICollection<Building> Buildings { get; set; }
    }
}
