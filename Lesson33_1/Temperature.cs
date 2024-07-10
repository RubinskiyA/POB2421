using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson33_1
{
    internal class Temperature
    {
        private double tempC;

        public Temperature(double tempC) => this.tempC = tempC;
        public double TempK() => this.tempC + 273;
        public double TempF() => this.tempC * 1.8 + 32;

    }
}
