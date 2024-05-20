//Методы класс Math, задача о длине окружности и ее площади
const double PI = Math.PI;
Console.Write("Введите радиус:");
double radius = double.Parse(Console.ReadLine());
Console.WriteLine($"Длина окружности с радиусом {radius} равна :{PI * radius *2}");
Console.WriteLine($"Площадь круга с радиусом {radius} равна :{PI * Math.Pow(radius, 2)}");