using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson33_1
{
   
    internal class Distance
    {
        private double mm;

        public Distance(double mm) => this.mm = mm;
        public double ToSm() => this.mm / 10;
        public double ToMetr() => this.mm / 1000;
        public double ToKilometr() => this.mm / 1E+6;
        public double ToDecim() => this.mm / 100;
    }
}
