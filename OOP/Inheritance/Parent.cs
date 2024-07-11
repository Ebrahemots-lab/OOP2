using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance
{
    internal class Parent
    {

        #region Property
        public int X { get; set; }
        public int Z { get; set; }
        #endregion


        #region Constructors
        public Parent(int x, int z)
        {
            X = x;
            Z = z;
        }

        public override string ToString()
        {
            return $"x: {X} - z {Z}";
        }


        public int Product() 
        {
            return X * Z;
        }
        #endregion
    }
}
