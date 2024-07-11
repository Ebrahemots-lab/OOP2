using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Classes
{
    internal class Car
    {
        public double Speed { get; set; }

        public string Model { get; set; }

        public Car()
        {
            //Default Constructor
        }

        public Car(double speed, string model)
        {
            Speed = speed;
            Model = model;
        }

        public Car(double speed) : this(speed,"BMW") //Constructor Chanining
        {
           
        }

        public override string ToString()
        {
            return $"Car Speed : {Speed}  Model {Model}";
        }
    }
}
