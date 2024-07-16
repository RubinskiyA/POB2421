using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson27_4
{
    internal class Numbers
    {
        public int CalculateAverage(int[] mas)
        {
            int avgMas = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                avgMas += mas[i];
            }
            return avgMas / mas.Length;
        }
        public bool IsPrime(int n)
        {
            int count = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0) count++;
            }
            if (count < 2) return true;
            else return false;
        }
        public bool IsEven(int n)
        {
            if (n % 2 == 0) return true;
            else return false;
        }
        public bool IsOdd(int n)
        {
            if (n % 2 == 0) return false;
            else return true;
        }
        public int CalculateFactorial(int n)
        {
            {
                if (n == 0) return 1;
                else return n * CalculateFactorial(n - 1);
            }
        }
        public string ConvertToBinary(int n)
        {
            return Convert.ToString(n, 2);
        }
        public string ConvertToHex(int n)
        {
            return Convert.ToString(n, 16);
        }
        public double CalculatePower(double n,double m)
        {
            return Math.Pow(n, m);
        }
    }
}
