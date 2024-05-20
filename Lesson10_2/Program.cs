Console.Write("Введите длину катета прямоугольного треугольника:");
double kat1 = double.Parse(Console.ReadLine());
Console.Write("Введите длину гипотенузы прямоугольного треугольника:");
double gip = double.Parse(Console.ReadLine());
double kat2 = (Math.Sqrt(Math.Pow(gip, 2) - Math.Pow(kat1, 2)));
Console.WriteLine($"Длина второго катета прямоугольно треугольника равна: {kat2}");
