Random random = new Random();
int[][] mas = new int[random.Next(5, 11)][];
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = new int[random.Next(5, 16)];
}
for (int i = 0; i < mas.Length; i++)
{
    for (int j = 0; j < mas[i].Length; j++)
    {
        mas[i][j] = random.Next(1, 11);
        Console.Write(mas[i][j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("Введите число 200: ");
int num200=int.Parse(Console.ReadLine());

int n = random.Next(0, mas.GetLength(0));
int m = random.Next(0, (mas[n].Length));
mas[n][m] = num200;
for (int i = 0; i < mas.Length; i++)
{
    for (int j = 0; j < mas[i].Length; j++)
    {

        Console.Write(mas[i][j] + " ");
    }
    Console.WriteLine();
}