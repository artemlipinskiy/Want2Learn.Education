using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Want2Learn.EF.Entities
{
    public class City
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Population { get; set; }

        public ICollection<Street> Streets { get; set; }
    }
}
