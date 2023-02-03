using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Box
    {
        // Member variables
        private int length;
        #pragma warning disable IDE0044 // Add readonly modifier
        private int width;
        #pragma warning restore IDE0044 // Add readonly modifier
        #pragma warning disable IDE0044 // Add readonly modifier
        private int height;
        #pragma warning restore IDE0044 // Add readonly modifier
        #pragma warning disable IDE0044 // Add readonly modifier
        private int volume;
        #pragma warning restore IDE0044 // Add readonly modifier

        // public void SetLength(int length)
        // {
        //    this.length = length;
        // }

        // public int GetLength()
        // {
        //    return length;
        // }

        public int Width { get; set; }

        public int Length {
            get => length;

            // set
            // {
            //    if (value < 0) throw new Exception("Size should be positive");
            //    length = value;
            // }
            set => length = value;
        }

        // public int Length
        // {
        //    get
        //    {
        //        return length;
        //    }

        //    set
        //    {
        //        length = value;
        //    }
        // }



        public void DisplayInfo()
        {
            Console.WriteLine("Length: {0}, Volume: {1}, Width: {2}, Height: {3}", length, volume, width, height);
        }
    }
}
