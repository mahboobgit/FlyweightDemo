using FlyweightPattern.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace FlyweightPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CarFactory factory = new CarFactory();
                       

            ICar car = factory.GetCar(CarMakeEnum.Bugati, "red");
            ICar car1 = factory.GetCar(CarMakeEnum.Farari, "brown");
            ICar car3 = factory.GetCar(CarMakeEnum.Bugati, "yellow");
            ICar car4 = factory.GetCar(CarMakeEnum.Farari, "red");
            ICar car5 = factory.GetCar(CarMakeEnum.Farari, "brown");
            ICar car6 = factory.GetCar(CarMakeEnum.Bugati, "yellow");


            car.Driving(23,Thread.CurrentThread.ManagedThreadId.ToString());
            car1.Driving(10, Thread.CurrentThread.ManagedThreadId.ToString());
            car3.Driving(60, Thread.CurrentThread.ManagedThreadId.ToString());
            car4.Driving(90, Thread.CurrentThread.ManagedThreadId.ToString());
            car5.Driving(190, Thread.CurrentThread.ManagedThreadId.ToString());
            car6.Driving(80, Thread.CurrentThread.ManagedThreadId.ToString());
            Console.ReadKey();
        }
    }
 } 
