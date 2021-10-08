using System;

namespace OOPS_CONCEPT
{
    public abstract class Area_of_Rectangle
    {
        public double length = 10;
        public double width = 20;
        public abstract void Area();
    }
    public class Rect1 : Area_of_Rectangle
    {
        public override void Area()
        {
            Console.WriteLine("Length:" + length);
        }

    }

    public class Rect2 : Area_of_Rectangle
    {
        public override void Area()
        {
            Console.WriteLine("Width:" + width);
        }

    }

    public class Are_Rect : Area_of_Rectangle
    {
        public override void Area()
        {
            double a = length * width;
            Console.WriteLine("Area:" + a);
        }

    }

    public class area_rect
    {
        public static void Main()
        {
            Area_of_Rectangle r;
            r = new Rect1();
            r.Area();
            r = new Rect2();
            r.Area();
            r = new Are_Rect();
            r.Area();
        }
           
    }
}
