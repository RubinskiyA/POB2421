//Console.Write("Введите число:");
//double num = double.Parse(Console.ReadLine());
//if (num >= 0)
//    Console.WriteLine($"Модуль числа равен: {num}");
//else Console.WriteLine($"Модуль числа равен: {-num}");

//_____________________________________________________

//Console.Write("Введите первое число:");
//double a = double.Parse(Console.ReadLine());
//Console.Write("Введите второе число:");
//double b = double.Parse(Console.ReadLine());
//if (a > b) Console.WriteLine($"{a}>{b}");
//else
//    if (b > a) Console.WriteLine($"{b}>{a}");
//else Console.WriteLine($"{a}={b}");

//_____________________________________________________

//36b
//bool x = false;
//bool y = false;
//bool z = true;
//Console.WriteLine(!x && !y); // true


//_____________________________________________________

//Console.Write("Введите первое число:");
//double x = double.Parse(Console.ReadLine());
//Console.Write("Введите второе число:");
//double y = double.Parse(Console.ReadLine());
//Console.WriteLine(x*x +y*y<=4);
//_____________________________________________________
//буква в
//Console.Write("Введите первое число:");
//double x = double.Parse(Console.ReadLine());
//Console.Write("Введите второе число:");
//double y = double.Parse(Console.ReadLine());
//Console.WriteLine((x>=0)&&(y*y!=4)); //false

//_____________________________________________________
//буква d
//Console.Write("Введите первое число:");
//double A = double.Parse(Console.ReadLine());
//Console.Write("Введите второе число:");
//double B = double.Parse(Console.ReadLine());
//Console.Write("Введите третье число:");
//double C = double.Parse(Console.ReadLine());
//Console.WriteLine((A<50)^(B < 50)^(C < 50)); 

//_____________________________________________________

//Console.Write("Введите координату x:");
//double x = double.Parse(Console.ReadLine());
//Console.Write("Введите координату y:");
//double y = double.Parse(Console.ReadLine());

//if ((y >= 0.5 && y <= 1.5 && x <= 2) || (x >= 2)) Console.WriteLine("Попал");
//else Console.WriteLine("Не попал");

//_____________________________________________________
//буква b

//Console.Write("Введите координату x:");
//double x = double.Parse(Console.ReadLine());
//Console.Write("Введите координату y:");
//double y = double.Parse(Console.ReadLine());

//if (y>=1||y<=-3) Console.WriteLine("Попал");
//else Console.WriteLine("Не попал");


//_____________________________________________________

//Console.Write("Введите А:");
//double a = double.Parse(Console.ReadLine());
//Console.Write("Введите B:");
//double b = double.Parse(Console.ReadLine());
//Console.Write("Введите C:");
//double c = double.Parse(Console.ReadLine());
//double d = b * b - 4 * a * c;
//if (d > 0)
//{
//    double x1 = (-b +Math.Sqrt(d)) / (2*a);
//    double x2 = (-b - Math.Sqrt(d)) / (2 * a);
//    Console.WriteLine($"x1={x1:f2} x2={x2:f2}");
//}
//else if (d == 0)
//{
//    double x = (-b / (2 * a));
//    Console.WriteLine($"x={x:f2}" );

//}
//else Console.WriteLine("Корней нет");


//Console.Write("Введите А:");
//double a = double.Parse(Console.ReadLine());
//Console.Write("Введите B:");
//double b = double.Parse(Console.ReadLine());
//Console.Write("Введите C:");
//double c = double.Parse(Console.ReadLine());
//if (a > b)
//{
//    if (b > c) Console.WriteLine($"{a},{b},{c}");
//        else if (c > a) Console.WriteLine($"{a},{c},{b}");
//            else Console.WriteLine($"{c},{a},{b}");
//}
//else if (a > c) Console.WriteLine($"{b},{a},{c}");
//    else if (b > c) Console.WriteLine($"{b},{c},{a}");
//        else Console.WriteLine($"{c},{b},{a}");

//Console.Write("Введите число:");
//double x = double.Parse(Console.ReadLine());
//if (x>=0) Console.WriteLine(x);
//else Console.WriteLine(-x);
//Console.WriteLine((x>=0)?x:-x);

//______________________________________

//Проверка числа на четность с помощью тернарного оператора
//Console.Write("Введите число:");
//int x = int.Parse(Console.ReadLine());
//Console.WriteLine((x % 2 == 0) ? "Число четное." : "Число нечетное.");

//________________________________________

//Проверка совершеннолетия
//Console.Write("Введите возраст:");
//int age = int.Parse(Console.ReadLine());
//Console.WriteLine((age>= 18) ? "Пользователь совершеннолетний" : "Пользователь несовершеннолетний");

//______________________________________________
//Число отрицательно или положительное или равно 0
//Проверка числа на четность с помощью тернарного оператора
//Console.Write("Введите число:");
//double num = double.Parse(Console.ReadLine());
//Console.WriteLine((num > 0) ? "Число положительное" : (num < 0) ? "Число отрицательное":"Число равно нулю") ;

//_____________________________
//Ввод двух чисел и сравнение


//Console.Write("Введите первое число:");
//double num1 = double.Parse(Console.ReadLine());
//Console.Write("Введите второе число:");
//double num2 = double.Parse(Console.ReadLine());
//Console.WriteLine((num1>num2)?num1:(num1==num2)?"Числа равны":num2);

//__________________________
//Ввести три числа и вывести наименьшее
//Console.Write("Введите первое число:");
//double num1 = double.Parse(Console.ReadLine());
//Console.Write("Введите второе число:");
//double num2 = double.Parse(Console.ReadLine());
//Console.Write("Введите третье число:");
//double num3 = double.Parse(Console.ReadLine());
//Console.WriteLine((num1 <num2)&&(num2<num3)?num1:(num3<num2)&&(num2<num1)?num3:num2);

//________________________
//Задача на рост и вес
//Console.Write("Введите рост:");
//double rost = double.Parse(Console.ReadLine());
//Console.Write("Введите вес:");
//double ves = double.Parse(Console.ReadLine());
//if (rost - 100 > ves) Console.WriteLine("У вас недобор веса");
//else if (rost - 100 < ves) Console.WriteLine("У вас лишний вес");
//else Console.WriteLine("У вас отличный вес");

//_____________________________
//Console.Write("Введите номер месяца:");
//int mouth = int.Parse(Console.ReadLine());
//if (mouth == 12 || mouth == 1 || mouth == 2) 
//    Console.WriteLine("Зима");
//else if (mouth == 3 || mouth == 4 || mouth == 5) 
//    Console.WriteLine("Весна");
//else if (mouth == 6 || mouth == 7 || mouth == 8) 
//    Console.WriteLine("Лето");
//else if (mouth == 9 || mouth == 10 || mouth == 11) 
//    Console.WriteLine("Осень");
//else Console.WriteLine("Нет такого месяца");

//_______________________________________

//Console.Write("Введите площадь круга:");
//double krug = double.Parse(Console.ReadLine());
//Console.Write("Введите площадь квадрата:");
//double kvad = double.Parse(Console.ReadLine());
//double r = (Math.Sqrt(krug / Math.PI));
//double a = (Math.Sqrt(kvad));
//if (2 * r <= a) Console.WriteLine("Круг уместится в квадрат");
//else Console.WriteLine("Круг не уместится в квадрат");
//if (2 * a * a <= 4 * r * r) Console.WriteLine("Квадрат уместится в круге");
//else Console.WriteLine("Квадрат не уместится в круге");

//___________________________________________

