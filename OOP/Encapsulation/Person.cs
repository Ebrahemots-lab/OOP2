using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Encapsulation
{
    internal struct Person
    {
        public int Index { get; }

        public string Name { get; }

        public int Number { get; }


        public Person(int index , string name, int nubmer)
        {
            Index = index;
            Name = name;
            Number = nubmer;
        }


    }
}
