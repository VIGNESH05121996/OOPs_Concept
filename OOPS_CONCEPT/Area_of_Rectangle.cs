using System;

namespace OOPS_CONCEPT
{
    class AreaOfRectangle
    {
        double length;
        double width;
        public void Rectangle()
        {
            length = 10;
            width = 20;
        }
        public double Area()
        {
             return length * width;
        }

        public void Display()
        {
            Console.WriteLine("Length:", length);
            Console.WriteLine("Width:", width);
            Console.WriteLine("Area:", Area());
        }
    }
}
