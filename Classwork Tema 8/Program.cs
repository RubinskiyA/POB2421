//int x = 6;
//Console.WriteLine(x++); //инкремент(постфиксна)
//Console.WriteLine(x);
//Console.WriteLine(++x);//инкремент(префиксная)
//Console.WriteLine(x--); //декремент(постфиксная)
//Console.WriteLine(x);
//Console.WriteLine(--x); //декремент(префиксная)



//x=x+y заменяется на x+=y, как и все остальные действия

//int x = 0;
//Console.WriteLine(x);
//x += 46;
//Console.WriteLine(x);
//x += 12;
//Console.WriteLine(x);
//x += 4;
//Console.WriteLine(x);
//x += 8;
//Console.WriteLine(x);
//x += 15;
//Console.WriteLine(x);


//decimal sum=56000;
//decimal part1 = sum / 8;
//Console.WriteLine($"{part1*5:C}:{part1*2:C}:{part1:C}");


//double s = 240;
//double V1 = 3;
//double V2 = 2;
//Console.WriteLine($"Мама будет ждать кенгуренка {(s/V2)-(s/V1)} секунд");




//using System.Numerics;
////Программа заменяет вторую цифру в любом числе на 0
//Console.Write("Введите число:");
//int y=int.Parse(Console.ReadLine());
//Console.WriteLine(y - (y / 10 % 10) * 10);



//Console.Write("Введите четырехзначное число:");
//int y = int.Parse(Console.ReadLine());
//int a = y % 10;
//int b = y % 100 / 10;
//int c = y % 1000 / 100;
//int d =y/1000;
//int s = a + b + c + d;
//int p = a * b * c * d;
//Console.WriteLine(s);
//Console.WriteLine(p);



//Console.Write("Введите количество монет:");
//int money =int.Parse(Console.ReadLine());
//int bread = 30;
//int milk = 50;
//int butter = 40;
//int gloves = 300;
//int hat = 99;

//Console.WriteLine($"Хлеб - {bread}");
//Console.WriteLine($"Молоко - {milk}");
//Console.WriteLine($"Масло - {butter}");
//Console.WriteLine($"Перчатки - {gloves}");


//Console.Write("Введите количество хлеба:");
//int breadCount = int.Parse(Console.ReadLine());
//Console.Write("Введите количество масла:");
//int butterCount = int.Parse(Console.ReadLine());
//Console.Write("Введите количество молока:");
//int milkCount = int.Parse(Console.ReadLine());
//int breadPrice = bread * breadCount;
//int milkPrice = milk * milkCount;
//int butterPrice = butter * butterCount;

//int sum = milk*milkCount+butter*butterCount+bread*breadCount;
//Console.WriteLine($"Хлеб - {breadCount}шт. - {breadPrice} рублей\n" + 
//    $"Молоко - {milkCount}шт. - {milkPrice} рублей\n" + 
//    $"Масло - {butterCount}шт. - {butterPrice} рублей\n" +
//    $"С вас {sum} монет. У вас осталось {money-sum}");



using System.Net.Security;

Console.Write("Введите день года:");
int k = int.Parse(Console.ReadLine());
Console.Write("Введите день недели приходящийся на 1 января(где 1 - понедельник,2 - вторник и тд.:");
byte d = byte.Parse(Console.ReadLine());
//Console.WriteLine(k%7+d-1);
int n = k % 7 + d - 1;
if (n == 0)
    Console.WriteLine($"{n} - воскресенье");
if (n == 1)
    Console.WriteLine($"{n} - понедельник");
if (n == 3)
    Console.WriteLine($"{n} - среда");


