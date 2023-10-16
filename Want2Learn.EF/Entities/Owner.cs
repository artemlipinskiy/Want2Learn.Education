using System;
using System.Collections.Generic;
using System.Text;

namespace Want2Learn.EF.Entities
{
    public class Owner
    {
        public int OwnerId { get; set; }
        public string Fullname { get; set; }

        public ICollection<Flat> Flats { get; set; }
    }
}
