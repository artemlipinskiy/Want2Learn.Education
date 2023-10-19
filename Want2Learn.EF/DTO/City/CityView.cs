using System;
using System.Collections.Generic;
using System.Text;

namespace Want2Learn.EF.DTO.City
{
    public class CityView
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Population { get; internal set; }
    }
}
