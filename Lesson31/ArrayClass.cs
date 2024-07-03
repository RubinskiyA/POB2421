using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson31
{
    internal class ArrayClass
    {
        private double[] mas;

        public ArrayClass(int n)
        {
            this.mas = new double[n];
            Random random = new Random();
            //for (int i = 0; i < n; i++)
            //{
            //    mas[i] = random.NextDouble() * 100;
            //}
            mas=mas.Select(i=>random.NextDouble()*100).ToArray();
        }
        public void Print()
        {
            foreach (var item in mas) Console.Write($"{item:f2} ");
            Console.WriteLine();
        }
        public double Sum() => mas.Sum();
        public double Max() => mas.Max();
        public double Min() => mas.Min();
        public void Sort() => Array.Sort(mas);
        public double[] getMas()=>this.mas;
    }
}
