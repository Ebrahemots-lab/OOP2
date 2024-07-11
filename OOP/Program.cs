using OOP.Classes;
using OOP.Encapsulation;
using OOP.Inheritance;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Encapsulation
            //What is OOP
            /*
                             * OOP is a way to orgnize Your code so it's easy to maintain your code later
                             * 
                             * OOP HAs 4 Pillars 
                             * 1 - Abstraction
                             * 2 - Polymorphism
                             * 3 - Inheritanncecc
                             * 4 - Encapsulation
                             */

            //Encapsulaltion
            /*
             * Encapsulation -> 
             *Hide your data and limit access to it inside your application
             *Ex : if you have a class that has a credit card attribute and you want to set limit to acces to it 
             *Simply you make your code Safe any no one will play with your code Unless you give h acccesss
             */
            #endregion

            //Employee emp1 = new(); //Parametless Constructor (Default Values)
            Employee emp1 = new Employee("ebrahem", 26, 2000);

            #region Problems That Encapsulation Solve
            /*
              * Problem1
              * if we change data inside struct itself it will occur error here
              /*emp1.EmpName = "Hema"; */// Invalid because there is no EmpName in struct itself

            /*
             * Problem2 
             * we can't validate our data in Struct for example 
             * Salary must be larger than 3000
             */
            #endregion

            #region Encapsulation Methods

            #region Setter - Getter
            //Getter and Setter
            ////emp1.GetUserName //Invalid
            //Console.WriteLine(emp1.GetUserName()); // Return Name;

            //emp1.SetName("ots"); //Set name using Setter Method 

            //Console.WriteLine(emp1.GetUserName()); // Return Name;

            #endregion


            #region Property
            //Full property - Automatic Propetry - Indexer
            // Must be public

            //emp1.salary = 1000; //Invalid
            emp1.Salary = 3100; // set salary using Property


            //Fulll property - > used for validation
            //automatic -> without validation (Compiler will generate hidden backing Field and assign setter and getter to it by default)

            //emp1.UserAge = 20;
            //Console.WriteLine(emp1.MyProperty);

            //Console.WriteLine(emp1.Salary); // get salary as Getter



            #endregion






            #endregion

            #region PhoneBookExample
            //PhoneBook Note = new PhoneBook(3);
            //Note.AddPerson(0, "Ebrahem", 123);
            //Note.AddPerson(1, "Ashraf", 456);
            //Note.AddPerson(2, "Ahmed", 789);

            //Console.WriteLine( Note.GetPersonDetails("ots"));
            #endregion

            #region PhoneBook2


            //PhoneBook2 phoneBook2 = new (3);
            //Person p1 = new Person(0,"Ebrahem",123);
            //Person p2 = new Person(1,"Ashraf",456);
            //Person p3 = new Person(2,"Alhebashy",789);

            //Person p6 = new Person(3,"Alhebashy",789);// -1 

            //phoneBook2.AddPerson(p1);
            //phoneBook2.AddPerson(p2);
            //phoneBook2.AddPerson(p3);


            //Console.WriteLine(phoneBook2.GetData("ots"));
            #endregion

            #region Indexer
            /*
             * What is Indexer
             * -> indexer allow us to acess spacific elements of struct - class ass array
             * PhoneBook["Ebrahem"] = 123;
             * Same as property but we add this keyword to replace our Struct or class
             * public int this[string name]   
             * public -> acess modifier 
             * int -> return type 
             * this-> indicate we define indexer in the strcut
             * 
                             * 
                             */


            //PhoneBook indexerTest = new PhoneBook(2);
            //indexerTest.AddPerson(0, "Ebrahem", 123);

            //indexerTest.AddPerson(1, "Ashraf", 456);

            //Console.WriteLine(indexerTest["Ebrahem"]);

            //indexerTest["Ebrahem"] = 1010;

            //Console.WriteLine(indexerTest["Ebrahem"]);


            ////Example02
            //for (int i = 0; i < indexerTest.Size; i++)
            //{
            //    Console.WriteLine(indexerTest[i]); // Indexer
            //}

            #endregion

            #region Class
            /*
             * Attribute
             * Functions
             * Event
             * Property
             * Default acess Modifer of Class -> public - internal
            // */


            //Car c1;
            ///*
            // * 1 - Decalre object in the stack and refere to null in the heap
            // * 
            // */

            //c1 = new Car(); //Default Constructr made by me 
            ///*
            // * if we didnt define any costructor the compiler wi generate default parametless constructor 
            // * c1 in the stack and allocated 8 byte for double and 4 byte for string reference [12] byte in the heap
            // * 
            // */

            //Console.WriteLine(c1.ToString());

            //c1 = new Car(200, "BMW");

            //Console.WriteLine(c1.ToString());

            //c1 = new Car(200);

            //Console.WriteLine(c1.ToString());

            #endregion

            #region Inheritance
            //Supported with Class
            /*
             * What is inheritance
             * Simply we inherit all things from parent Class to child class so we can reuse the code without dupliucated code
             */

            Parent p = new Parent(1,2);
            //Console.WriteLine(p);
            //Console.WriteLine(p.Product());


            //We can only override in inheritance
            Child c = new Child(4,5,6);
            Console.WriteLine(c.Product());
            Console.WriteLine(c.ToString());
            #endregion

        }
    }
}
