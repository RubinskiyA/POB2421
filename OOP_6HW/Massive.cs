using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
        public static void ReverseMas(char[] mas)
        {
            if (mas.Length <= 1)
            {
                return; 
            }

            
            for (int i = 0; i < mas.Length / 2; i++)
            {
                char temp = mas[i];
                mas[i] = mas[mas.Length - i - 1];
                mas[mas.Length - i - 1] = temp;
            }
        }
    }
}
