using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Encapsulation
{
    internal struct Employee
    {
        #region Attributes

        private string? UserName;

        public int MyProperty { get; } = 100;

        private double salary;
        #endregion

        #region Constructor
        public Employee(string? userName, int userAge, double salary)
        {
            UserName = userName;
           
            Salary = salary;
        }
        #endregion

        #region Getter - Setter 
        public string GetUserName() 
        {
            return UserName!;
        }

        public void SetName(string name) 
        {
            UserName = name.Length < 5 ? name + "Ots" : name;
        }
        #endregion

        #region Property
       

        public double Salary
        {
            get { return salary; }
            //Ready only prperty 
            set 
            {
                salary = value < 3000 ? 3000 : value;  // Validation
            }
        }

        


        #endregion


        public override string ToString()
        {
            return $"Name: {UserName} -  - Salary: {Salary}";
        }


    }
}
