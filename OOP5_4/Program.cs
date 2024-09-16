//var turple = (5, 10);
//Console.WriteLine(turple.Item1);
//Console.WriteLine(turple.Item2);
//turple.Item1 += 10;
//Console.WriteLine(turple.Item1);

//(int, double) tupleNew = (5, 8.9);
//Console.WriteLine(tupleNew.Item1);
//Console.WriteLine(tupleNew.Item2);

//(string, int, double) person = ("tom", 30, 68.3);
//Console.WriteLine(person);


int[] mas = new int[10];
Random random = new Random();
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = random.Next(10, 100);
    Console.Write(mas[i] + " ");
}
//Console.WriteLine();
//for (int i = 0; i < mas.Length-1; i++)
//{
//    for (int j = i+1; j < mas.Length; j++)
//    {
//        if (mas[i] > mas[j]) (mas[i], mas[j]) = (mas[j], mas[i]);
//    }
//}
//for (int i = 0; i < mas.Length; i++)
//{

//    Console.Write(mas[i] + " ");
//}
//Console.WriteLine();

//(int,int,double) GetValues(int[] mas)
//{
//    int max = mas.Max();
//    int min = mas.Min();
//    double avg=mas.Average();
//    return (max,min,avg);
//}

//Console.WriteLine(GetValues(mas));

//void Print((string name,int age) person)
//{
//    Console.Write(person.name + " " + person.age);
//}

//Print(("vasya", 15));

(int[], int[]) SortMas(int[] mas)
{
    int[] masVozr=new int[mas.Length], masUbiv=new int[mas.Length];
    for (int i = 0; i < mas.Length - 1; i++)
    {
        for (int j = i + 1; j < mas.Length; j++)
        {
            if (mas[i] > mas[j]) (mas[i], mas[j]) = (mas[j], mas[i]);
        }
    }
    masVozr = mas;

    for (int i = 0; i < mas.Length - 1; i++)
    {
        for (int j = i + 1; j < mas.Length; j++)
        {
            if (mas[i] < mas[j]) (mas[i], mas[j]) = (mas[j], mas[i]);
        }
    }
    masUbiv = mas;
    return (masVozr, masUbiv);

}
Console.WriteLine();

for (int i = 0; i < SortMas(mas).Item1.Length; i++)
{
    Console.Write(SortMas(mas).Item1[i] + " ");
}
Console.WriteLine();

for (int i = 0; i < SortMas(mas).Item2.Length; i++)
{
    Console.Write(SortMas(mas).Item2[i] + " ");
}
Console.WriteLine();