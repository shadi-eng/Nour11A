using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nour11A
{
    internal class Program2
    {
        static void Main2(string[] args)
        {
            Point p1 = new Point(23, 6);
            Point p2= new Point(29, 9);
            Point p3 = new Point(10);
            Point p4 = new Point();
            //p2.y = -200;
            p2.SetY(-200);

            Console.WriteLine(p1.GetX());
            Console.WriteLine(p3.GetX());

            p4.SetX(p4.GetX() + 50);
            int aaa = p4.GetX();
        }
    }
}
