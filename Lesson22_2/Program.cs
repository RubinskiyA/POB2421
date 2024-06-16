do
{
    try
    {
        Console.Write("Введите числа разделенные пробелом: ");
        string numbers = Console.ReadLine();
        string[] num = numbers.Split(" ");
        int sumNum = 0;
        foreach (string number in num)
        {
            sumNum += int.Parse(number);
        }
        Console.WriteLine("Сумма введенных чисел: " + sumNum);
    }
    catch (FormatException e)
    {
        Console.WriteLine(e.Message);
    }
} while (true);