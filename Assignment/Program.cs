using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using Assignment.Models;
using Assignment.Enums;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 01
            //1 Define a struct "Person" with properties "Name" and "Age". 
            //Create an array of three "Person" objects and populate it with data.Then,
            //    write a C# program to display the details of all the persons in the array.

            //Person p = new Person();

            //p.AddPerson(0,"Ebrahem",26);
            //p.AddPerson(1,"Ashraf",25);
            //p.AddPerson(2,"Ots",23);

            //for(int i = 0; i < p.Size; i++) 
            //{
            //    Console.WriteLine(p[i]); 
            //}


            //Another Way
            /*
             * Create Struct app Data 
             * Contain a list of person -> name - age 
             */

            //Application app = new Application();

            //app[0] = new Person2 { Age = 20 , Name = "Ebrahem"};

            //app[1] = new Person2 { Age = 22 , Name = "Ashraf"};

            //app[2] = new Person2 { Age = 23 , Name = "Ahmed"};

            //for(int i = 0; i < app.Size; i++) 
            //{
            //    Console.WriteLine(app[i].Name);
            //}

            #endregion

            #region 02
            //Create a struct called "Person" with properties "Name" and "Age".
            //Write a C# program that takes details of
            //3 persons as input from the user and displays the name and age of the oldest person.

            //Person person = new Person();
            //person.AddPerson(0,"Ebrahem",26);
            //person.AddPerson(1,"Ashraf",24);
            //person.AddPerson(2,"Ahmed",23);

            //person.DisplayOldest();
            #endregion

            #region 03
            //1.	Design and implement a Class for the employees in a company:
            Employee[] emps = new Employee[3];
            int[] indexs = new int[3];

            Employee dbaEmp = new Employee
                (
                    0, "Ebrahem", 3000, new HiringDate(4, 10, 1998), Enums.Gender.Male, Levels.Dba
                );

            Employee guestEmp = new Employee
                (
                    1, "Ashraf", 2000, new HiringDate(3, 4, 1991), Gender.Male, Levels.Gest
                );

            Employee securityOfficer = new Employee();

            securityOfficer.SetId(2);
            securityOfficer.SetName("ots");
            securityOfficer.SetSalary(5000);
            securityOfficer.SetHiringDate(new HiringDate(2, 2, 1995));
            securityOfficer.SetGender(Gender.Male);

            //Levels x = Levels.Gest ^ Levels.Devloper ^ Levels.Secretary ^ Levels.Dba;
            Levels FullPermissions = (Levels)15;
            securityOfficer.SetLevel(FullPermissions);


            emps[0] = dbaEmp;
            emps[1] = guestEmp;
            emps[2] = securityOfficer;


           for(int i = 0; i < emps.Length; i++) 
            {
                indexs[i] = emps[i].GetHireDate().Years;
            }



            Array.Sort(indexs);
        
            #endregion

        }

       
    }
}
