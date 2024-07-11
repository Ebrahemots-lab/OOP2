using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Encapsulation
{
    internal struct PhoneBook2
    {
        //struct Person {index, name , number}
        //Person[] data 
        //Method -> Add person into Book
        //Method -> get person details

        //Array to Store objects of Person
        Person[] data;
        public int Size { get; }

        public PhoneBook2(int size)
        {
            Size = size;

            data = new Person[Size];
        }

        //Method to Add Person INTO Phontbook

        public void AddPerson(Person person) 
        {
            if(data is not null && person.Index < Size) 
            {
                data[person.Index] = person;
            }
            else 
            {
                Console.WriteLine("PLease enter valid Info");
            }
        }


        public int GetData(string name) 
        {
            foreach(Person p in data) 
            {
                if(p.Name == name) 
                {
                    return p.Number;
                }
            }
            return -1;
        }
    }
}
