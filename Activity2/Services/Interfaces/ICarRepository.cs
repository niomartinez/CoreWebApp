using Activity2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Activity2.Services.Interfaces
{
    interface ICarRepository
    {
        List<Car> GetAllCars();
        List<Car> SearchCar(string param);
        Car GetAllCars(int id);

        int Create(int id);
        int Update(int id);
        int Delete (int id);
    }
}
