using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson33_1
{
    internal class Presure
    {
        private double pa;

        public Presure(double pa) => this.pa = pa;
        public double ToMMRTST() => this.pa / 133.3;
        public double ToBar() => this.pa / 1E+5;
        public double ToAtmo() => this.pa / 101300;
        public double ToKGSil() => this.pa / 1E-5;
    }
}
