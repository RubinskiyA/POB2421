using Lesson27_4;

Numbers numbers = new Numbers();

//Вычисление факториала
Console.WriteLine("Введите число: ");
int n;
int.TryParse(Console.ReadLine(), out n);


Console.WriteLine(numbers.CalculateFactorial(n));
Console.WriteLine(numbers.ConvertToBinary(n));
Console.WriteLine(numbers.ConvertToHex(n));
Console.WriteLine("Введите основание и степень: ");
double x, y;
double.TryParse(Console.ReadLine(), out x);
double .TryParse(Console.ReadLine(), out y);
Console.WriteLine(numbers.CalculatePower(x,y));

