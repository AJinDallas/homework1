using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace homework1
{
    class Program
    {
        static void Main(string[] args) {
            ///
            /*
            Person mt = new Person();
            mt.FirstName = "mike";
            mt.LastName = "tyson";
            mt.sayName();
            */
            Person p1 = new Person(true, "sue", "ellen", 10);
            Person p2 = new Person();
            Student p3 = new Student();
            List<Person> pList = new List<Person>();
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);

            //pList.Remove(p3);

            foreach (var person in pList)
            {

                Console.WriteLine(person.FirstName);
            }


            //i1.FirstName = "Mike";
            //i1.LastName = "Jackson";
            //i1.isCoder = true;

            Animal i2 = new Animal();
            i2.Color = "pink";
            i2.HasHorns = true;
            i2.Legs = 4;

            Shape i3 = new Shape();
            i3.Height = 12;
            i3.Width = 10;
            i3.Area = i3.Height * i3.Width;

            //string indentString = new string(' ', indent);

            Console.WriteLine("Height: {0}  Width:{1} Area:{2}", i3.Height, i3.Width, i3.Area);

            foreach (var prop in i2.GetType().GetProperties())
            {

                Console.WriteLine("Type:{0}, Name:{1}, Value:{2}",
                    prop.PropertyType.Name, prop.Name, prop.GetValue(i2)
                    );
            }


            Console.ReadLine();
        }
       
           

       
      
    }

    // PERSON CLASS - #1
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Boolean isCoder { get; set; }
        //public abstract void sayName();
        // Constructor with 0 arguments
        public Person()
        {
            this.FirstName = "Sylvester";
            this.LastName = "Stalone";
            this.isCoder = false;
        }
        // Constructor with 1 arguments
        public Person(Boolean isProgrammer, string fName, string lname, int magicCalc)
        {
            if (magicCalc == 10)
            {
                this.isCoder = isProgrammer;
                this.FirstName = "XYZMadonna";
                this.LastName = "Bannana";
            } else { 
            this.isCoder = isProgrammer;
            this.FirstName = "Madonna";
            this.LastName = "Bannana";
            }

        }

    }


    // ANIMAL CLASS - #2
    public class Animal
    {
        public int Legs { get; set; }
        public string Color { get; set; }
        public Boolean HasHorns { get; set; }
    }
    // SHAPE CLASS - #3
    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int Area { get; set; }
    }


    // STUDENT CLASS
    class Student : Person
    {   /*
        public override void sayName()
        {
            Console.WriteLine("hello, im a Student.... {0}",this.FirstName);
        }
     
        public override void sayName()
        {
            Console.WriteLine("hello, im a Student....");
            //base.sayName();
        }
         * 
        public override void sayUserName()
        {
            Console.WriteLine("the user name is....");
        }
         * */

    }
    // HERO CLASS
    class Hero : Student
    {
        /*
        public override void sayName()
        {
            Console.WriteLine("hello, im a Hero.... {0}", this.FirstName);
        }
         */
    }
}
