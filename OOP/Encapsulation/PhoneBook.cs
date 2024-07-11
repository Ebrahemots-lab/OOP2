using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOP.Encapsulation
{
    internal struct PhoneBook
    {
        string[] names;

        int[] numbers;

        public int Size{ get; }


        #region Indexer
        public int this[string name] 
        {
            get
            {
                if (ValidateArray()) 
                {
                    int index = Array.IndexOf(names, name);
                    return numbers[index];
                }
                return -1;
            }
            set 
            {
                if (ValidateArray()) 
                {
                   for(int i = 0; i < names.Length; i++) 
                    {
                        if (names[i] == name) 
                        {
                            numbers[i] = value;
                        }
                    }
                }
            }
        }


        public string this[int index] 
        {
            get 
            {
                return names[index];    
            }
        }

        #endregion


        public PhoneBook(int size)
        {
            Size = size;  
            names = new string[size];
            numbers = new int[size];
        }

        bool ValidateArray() 
        {
            bool isValid;
            if(names is not null && numbers is not null) 
            {
                isValid =  true;
            }
            else 
            {
                isValid = false;    
            }

            return isValid;
        }

        public void AddPerson(int position , string name , int number) 
        {
            if (ValidateArray()) 
            {
                if(position < Size) 
                {
                    names[position] = name;
                    numbers[position] = number;
                }
            }
        }

        public int GetPersonDetails(string name)
        {
            if (ValidateArray()) 
            {
               bool isFound =  names.Contains(name);

                if (isFound)
                {
                    int index = Array.IndexOf(names, name);
                    return numbers[index];
                }

            }
            return -1;
        }




    }
}
