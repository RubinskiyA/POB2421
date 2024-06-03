Random random = new Random();
int[,] mas1 = new int[4, 4];
int[,] mas2 = new int[4, 4];
for (int i = 0; i < mas1.GetLength(0); i++)
{
    for (int j = 0; j < mas1.GetLength(1); j++)
    {
        mas1[i, j] = random.Next(-50, 51);
    }
}
for (int i = 0; i < mas2.GetLength(0); i++)
{
    for (int j = 0; j < mas2.GetLength(1); j++)
    {
        mas2[i, j] = random.Next(-50, 51);
    }
}

void Print(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0;j<a.GetLength(1); j++)
        {
            Console.Write(a[i,j]+" ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] SumMas(int[,] a, int[,] b)
{
 int[,] result = new int[a.GetLength(0),a.GetLength(1)];
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            result[i,j] = a[i,j] + b[i,j];
        }
    }
    return result;
}


int MaxValueMas(int[,] a)
{
    int maxNum=int.MinValue;
    for (int i = 0;i < a.GetLength(0); i++)
    {
        for (int j = 0;j<a.GetLength(1); j++)
        {
            if (a[i,j] >= maxNum)  maxNum = a[i,j];
        }
    }
    return maxNum;
}

Print(mas1);
Print(mas2);
Print(SumMas(mas1,mas2));
Console.Write("Максимальное значение массива: " + MaxValueMas(SumMas(mas1, mas2)));