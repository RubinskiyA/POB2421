using Lesson27_3;
using System.Globalization;

Numbers numbers = new Numbers();
//Среднее значение массива:
//int[] mas = { 1, 2, 3, 4, 5};
//Console.WriteLine(numbers.CalculateAverage(mas));
////---------------------------------
//Проверка числа на простое/нет
//Console.WriteLine("Введите число: ");
//int num1;
//int.TryParse(Console.ReadLine(), out num1);
//Console.WriteLine(numbers.IsPrime(num1));
//---------------------------------
//Проверка числа на четность
//Console.WriteLine("Введите число: ");
//int num2;
//int.TryParse(Console.ReadLine(), out num2);
//Console.WriteLine(numbers.IsEven(num2));
//------------------------------------
//Проверка числа на нечетность
Console.WriteLine("Введите число: ");
int num2;
int.TryParse(Console.ReadLine(), out num2);
Console.WriteLine(numbers.IsOdd(num2));
