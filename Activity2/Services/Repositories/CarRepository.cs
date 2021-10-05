using Activity2.Models;
using Activity2.Services.Interfaces;
using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Activity2.Services.Repositories
{
    public class CarRepository : ICarRepository
    {
        static List<Car> cars = new();
        public int Create(int id)
        {
            throw new NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllCars()
        {
            for (int i = 0; i<100;i++)
            {
                cars.Add(new Faker<Car>()
                    .RuleFor(c => c.Id, i)
                    .RuleFor(c => c.Price, f => f.Random.Decimal(2000000))
                    .RuleFor(c => c.Model, f => f.Vehicle.Model())
                    .RuleFor(c => c.Make, f => f.Company.CompanyName())
                    .RuleFor(c => c.LaunchDate, f => f.Date.Past(20))
                    );
            }
            return cars;
        }

        public Car GetAllCars(int id)
        {
            throw new NotImplementedException();
        }

        public List<Car> SearchCar(string param)
        {
            throw new NotImplementedException();
        }

        public int Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
