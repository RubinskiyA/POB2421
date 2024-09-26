using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_9Hw
{
    internal class Rectangle : Pair
    {
        private double c;
        private double d;
        public double C
        {
            get { return c; }
            set { if (value > 0) c = value; }
        }
        public double D
        {
            get { return d; }
            set { if (value > 0) d = value; }
        }

        public Rectangle(double c, double d) : base(c, d)
        {
            C = c;
            D = d;
        }

        public double Perimeter()
        {
            return 2 * c + 2 * d;
        }
        public double Area()
        {
            return Multi();
        }
    }
}
