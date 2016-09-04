using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern.Domain
{
    public interface ICar
    {
        CarMakeEnum CarMake { get; }
        string Color { get;  }

        string IntrinsicIdentifier { get; }
        
        void Driving(int speed, string threadName); 

    }
} 
