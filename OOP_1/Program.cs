using OOP_1;

//Para para = new Para() { First = 6.9, Second = 7.3 };
//Console.WriteLine("Сумма " + para.Sum());
//Console.WriteLine("Максимум " + para.Max());

//para.First = 8.3;
//Console.WriteLine("Сумма " + para.Sum());
//Console.WriteLine("Максимум " + para.Max());




//Console.Write("Введите нижний диапазон: ");
//int low;
//int.TryParse(Console.ReadLine()!, out low);

//Console.Write("Введите верхний диапазон: ");
//int high;
//int.TryParse(Console.ReadLine()!, out high);

//Console.Write("Введите значение счетчика: ");
//int count;
//int.TryParse(Console.ReadLine()!, out count);

//Counter counter = new Counter() { Low = low, High = high, Count = count };
//counter.Valid();
//counter.Inc();
//Console.WriteLine(counter.Count);
//counter.Decrem();
//Console.WriteLine(counter.Count);

//Time time = new Time() { Hour = 20, Minute = 15, Second = 30 };
////time.AddHour(10);
////time.PrintTime();
////time.AddMinute(50);
////time.PrintTime();
////time.AddSeconds(600);
//time.SubHours(28);
//time.PrintTime();

double a = 3;
double b = 4;
double c = 5;
Triangles triangles = new Triangles(a, b, c);
Console.WriteLine("Периметр " + triangles.Perimetr() + ", площадь " + triangles.Area());
triangles.A = 100;
triangles.Valide(triangles.A, triangles.B, triangles.C);
Console.WriteLine("Периметр " + triangles.Perimetr() + ", площадь " + triangles.Area());

