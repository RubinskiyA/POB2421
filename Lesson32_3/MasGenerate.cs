using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lesson32_3
{
    internal class MasGenerate
    {
        private int n;

        public MasGenerate(int n)
        {
            this.n = n;
        }
        public void IntGen(int low,int high)
        {
            int[] mas = new int[n];
            Random random = new Random();
            for (int i = 0; i <mas.Length; i++)
            {
                mas[i] = random.Next(low, high+1);
                Console.Write(mas[i] + " ");
            }
            Console.WriteLine();
        }
        public void strGen(int length)
        {
            Random random = new Random();
            string[] mas = new string[n];
            for(int i = 0; i < mas.Length; i++)
            {
                string res = "";
                for (int j = 0; j < length; j++)
                {
                    res += (char)random.Next(65, 123);
                }
                mas[i] = res;
                Console.Write(mas[i] + " ");
            }
            Console.WriteLine();
        }
        public void boolGen()
        {
            Random random = new Random();
            bool[] mas = new bool[n];
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i]=(random.Next(0, 2)==0)?false:true;
                Console.Write(mas[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
