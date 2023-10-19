using System;
using System.Collections.Generic;
using System.Text;

namespace Want2Learn.EF.DTO.City
{
    public class CityUpdate
    {
        public int Id { get; internal set; }
        public string Name { get; internal set; }
        public int Population { get; internal set; }
    }
}
