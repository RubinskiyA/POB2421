using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_9Hw
{
    internal class Alcohol:Liquid
    {
        private double strength;
        public double Strength
        {
            get { return strength; }
            set 
            { if (value > 0||value<100) strength = value; 
            else throw new ArgumentException("Крепость должна быть в пределах от 0 до 100.");
            }
        }

        public Alcohol(string name, double density, double strength):base (name, density)
        {
            Strength = strength;
        }
        public void SetStrength(double newStrength)
        {

            Strength = newStrength;
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Крепость: {strength}%");
        }
    }
}
