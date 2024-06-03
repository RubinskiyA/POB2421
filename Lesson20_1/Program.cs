int Add(int a, int b)
{
    return a + b;
}
Console.WriteLine("Введите первое число: ");
int num1=int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма чисел: {Add(num1,num2)}");

