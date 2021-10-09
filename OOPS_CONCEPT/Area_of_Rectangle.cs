using System;

namespace OOPS_CONCEPT
{
    public abstract class AreaOfRectangle
    {
        public double length = 10;
        public double width = 20;
        public abstract void Area();
    }
    public class Rect1 : AreaOfRectangle
    {
        public override void Area()
        {
            Console.WriteLine("Length:" + length);
        }

    }

    public class Rect2 : AreaOfRectangle
    {
        public override void Area()
        {
            Console.WriteLine("Width:" + width);
        }

    }

    public class AreRect : AreaOfRectangle
    {
        public override void Area()
        {
            double a = length * width;
            Console.WriteLine("Area:" + a);
        }

    }

    public class arearect
    {
        public static void Main()
        {
            AreaOfRectangle r;
            r = new Rect1();
            r.Area();
            r = new Rect2();
            r.Area();
            r = new AreRect();
            r.Area();
        }
           
    }
}
