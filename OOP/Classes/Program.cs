using CSharp_MasterClass;
using System;

namespace Program
{
    class Master
    {
        static void Main(string[] args)
        {
            // PRATYAKSH

            // Create an object of class Human
            Human pratyaksh = new Human();
            // FYI, this ain't a constructor.

            // Change firstName of Pratyaksh
            pratyaksh.firstName = "Pratyaksh";
            pratyaksh.age = 20;

            // Calls method from Human class
            pratyaksh.IntroduceMyself();


            // CLIPPY

            // Create another object of class Human
            Human clippy = new Human();

            // Change firstName of Clippy
            clippy.firstName = "Clippy";
            clippy.age = 0;

            // Calls method from Human class
            clippy.IntroduceMyself();
        }
    }
}