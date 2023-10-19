using System;
using System.Collections.Generic;
using System.Text;
using Want2Learn.EF.DTO.City;

namespace Want2Learn.EF.Interfaces
{
    public interface ICityCRUDService
    {
        public void Create(CityCreate cityCreate);
        public CityView Get(int id);
        public List<CityView> GetList();
        public void Update(CityUpdate cityUpdate);
        public void Delete(int id);

    }
}
