using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Want2Learn.EF.DTO.City;
using Want2Learn.EF.Entities;
using Want2Learn.EF.Interfaces;

namespace Want2Learn.EF.Services
{
    public class CityCRUDService : ICityCRUDService
    {

        public void Create(CityCreate cityCreate)
        {
            if (string.IsNullOrEmpty(cityCreate.Name))
            {
                throw new Exception("City Name field is required");
            }
            if (cityCreate.Population < 0)
            {
                throw new Exception("Population can not be less than 0");
            }

            using (TestDbContext context = new TestDbContext())
            {
                var city = new City
                {
                    Name = cityCreate.Name,
                    Population = cityCreate.Population
                };
                context.Add(city);
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (TestDbContext context = new TestDbContext())
            {
                var city = context.Cities.FirstOrDefault(x => x.Id == id);
                if (city == null)
                {
                    throw new Exception($"City with id ({id}) not found");
                }
                context.Remove(city);
                context.SaveChanges();
            }
        }

        public CityView Get(int id)
        {
            using (TestDbContext context = new TestDbContext())
            {
                var city = context.Cities.FirstOrDefault(x => x.Id == id);

                if (city == null)
                {
                    throw new Exception($"City with id ({id}) not found");
                }

                return new CityView 
                { 
                    Id = city.Id,
                    Name = city.Name,
                    Population = city.Population
                };
            }
        }

        public List<CityView> GetList()
        {
            using (TestDbContext context = new TestDbContext())
            {
                var cities = context.Cities.Select(x => new CityView { Id = x.Id, Name = x.Name }).ToList();
                //var cities2 = context.Cities.Select(x => new CityView { Id = x.Id, Name = x.Name });
                //cities2 = cities2.Where(x => x.Population > 0);
                //cities2 = cities2.ToList();
                return cities;
            }
        }

        public void Update(CityUpdate cityUpdate)
        {
            if (cityUpdate == null)
            {
                throw new Exception();
            }
            using (TestDbContext context = new TestDbContext())
            {
                var city = context.Cities.FirstOrDefault(x => x.Id == cityUpdate.Id);
                if (city == null)
                {
                    throw new Exception($"City with id ({cityUpdate.Id}) not found");
                }
                city.Name = cityUpdate.Name;
                city.Population = cityUpdate.Population;
                context.SaveChanges();
            }
        }
    }
}
