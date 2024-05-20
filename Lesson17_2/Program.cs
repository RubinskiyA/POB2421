int[][] mas= new int[3][];
Random random= new Random();
double sumAll = 0;
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = new int[random.Next(2, 11)];
}
for (int i = 0; i < mas.Length; i++)
{
    int sum = 0;
    for (int j = 0; j < mas[i].Length; j++)
    {
        mas[i][j] = random.Next(1, 11);
        sum += mas[i][j];
        sumAll += mas[i][j];
        Console.Write(mas[i][j]+" ");
        
    }
    Console.WriteLine($"   Сумма элементов массива: {sum}");
    Console.WriteLine();
}

Console.WriteLine($"Среднее арифметическое всех значений массива: {sumAll/mas.Length:f2}");