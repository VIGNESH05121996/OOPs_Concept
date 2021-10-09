using System;

namespace OOPs_Concept
{
    //Encapsulation Area of Rectangle
    class AreaOfRectangle
    {
        // public methods of class
        private double length;
        private double width;

        // using accessors to get and 
        // set the value of studentName
        public double Length
        {

            get
            {
                return length;
            }

            set
            {
                length = value;
            }

        }

        // using accessors to get and 
        // set the value of studentAge
        public double Width
        {

            get
            {
                return width;
            }

            set
            {
                width = value;
            }
        }
    }
    class Output
    {
        public static void Main()
        {
            AreaOfRectangle r = new AreaOfRectangle();
            r.Length = 10;
            r.Width = 20;
            Console.WriteLine("Length: " + r.Length);
            Console.WriteLine("Width:" + r.Width);
            Console.WriteLine("Area:" + r.Length * r.Width);
        }
    }
}
