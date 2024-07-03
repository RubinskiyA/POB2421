namespace Lesson31._1
{
    public class ClassArray
    {
        public static void Print(double[] mas)
        {
            foreach (var item in mas) Console.Write($"{item:f2} ");
            Console.WriteLine();
        }
        public static double Sum(double[] mas) => mas.Sum();
        public static double Max(double[] mas) => mas.Max();
        public static double Min(double[] mas) => mas.Min();
        public static void Sort(double[] mas) => Array.Sort(mas);
    }
}
