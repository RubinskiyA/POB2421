//Random random = new Random();
////генерация цилочисленных типов
//int n = random.Next(100);//0-99
//Console.WriteLine(n);
//int m = random.Next(-10,20);//-10..19
//Console.WriteLine(m);
////генерация вещественных чисел
//double x = random.NextDouble();//0..1
//Console.WriteLine($"{x:f2}") ;
//double y = random.NextDouble()*20;//0..20
//Console.WriteLine($"{y:f2}");


//Console.Write("Введите год своего рождения:");
//int born = int.Parse(Console.ReadLine());
//Console.WriteLine((born % 4 == 0) ? "Год високосный" : "Год не високосный");

//Random random = new Random();
//int n = random.Next(120);
//Console.WriteLine(n);
//if (n >= 10 && n <= 100) Console.WriteLine("Число лежит в диапазоне от 10 до 100");
//else Console.WriteLine("Число вне диапазона от 10 до 100");

//Random random = new Random();
//int rand = random.Next(1, 11);
//Console.Write("Введите число:");
//int num = int.Parse(Console.ReadLine());
//if (num == rand) Console.WriteLine("Вы победили");
//else if (num > rand) Console.WriteLine("Загаданное число меньше");
//else Console.WriteLine("Загаданное число больше");


//using System.Runtime.Intrinsics.X86;

//Console.WriteLine("Введите возраст");
//int age = int.Parse(Console.ReadLine());

//Console.WriteLine("Введите рост в сантиметрах");
//double rost = double.Parse(Console.ReadLine());
//double rostM = rost / 100;
//Console.WriteLine("Введите вес в килограммах");
//double ves = double.Parse(Console.ReadLine());
//double imt = ves / (rostM * rostM);

//if (age < 65)
//{
//    if (imt < 18.5) 
//        Console.WriteLine("Недостаточный вес");
//    else if (imt >= 18.5 && imt <= 24.9) 
//        Console.WriteLine("Нормальный вес");
//    else if (imt >=25 && imt <=29.9) 
//        Console.WriteLine("Избыточный вес");
//    else 
//        Console.WriteLine("Ожирение");
//}
//else if (age>=65&&age<=74)
//{
//    if (imt < 22)
//        Console.WriteLine("Недостаточный вес");
//    else if (imt >= 22 && imt <= 26.9)
//        Console.WriteLine("Нормальный вес");
//    else if (imt >=27 && imt <= 29.9)
//        Console.WriteLine("Избыточный вес");
//    else
//        Console.WriteLine("Ожирение");
//}
//else
//{
//    if (imt <= 23)
//        Console.WriteLine("Недостаточный вес");
//    else if (imt > 23 && imt <= 27.9)
//        Console.WriteLine("Нормальный вес");
//    else if (imt >= 28 && imt <= 29.9)
//        Console.WriteLine("Избыточный вес");
//    else
//        Console.WriteLine("Ожирение");
//}

Random random = new Random();
int color = random.Next(3);
string textColor= "";
if (color == 0) textColor = "Красный";
else if (color == 1) textColor = "Зеленый";
else if (color == 2) textColor = "Синий";
Console.Write("Введите цвет:");
string myColor = Console.ReadLine();
if (myColor == textColor) Console.WriteLine("Победа");
else Console.WriteLine("Проигрыш");
