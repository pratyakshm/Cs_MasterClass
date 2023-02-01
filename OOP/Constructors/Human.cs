using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_MasterClass
{
    class Human
    {
        private readonly string firstName;
        private readonly string lastName;
        private readonly float age;
        private readonly string eyeColor;

        // This is a Constructor - a special method that runs as soon as an object of this class is created.
        // Constructors are typically used to assign values to them during creation of objects.

        // Parameterized constructors

        public Human(string firstName, string lastName, float age, string eyeColor)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.eyeColor = eyeColor;
        }

        public Human(string firstName, string lastName, string eyeColor)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
        }

        // Default constructor
        public Human()
        {
            Console.WriteLine("Constructor called. Object was created.");
        }

        public void IntroduceMyself()
        {
            if (lastName == null)
            {
                Console.WriteLine("Hi, this is {0}. I'm {1} years old.", firstName, eyeColor);
            }
            if (age == 0)
            {
                Console.WriteLine("Hi, this is {0} {1}. I have {2} eyes.", firstName, lastName, eyeColor);
            }
            //Console.WriteLine("Hi, I'm " + firstName + " " + lastName + "\nI'm " + age + " years old." + "\nI have " + eyeColor + " colored eyes.");
            Console.WriteLine("Hi, I'm {0} {1}, I'm {2} years old and I have {3} eyes.", firstName, lastName, age, eyeColor);
        }
    }
}