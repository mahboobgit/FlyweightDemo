using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FlyweightPattern.Domain
{
    class CarFactory
    {
        IDictionary<string, ICar> carRepo = new Dictionary<string, ICar>(); 


        public ICar GetCar(CarMakeEnum make, string color)
        {
            List<Task<ICar>> tasks = new List<Task<ICar>>();
            foreach(var kvp in carRepo)
            {
                tasks.Add(Task<ICar>.Factory.StartNew(() => CarCompare(kvp.Value, Car.GetCarIdentity(make, color))));
            }

            Task.WaitAll(tasks.ToArray());

            foreach(var taskResult in tasks)
            {
                if (taskResult.Result != null)
                    return taskResult.Result;
            }

            var car = new Car(make, color);
            carRepo.Add(car.IntrinsicIdentifier, car);
            return car;
           
        }

        ICar CarCompare(ICar car, string key)
        {
            //Thread.Sleep(new Random().Next(5000));
            return car.IntrinsicIdentifier == key ? car : null;
        }


    }
}
