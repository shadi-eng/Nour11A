using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nour11A
{
    internal class ProgramPoint
    {
        static void Main(string[] args)
        {
            //Point p1 = new Point(); //100,100
            //Point p2 = new Point(3, 2); //3,2
            //Point p3 = new Point(7); //7,7



            ////Console.WriteLine(p1.GetInfo());
            ////Console.WriteLine(p2.GetInfo());
            ////Console.WriteLine(p3.GetInfo());
            /////
            //Console.WriteLine();
            //Console.WriteLine(p1); //طباعة مؤشر تعني استدعاء العملية ToString تلقائيا
            //Console.WriteLine(p2);
            //Console.WriteLine(p3);
            ////
            //Console.WriteLine();
            //Console.WriteLine(p1.ToString());
            //Console.WriteLine(p2.ToString());
            //Console.WriteLine(p3.ToString());

            Object p44=new Point(3, 4);
            

            Point p4=new Point(3, 4);
            Point p5;
            Point p6 = null;
            Console.WriteLine(p4);
            //Console.WriteLine(p5);
            Console.WriteLine(p6);
            Console.WriteLine(p6.ToString()); //RunTime Error
        }
    }
}
