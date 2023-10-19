using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Want2Learn.EF.Entities
{
    public class Street
    {
        [Key]
        public int StreetNumber { get; set; }

        [Column("StreetName")]
        [MaxLength(255)]
        public string Name { get; set; }

        public int CityId { get; set; }
        public City City { get; set; }

        public ICollection<Building> Buildings { get; set; }
    }
}
