using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance
{
    internal class Child : Parent
    {
        public int Y { get; set; }

        //We need to Define a constructor like the parent class 
        //Parent consturctor need x and z so we define constructor in child class then we take x , z then pass it to parent constructor using base
        public Child(int x , int z , int y) : base(x,z)
        {
            Y = y;
        }


        public override string ToString()
        {
            return $"X: {X} - Y: {Y} - Z:{Z}";
        }

        public int Product()
        {
            return base.Product() * Y;
        }
    }
}
