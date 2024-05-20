//int s = 0;
//Console.WriteLine("Введите первое число");
//int a1 = int.Parse(Console.ReadLine());
//s += a1;
//Console.WriteLine("Введите второе число");
//int a2 = int.Parse(Console.ReadLine());
//s += a2;
//Console.WriteLine("Введите третье число");
//int a3 = int.Parse(Console.ReadLine());
//s += a3;
//Console.WriteLine("Введите четвертое число");
//int a4 = int.Parse(Console.ReadLine());
//s += a4;
//Console.WriteLine("Введите пятое число");
//int a5 = int.Parse(Console.ReadLine());
//s += a5;
//Console.WriteLine(s);

//int sum = 0;
//int i = 1;//счетчик чисел
//while (i<=5)
//{
//    Console.WriteLine($"Введите {i} число");
//    int a = int.Parse(Console.ReadLine());
//    sum += a;
//    i++;
//}
//Console.WriteLine(sum);

//Random random = new Random();
//int i = 1;
//int count = 0;
//while (i <= 10)
//{
//    int n = random.Next(100);
//    int m = random.Next(100);
//    int t = random.Next(1,6);
//    switch (t)
//    {
//        case 1: 
//    };

//}

//___________________________________
//int sum = 0;
//int i = 1;//счетчик чисел
//do 
//{
//    Console.WriteLine($"Введите {i} число");
//    int a = int.Parse(Console.ReadLine());
//    sum += a;
//    i++;
//}
//while (i<=5);
//Console.WriteLine(sum);
//_______________________________________
//Ввести число больше 0
//int n;
//do
//{
//    Console.Write("Введите целое положетельное число");
//    n = int.Parse(Console.ReadLine());
//}
//while (n <= 0);


//1. Напишите программу, которая запрашивает у пользователя целое
//число и выводит на экран все числа от 1 до этого числа включительно.
//int n;
//do
//{
//    Console.Write("Введите целое положетельное число: ");
//    n = int.Parse(Console.ReadLine());
//}
//while (n <= 0);
//int i = 1;
//while (i <= n)
//{
//    Console.Write(i++ + " ");
//}


//2.Напишите программу, которая запрашивает у пользователя два целых
//числа и выводит на экран все числа между этими двумя числами
//(включая их), увеличивая каждое число на 1.

//int n, m;

//do
//{
//    Console.Write("Введите первое число: ");
//    n = int.Parse(Console.ReadLine());
//    Console.Write("Введите второе число: ");
//    m = int.Parse(Console.ReadLine());
//    if (m <= n) Console.WriteLine("Первое число должно быть меньше второго");
//}
//while (m<=n);

//int i = n;
//while (i <=m)
//{
//    Console.Write(i++ + " ");
//}

//3.Напишите программу, которая запрашивает у пользователя целое
//число и выводит на экран все нечетные числа от 1 до этого числа
//включительно.

//int n;
//do
//{
//    Console.Write("Введите целое положетельное число: ");
//    n = int.Parse(Console.ReadLine());
//}
//while (n <= 0);
//int i = 1;
//while (i <= n)
//{
//    Console.WriteLine(i + "");
//    i += 2;
//}

//4.Напишите программу, которая запрашивает у пользователя целое
//число и выводит на экран таблицу умножения для этого числа от 1 до
//10.

//int n;
//do
//{
//    Console.Write("Введите отличное от 0: ");
//    n = int.Parse(Console.ReadLine());
//}
//while (n == 0);
//int i = 1;
//while (i <= 10)
//{
//    Console.WriteLine($"{i}*{n}={i++*n}");
//}


//5.Напишите программу, которая запрашивает у пользователя целое
//число и выводит на экран сумму всех чисел от 1 до этого числа
//включительно.


//int n;
//do
//{
//    Console.Write("Введите целое положетельное число: ");
//    n = int.Parse(Console.ReadLine());
//}
//while (n <= 0);
//int i = 1;
//int sum = 0;
//while (i <= n)
//{
//    sum += i++;
//}
//Console.WriteLine(sum);

//6.Напишите программу, которая запрашивает у пользователя целое
//число и выводит на экран все его делители.

//int n;
//do
//{
//    Console.Write("Введите целое положетельное число: ");
//    n = int.Parse(Console.ReadLine());
//}
//while (n <= 0);
//int i = 1;
//while (i <= n)
//{
//    if (n%i == 0) Console.WriteLine(i);
//    i++;
//}


//7.Напишите программу, которая запрашивает у пользователя целое
//число и проверяет, является ли это число простым.

//int n;
//do
//{
//    Console.Write("Введите целое положительное число: ");
//    n = int.Parse(Console.ReadLine());
//}
//while (n <= 0);
//int i = 2;
//int k = 0;//Количество делителей
//while (i < n)
//{
//    if (n % i++ == 0)
//    { 
//        k++;break; 
//    }
//}
//if (k == 0) Console.WriteLine("Число простое");
//else Console.WriteLine("Число не простое");

//8.Напишите программу, которая запрашивает у пользователя целое
//число и выводит на экран все простые числа от 1 до этого числа
//включительно.

//int n;
//do
//{
//    Console.Write("Введите целое положительное число: ");
//    n = int.Parse(Console.ReadLine());
//}
//while (n <= 0);
//int i = 1;
//while (i <= n)
//{
//    int j = 2;
//    int k = 0;
//    while (j < i)
//    {
//        if (i % j == 0)
//        {
//            k++;
//            break;
//        }
//        j++;
//    }
//    if (k==0) Console.WriteLine(i + " число простое");
//    i++;

//}

//9.Напишите программу, которая запрашивает у пользователя целое
//число и выводит на экран его двоичное представление.

int n;
do
{
    Console.Write("Введите целое положетельное число: ");
    n = int.Parse(Console.ReadLine());
}
while (n <= 0);

string result = "";
while (n != 1)
{
    result += n % 2;
    n /= 2; 
}
result += 1;
int i = result.Length - 1;
while (i >= 0)
{
    Console.Write(result[i--]);

}