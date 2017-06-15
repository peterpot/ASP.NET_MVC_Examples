using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AngularJSTutorial.Controllers
{
    public class Car
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public bool isClasic { get; set; }
    }


    public class CarsController : ApiController
    {
        // POST: api/Cars
        public void Post(IEnumerable<Car> Cars)
        {
            //
        }

        public IEnumerable<Car> Get([FromUri] Car car)
        {
            var cars = new List<Car>();
            cars.Add(car);

            cars.Add(new Car
            {
                Name = "Porsche",
                Model = "966 4S",
                isClasic = true
            });

            return cars;
        }
    }
}
