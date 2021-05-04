using WebApplication3.Data.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Data.model;

namespace WebApplication3.Data.mocks {
    public class MockCars : IAllCars{

        private readonly ICarsCetegore _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars {
            get {
                return new List<Car> {
                    new Car{name ="И1-А", Category = _categoryCars.AllCategory.First(),prise = 0}
                };
            }
        }
        public IEnumerable<Car> GetFavCars { get ; set ; }

        public Car GetObjectCar(int carid)
        {
            throw new NotImplementedException();
        }
    }
}
