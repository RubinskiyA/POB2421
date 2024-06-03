double AvgMas(int[] a)
{
    double s = 0;
    for (int i = 0; i < a.Length; i++)
    {
        s += a[i];
    }
    return s / a.Length;
}

int[] mas = {1,3,5,7,9,11,13,15 };
for (int i = 0; i < mas.Length; i++)
{
    Console.Write(mas[i] + " ");
}
Console.WriteLine();
Console.WriteLine(AvgMas(mas));