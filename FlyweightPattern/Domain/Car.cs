using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern.Domain
{
    class Car : ICar
    { 
        

        public Car(CarMakeEnum make, string color)
        {
            CarMake = make;
            Color = color;
        }

        public CarMakeEnum CarMake { get; }

        public string Color { get; }

        public string IntrinsicIdentifier
        {
            get { return $"{CarMake.ToString()}{Color}"; }
        }


        public static string GetCarIdentity(CarMakeEnum make, string color)
        {
            return $"{make.ToString()}{color}";
        }
    


        public void Driving(int speed, string threadName)
        {
            Console.WriteLine($"{threadName} {this.GetHashCode()} >> {Color} color {CarMake} is driven at {speed} kmph.");
        }
    }
}
