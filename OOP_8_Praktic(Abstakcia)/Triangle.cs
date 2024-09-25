using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_8_Praktic_Abstakcia_
{
    internal class Triangle:Figure
    {
        private double a;
        private double b;
        private double c;
        public double A
        {
            get => a;
            set
            {
                if (value > 0) a = value;
            }
        }
        public double B
        {
            get => b;
            set
            {
                if (value > 0) b = value;
            }
        }
        public double C
        {
            get => c;
            set
            {
                if (value > 0) c = value;
            }
        }

        public override double GetArea()
        {
             double pp=GetPerimeter()/2;
            return Math.Sqrt(pp*(pp-a)*(pp-b)*(pp-c));
        }

        public override double GetPerimeter()
        {
            return a+b+c;
        }
    }
}
