using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using Want2Learn.EF.Entities;

namespace Want2Learn.EF
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (TestDbContext context = new TestDbContext())
            //{
            //    var city = new City { Name = "Voronezh", Population = 1500000 };
            //    context.Add(city);
            //    context.SaveChanges();
            //}

            //using(TestDbContext context = new TestDbContext())
            //{
            //    var cities = context.Cities.Where(x => x.Id > 1).ToList();
            //}

            using (TestDbContext context = new TestDbContext())
            {
                var city = context.Cities.FirstOrDefault(x => x.Name == "Voronezh");
                if (city != null)
                {
                    context.Remove(city);
                    context.SaveChanges();
                }
            }

            using (TestDbContext context = new TestDbContext())
            {
                var city = context.Cities.FirstOrDefault(x => x.Name == "Kazan");
                if (city != null)
                {
                    city.Population = 3500000;
                    context.SaveChanges();
                }
            }

            using (TestDbContext context = new TestDbContext())
            {
                var city = context.Cities.AsNoTracking().FirstOrDefault(x => x.Name == "Kazan");
                if (city != null)
                {
                    city.Population = 4500000;
                    context.SaveChanges();
                }
            }
            Console.WriteLine("Hello World!");
        }
    }
}
