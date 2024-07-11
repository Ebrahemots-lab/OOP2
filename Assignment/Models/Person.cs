using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    internal struct Person
    {
        #region Attributes
        string[] names;

        int[] ages;

        public int Size { get;}
        #endregion

        #region Constructors
        public Person()
        {
            Size = 3;
            names = new string[3];
            ages = new int[3];
        }
        #endregion

        #region Methods
        //Method to add Person
        public void AddPerson(int position , string name , int age) 
        {
            if (isNotNull() && position < Size) 
            {
                names[position] = name;
                ages[position] = age;
            }
        }

        //Indexer
        public string this[int index] 
        {
            get 
            {
                return names[index];
            }
        }

        public void DisplayOldest() 
        {
            int oldestAge = ages.Max();
            int indexOfOldest = Array.IndexOf(ages, oldestAge);
            Console.WriteLine($"Oldest Age is: {names[indexOfOldest]} with {oldestAge}");
        }
        #endregion

        #region Helper Method
        bool isNotNull() 
        {
            if (names is not null && ages is not null)
            {
                return true;
            }
            return false;
        }
        #endregion


    }
}
