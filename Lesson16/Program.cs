//Random random = new Random();
//int[,] mas1=new int[4,4];
//for(int i=0; i<mas1.GetLength(0); i++)
//{
//    for (int j=0; j<mas1.GetLength(1); j++)
//    {
//        mas1[i, j] = random.Next(-5, 6);
//        Console.Write(mas1[i,j]+" ");
//    }
//    Console.WriteLine();
//}
//int min = mas1[0,0];
//for (int i = 0; i < mas1.GetLength(0); i++)
//{
//    for (int j = 0; j < mas1.GetLength(1); j++)
//    {
//        if (mas1[i, j] < min) min= mas1[i, j];
//    }
//}
//    Console.WriteLine();
//Console.WriteLine("min ="+min);
//Console.WriteLine();
//for (int i = 0; i < mas1.GetLength(0); i++)
//{
//    for (int j = 0; j < mas1.GetLength(1); j++)
//    {
//        if (mas1[i, j] % 2 == 0) mas1[i, j] *= 2;
//        else mas1[i, j] *= 3;
//        Console.Write(mas1[i,j]+" ");
//    }
//    Console.WriteLine();
//}
//Console.WriteLine();
//min = mas1[0, 0];
//for (int i = 0; i < mas1.GetLength(0); i++)
//{
//    for (int j = 0; j < mas1.GetLength(1); j++)
//    {
//        if (mas1[i, j] < min) min = mas1[i, j];
//    }
//}
//Console.WriteLine("min= "+min);

//using System.Net.Http.Headers;


//1.Написать программу для нахождения суммы элементов двумерного
//массива.
//2. Написать программу для нахождения произведения элементов
//двумерного массива.


//Console.Write("Введите количество строк: ");
//int n=int.Parse(Console.ReadLine());
//Console.Write("Введите количество столбов: ");
//int m=int.Parse(Console.ReadLine());
//int[,] mas=new int[n,m];
//Random random = new Random();
//int s=0;
//long p = 1;
//for(int i = 0; i < mas.GetLength(0); i++)
//{
//    for (int j = 0; j < mas.GetLength(1); j++)
//    {
//        mas[i, j] = random.Next(10,100);
//        Console.Write(mas[i,j]+" ");
//        s += mas[i, j];
//        p*= mas[i,j];
//    }
//    Console.WriteLine();
//}
//Console.WriteLine("summa="+s);
//Console.WriteLine("proizv=" + p);

//3.Написать программу, выводящую элементы двумерного массива по
//диагонали.

//Console.Write("Введите количество строк: ");
//int n = int.Parse(Console.ReadLine());
//Console.Write("Введите количество столбов: ");
//int m = int.Parse(Console.ReadLine());
//int[,] mas = new int[n, m];
//Random random = new Random();
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    for (int j = 0; j < mas.GetLength(1); j++)
//    {
//        mas[i, j] = random.Next(10, 100);
//        Console.Write(mas[i, j] + " ");
//    }
//    Console.WriteLine();
//}
//int s = 0;
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    for (int j = 0; j < mas.GetLength(1); j++)
//    {

//        for (int k = 0; k < s; k++) Console.Write(" ");
//        Console.WriteLine(mas[i, j]);
//        s++;
//    }
//}

//4.Написать программу — телефонный справочник — создать
//двумерный массив 5*3, хранящий
//список телефонных контактов: первый элемент хранит имя контакта,
//второй — номер, третий e-mail
//2.1 Вывести все элементы массива на экран.
//2.2 Вывести три элемента: имя, номер и e-mail по запросу пользователя
//по имени.

//string[,] mas =
//{
//    {"first","1234","first@gmail.com" },
//    {"second","3254","second@gmail.com" },
//    {"third","7598","third@gmail.com" },
//    {"fourth","6546","fourth@gmail.com" },
//    {"fifth","5587","fifth@gmail.com" }
//};
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    for (int j = 0; j < mas.GetLength(1); j++)
//    {
//        Console.Write(mas[i,j]+" ");
//    }
//    Console.WriteLine();
//}

//Console.WriteLine("Введите имя: ");
//string name = Console.ReadLine();
//for  (int i = 0;i < mas.GetLength(0); i++)
//{
//    if (mas[i,0]==name) Console.WriteLine(mas[i,0]+" " + mas[i,1]+" " + mas[i,2]);
//}


//int[,] mas = new int[7,7];
//for (int i = 0; i < mas.GetLength(0); i++)
//    for (int j = 0; j < mas.GetLength(1); j++)
//        if (i == j || i + j == mas.GetLength(0)-1||j==mas.GetLength(1)/2||i==mas.GetLength(0)/2) mas[i, j] = 1;
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    for (int j = 0; j < mas.GetLength(1); j++)
//    {
//        Console.Write(mas[i, j] + " ");
//    }
//    Console.WriteLine();
//}

//int[,] mas = new int[7, 7];
//for (int i = 0; i < mas.GetLength(0); i++)
//    for (int j = 0; j < mas.GetLength(1); j++)
//        if ((i <= j && i+j<=mas.GetLength(0)-1)||(i>=j&&i+j>=mas.GetLength(0)-1)) mas[i, j] = 1;
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    for (int j = 0; j < mas.GetLength(1); j++)
//    {
//        Console.Write(mas[i, j] + " ");
//    }
//    Console.WriteLine();
//}

//1.Написать программу для нахождения среднего значения элементов
//двумерного массива.

//Random random = new Random();
//double[,] mas = new double[random.Next(3,10),random.Next(3,10)];
//double s=0;
//for(int i = 0; i < mas.GetLength(0); i++)
//{
//    for (int j = 0; j < mas.GetLength(1); j++)
//    {
//        mas[i,j] = random.NextDouble()*50;
//        Console.Write($"{mas[i,j]:f2} ");
//        s += mas[i, j];
//    }
//    Console.WriteLine();
//}
//Console.WriteLine($"Avg={s/(mas.GetLength(0)*mas.GetLength(1)):f2}");


//2.Написать программу для нахождения среднего значения каждой
//строки двумерного массива.

//Random random = new Random();
//double[,] mas = new double[random.Next(3, 10), random.Next(3, 10)];
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    double s = 0;
//    for (int j = 0; j < mas.GetLength(1); j++)
//    {
//        mas[i, j] = random.NextDouble() * 50;
//        Console.Write($"{mas[i, j]:f2} ");
//        s += mas[i, j];
//    }
//        Console.WriteLine($"Avg={s / mas.GetLength(1):f2}");
//}


//3.Написать программу для транспонирования двумерного массива
//(перевода строк в столбцы и наоборот).
//Подсказка: вам понадобится 2 массива.

Random random = new Random();
int[,] mas = new int[random.Next(3, 10), random.Next(3, 10)];
for (int i = 0; i < mas.GetLength(0); i++)
{
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        mas[i, j] = random.Next(10,100);
        Console.Write(mas[i, j]+" ");
    }
    Console.WriteLine();
}
Console.WriteLine();

int[,] masTrans = new int[mas.GetLength(1), mas.GetLength(0)];
for (int i = 0; i < masTrans.GetLength(0); i++)
{
    for (int j = 0; j < masTrans.GetLength(1); j++)
    {
        masTrans[i, j] = mas[j,i];
        Console.Write(masTrans[i, j]+" ");
    }
    Console.WriteLine();
}

