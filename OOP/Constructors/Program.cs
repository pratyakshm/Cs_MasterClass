using CSharp_MasterClass;
using System;
using System.Security.Cryptography;

namespace Program
{
    class Master
    {
        static void Main(string[] args)
        {
            // PRATYAKSH

            // Create an object of class Human and use constructor to assign values
            Human pratyaksh = new Human("Pratyaksh", "Mehrotra", 20, "brown");
            pratyaksh.IntroduceMyself();


            // CLIPPY

            // Create an object of class Human and use constructor to assign values

            Human clippy = new Human("Clippy", "Tay", 0, "black");
            clippy.IntroduceMyself();
        }
    }
}