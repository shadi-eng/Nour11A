using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nour11A
{
    internal class Point
    {
        //صفات
        private int x;
        private int y;

        //constructors
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Point()
        {
            x = 100;
            y = 100;
        }

        public Point(int x)
        {
            this.x = x;
            y = x;
        }

        //set get

        public void SetY(int y)
        {
            if (y >= 0)
                this.y = y;
        }

        public int GetY()
        {
            return this.y;
        }

        public void SetX(int x)
        {
                this.x = x;
        }
        public int GetX()
        {
            return this.x;
        }
    }
}
