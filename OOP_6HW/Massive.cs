using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_6HW
{
    internal class Massive
    {
        public static double CalculateAverage(int[] numbers)
        {
            
            if (numbers.Length == 0)
            {
                throw new ArgumentException("Массив не должен быть пустым");
            }

            
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }

            
            return (double)sum / numbers.Length;
        }
    }
}
