using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP_9Hw
{
    internal class Liquid
    {
        public string? Name {  get; set; }
        private double density;
        public double Density 
        { get { return density; } 
          set { if(value>0) density = value;
                else throw new ArgumentException("Плотность не может ровняться или быть меньше 0");
            }
        }
        public Liquid(string? name, double density)
        {
            Name = name;
            Density = density;
        }
        public void SetDensity(double newDensity)
        {
            Density = newDensity;
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Жидкость: {Name}, Плотность: {density} г/см³");
        }

    }

}
