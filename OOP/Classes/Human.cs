using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_MasterClass
{
    class Human
    {
        public string firstName;
        public float age;
        
        public void IntroduceMyself()
        {
            Console.WriteLine("Hi, I'm " + firstName);
            Console.WriteLine("I'm " + age + " years old!");
        }
    }
}
