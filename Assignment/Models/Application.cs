using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    internal struct Application
    {
        Person2[] persons;

        public int Size { get; }

        #region Ctors
        public Application()
        {
            Size = 3;
            persons = new Person2[Size];
        }
        #endregion



        #region Indexer
        public Person2 this[int index]
        {
            set
            {
                persons[index] = value;
            }

            get
            {
                return persons[index];
            }
        } 
        #endregion



    }
}
