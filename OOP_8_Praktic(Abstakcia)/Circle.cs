using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_8_Praktic_Abstakcia_;

namespace OOP_8_Praktic_Abstakcia_
{
    internal class Circle : Figure
    {
        private double r;
        public double R
        {
            get => r;
            set { if (value > 0) r = value; }
        }

        public override double GetArea()
        {
            return Math.PI * r * r;
        }

        public override double GetPerimeter()
        {
            return 2*Math.PI * r;
        }
    }
}
