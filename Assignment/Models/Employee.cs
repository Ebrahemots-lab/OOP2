using Assignment.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    internal class Employee
    {
        #region Property
        //public int Id { get; set; }

        //public string Name { get; set; }

        //public double Salary { get; set; }

        //public HiringDate HireDate { get; set; }

        //public Gender Gender { get; set; }

        //public Levels Level { get; set; } 
        #endregion

        int id;

        string name;

        double salary;

        HiringDate hireDate;

        Gender gender;

        Levels level;

        #region Setter - Getter Method

        public int GetId() 
        {
            return id;
        }

        public string GetName()
        {
            return name;
        }

        public HiringDate GetHireDate()
        {
            return hireDate;
        }

        public Gender GetGender() 
        {
            return gender;  
        }

        public Levels GetLevel() 
        {
            return level;
        }

        #region Setter
        //I will use constructor Instead
        public void SetId(int _id)
        {
            id = _id;
        }

        public void SetName(string Name)
        {
            name = Name;
        }

        public void SetSalary(double Salary) 
        {
            salary = Salary;
        }    

        public void SetHiringDate(HiringDate date)
        {
            hireDate = date;
        }

        public void SetGender(Gender _gender)
        {
            gender = _gender;
        }

        public void SetLevel(Levels lvl)
        {
            level = lvl;
        }
        #endregion


        #endregion

        #region Ctors

        public Employee()
        {
            //Do Nothing
        }

        public Employee(int _id, string _name, double _salary, HiringDate _hireDate, Gender _gender, Levels _level)
        {
            id = _id;
            name = _name;
            salary = _salary;
            hireDate = _hireDate;
            gender = _gender;
            level = _level;
        }
        #endregion

        public override string ToString()
        {
            return $"Id: {id}:: Name: {name} :: Salary {salary:c} :: HireDate: {hireDate} :: Gender: {gender} :: Level: {level}";
        }


    }
}
