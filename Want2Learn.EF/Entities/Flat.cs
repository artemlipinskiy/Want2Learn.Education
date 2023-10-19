using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Want2Learn.EF.Entities
{
    [Table("Apartments")]
    public class Flat
    {
        public int FlatId { get; set; }
        public int? Number { get; set; }
        public string AdditionalName { get; set; }

        public int BuildingId { get; set; }
        public Building Building { get; set; }

        public ICollection<Owner> Owners { get; set; }
    }
}
