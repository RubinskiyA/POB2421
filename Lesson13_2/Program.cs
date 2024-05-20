////Сумма чисел от 1 до n

//int n;
//do
//{
//    Console.Write("Введите целое положетельное число: ");
//    n = int.Parse(Console.ReadLine());
//}
//while (n <= 0);
//int s = 0;
//for (int i = 1; i <= n; i++) s += i;
//Console.WriteLine(s);

//1.Напишите программу, которая запрашивает у пользователя целое
//число и выводит на экран его факториал. Факториал числа n это
//произведение всех целых чисел от 1 до n. Например, факториал числа 5
//равен 1 * 2 * 3 * 4 * 5 = 120.

//int n;
//do
//{
//    Console.Write("Введите целое положетельное число: ");
//    n = int.Parse(Console.ReadLine());
//}
//while (n <= 0);
//int fakt = 1;
//for (int i = 1; i <= n; i++) fakt *= i;
//Console.WriteLine(fakt);

//2.Напишите программу, которая запрашивает у пользователя два целых
//числа a и b и выводит на экран все числа от a до b включительно,
//которые делятся на 3 или на 5 без остатка.

//int a, b;
//do
//{
//    Console.Write("Введите a (меньшее): ");
//    a = int.Parse(Console.ReadLine());
//    Console.Write("Введите  b (большее): ");
//    b = int.Parse(Console.ReadLine());
//}
//while (a >= b);

//for (int i = a;i<=b;i++)
//{
//    if (i%3==0||i%5==0) Console.WriteLine(i+" ");
//}


//3.Напишите программу, которая запрашивает у пользователя целое
//число n и выводит на экран первые n чисел Фибоначчи.
//Последовательность Фибоначчи начинается с чисел 0 и 1, а каждое
//следующее число равно сумме двух предыдущих чисел.
//Например, первые 10 чисел Фибоначчи это: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34.


int n;
do
{
    Console.Write("Введите целое положетельное число: ");
    n = int.Parse(Console.ReadLine());
}
while (n <= 0);

long pred = 0;
long current = 1;
long temp;
for (int i = 0; i < n; i++)
{
    Console.WriteLine(pred+" ");
    temp = pred;
    pred = current;
    current = temp + current;

}