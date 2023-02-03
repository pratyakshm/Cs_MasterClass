using System;


namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box();
            // box.SetLength(5);
            box.Length = -5;
            box.DisplayInfo();
        }
    }
}