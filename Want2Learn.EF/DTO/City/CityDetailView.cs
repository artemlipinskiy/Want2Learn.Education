using System;
using System.Collections.Generic;
using System.Text;

namespace Want2Learn.EF.DTO.City
{
    public class CityDetailView
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Population { get; set; }
        public List<string> Streets { get; set; }
    }
}
