//Console.Write("Введите первое число: ");
//int num1=int.Parse(Console.ReadLine());
//Console.Write("Введите второе число: ");
//int num2 = int.Parse(Console.ReadLine());
//Console.Write("Введите операцию: ");
//char ch=char.Parse(Console.ReadLine());
//switch (ch)
//{
//    case '+':
//        {
//            Console.WriteLine(Add(num1, num2));
//        }
//        break;
//    case '-':
//        {
//            Console.WriteLine(Sub(num1, num2));
//        }
//        break;
//    case '*':
//        {
//            Console.WriteLine(Mult(num1, num2));
//        }
//        break;
//    case '/':
//        {
//            Console.WriteLine(Div(num1, num2));
//        }
//        break;
////}
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

int Add(int a, int b)
{
    return a + b;
}
int Sub(int a, int b)
{
    return a - b;
}
int Mult(int a, int b)
{
    return a * b;
}
double Div(double a, double b)
{
    if (b!=0) return a / b;
    throw new Exception("Деление на ноль запрещено.");
}

double AvgMas(int[] a)
{
    double s = 0;
    for (int i = 0; i < a.Length; i++)
    {
        s += a[i];
    }
    return s/a.Length;
}

//Random random = new Random();
//int[] mas = new int[random.Next(5, 10)];
//for  (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = random.Next(10,100);
//    Console.Write(mas[i] +" ");
//}
//Console.WriteLine();
//Console.WriteLine(AvgMas(mas)) ;

string Reverse(string s)
{

    string res = "";
    for (int i = s.Length - 1; i >= 0; i--) res += s[i];
    return res;
}
//Console.Write("Введите строку: ");
//string stroka=Console.ReadLine();
//Console.WriteLine(Reverse(stroka));

bool IsSimple(int n)
{
    int k = 0;
    for (int i=2; i < n; i++)
    {
        if (n%i==0) k++;
    }
    if (k==0) return true;
    return false;
}
//Console.WriteLine("Введите число: ");
//int num=int.Parse(Console.ReadLine());
//Console.WriteLine(IsSimple(num));

bool IsAnagramm(string a, string b)
{
    if (a.Length!=b.Length) return false;
    int k = 0;
    for (int i = 0; i < b.Length; i++)
    {
        if (a.Contains(b[i])) k++;
    }
    if (k==b.Length) return true;
    return false;
}
//Console.Write("Введите первое слово: ");
//string one =Console.ReadLine();
//Console.Write("Введите второе слово: ");
//string two = Console.ReadLine();
//if(IsAnagramm(one,two)) Console.WriteLine("Анаграммы");
//else Console.WriteLine("не анаграммы");

int CountWord(string s)
{
    return s.Split(' ').Length;
}

//Console.Write("Введите строку: ");
//string str=Console.ReadLine();
//Console.WriteLine($"Количество слов: {CountWord(str)}");

long Factorial(int num)
{
    long f = 1;
    for (int i = 1;i <= num; i++)
    {
       f *= i;
    }
        return f;
}
//Console.Write("Введите число для подчета факториала: ");
//int num00 =int.Parse(Console.ReadLine());
//Console.WriteLine($"Факториал числа {num00}: {Factorial(num00)}");

void PrintMatrix(int[,] mas)
{
    for (int i = 0;i < mas.GetLength(0); i++)
    {
        for (int j = 0;j < mas.GetLength(1); j++)
        {
            Console.Write(mas[i,j]+" ");
        }
        Console.WriteLine();
    }
}

//Random random = new Random();
//int[,] array=new int[random.Next(1,10),random.Next(1,10)];
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        array[i,j] = random.Next(10, 100);
//    }
//}
//PrintMatrix(array);

string[] UniStr(string[] mas)
{
    string[] temp=new string[mas.Length];
    int j = 0;
    for (int i = 0;i< mas.Length; i++)
    {
        if (!temp.Contains(mas[i])) temp[j++] = mas[i];
    }
    int k = 0;
    foreach (string i in mas) if (i.Length != 0) k++;
    string[] res = new string[k];
    Array.Copy(temp, res, k);
    return res;
}

//Console.WriteLine("Введите элементы массива: ");
//string str=Console.ReadLine();
//string[] masStr = str.Split(' ', ',');
//foreach (string i in UniStr(masStr))
//{
//    Console.Write(i+" ");
//}
//Console.WriteLine();

double Area(double a, double b, double c)
{
    double pp=(a+b+c)/2;
    return Math.Sqrt(pp*(pp-a)*(pp-b)*(pp-c));
   
}
Console.Write("Введите первую сторону треугольника: ");
double a=double.Parse(Console.ReadLine());
Console.Write("Введите первую сторону треугольника: ");
double b = double.Parse(Console.ReadLine());

Console.Write("Введите первую сторону треугольника: ");
double c = double.Parse(Console.ReadLine());
Console.WriteLine($"Площадь: {Area(a,b,c):f2}");
