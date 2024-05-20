//1 Задача

//Console.Write("Введите первое число:");
//int a = int.Parse(Console.ReadLine());

//Console.Write("Введите второе число:");
//int b = int.Parse(Console.ReadLine());
//Console.WriteLine(Math.Max(a,b) );

//2 Задача
//--------------------------------------

//Console.Write("Введите число:");
//double n = double.Parse(Console.ReadLine());
//Console.WriteLine(Math.Abs(n));

//3 задача
//--------------------------------------

//Console.Write("Введите число:");
//double m = double.Parse(Console.ReadLine());
//Console.WriteLine(Math.Floor(m));
//--------------------------------------

//Console.Write("Введите число:");
//double x = double.Parse(Console.ReadLine());
//Console.WriteLine(Math.Floor(Math.Sqrt(x)));
//--------------------------------------


//Console.Write("Введите число:");
//double q = double.Parse(Console.ReadLine());

//Console.Write("Введите степень:");
//double w = double.Parse(Console.ReadLine());
//Console.WriteLine(Math.Pow(q, w));
//--------------------------------------

//Console.Write("Введите число:");
//double e = double.Parse(Console.ReadLine());
//Console.WriteLine(Math.Round(e));
//--------------------------------------

//Console.Write("Введите число:");
//double r = double.Parse(Console.ReadLine());
//Console.WriteLine(Math.Ceiling(r));

//--------------------------------------
//Console.Write("Введите первое число:");
//int t = int.Parse(Console.ReadLine());

//Console.Write("Введите степень:");
//int u = int.Parse(Console.ReadLine());
//Console.WriteLine(Math.DivRem(t, u));

//--------------------------------------
//const double PI = Math.PI;
//Console.Write("Введите радиус:");
//double radius = double.Parse(Console.ReadLine());
//Console.WriteLine(PI * Math.Pow(radius,2));
//--------------------------------------
//const double g = 9.81;
//Console.Write("Введи высоту:");
//double h = double.Parse(Console.ReadLine());
//Console.WriteLine($"{2 * h / g:F2} секунд");

//--------------------------------------

//Console.Write("Введите первый катет:");
//double i = double.Parse(Console.ReadLine());

//Console.Write("Введите второй катет:");
//double p = double.Parse(Console.ReadLine());
//Console.WriteLine(Math.Sqrt(Math.Pow(i,2)+Math.Pow(p,2)));


//--------------------------------------

const double GH = Math.PI / 180;
Console.Write("Введи угол:");
double vv = double.Parse(Console.ReadLine());
Console.WriteLine($"Синус угла {vv} равен {Math.Sin(vv * GH):F2}");
Console.WriteLine($"Косинус угла {vv} равен {Math.Cos(vv * GH):F2}");
Console.WriteLine($"Тангенс угла {vv} равен {Math.Tan(vv * GH):F2}");
