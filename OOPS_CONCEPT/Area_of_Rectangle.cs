using System;

namespace OOPS_CONCEPT
{
    class Area_of_Rectangle
    {
        double length;
        double width;
        public void Rectangle(double length,double width)
        {
            this.length = length;
            this.width = width;
            Console.WriteLine("Length:" + length);
            Console.WriteLine("Width:" + width);
            Console.WriteLine("Area:" + this.length * this.width);
        }
        
        
        class Area
        {
            static void Main()
            {
                Area_of_Rectangle r = new Area_of_Rectangle();
                r.Rectangle(10, 20);
            }
        }

    }
}