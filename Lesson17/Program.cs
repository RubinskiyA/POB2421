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
        mas[i][j] = random.Next(10, 100);
        Console.Write(mas[i][j] + " ");
    }
    Console.WriteLine();
}
//Console.WriteLine();
//int[,,] tripleMas = new int[5, 7, 2];
//for (int k = 0; k < tripleMas.GetLength(2); k++)
//{
//    for (int i = 0; i < tripleMas.GetLength(0); i++)
//    {
//        for (int j = 0; j < tripleMas.GetLength(1); j++)
//        {

//                tripleMas[i, j, k] = random.Next(10, 100);
//                Console.Write(tripleMas[i, j, k] + " ");

//        }
//        Console.WriteLine();

//    }
//    Console.WriteLine();

//}

//Создайте массив массивов, представляющий собой шахматную доску,
//где белые клетки представлены символом "W", а черные - символом "B".
//Затем напишите программу, которая будет выводить данную доску на
//экран, чтобы она выглядела как настоящая шахматная доска.


//char[,] shahMateDesk = new char[8, 8];
//for  (int i = 0; i < shahMateDesk.GetLength(0); i++)
//{
//    for (int j = 0; j< shahMateDesk.GetLength(1); j++)
//    {
//        if ((i + j) % 2 == 0) shahMateDesk[i, j] = 'B';
//        else shahMateDesk[i, j] = 'W';
//        Console.Write(shahMateDesk[i,j]+" ");
//    }
//    Console.WriteLine();
//}

//2.Покер

//string[] mast = { "Червы", "Буби", "Крести", "Пики" };
//string[] nominal = { "Туз", "Двойка", "Тройка", "Четверка", "Пятерка", "Шестерка", "Семерка", "Восьмерка", "Девятка", "Десятка", "Валет", "Дама", "Король" };
//int[,,] karts = new int[2, 2, 4];
//Random random = new Random();
//for (int k = 0;k < karts.GetLength(2); k++)
//{
//    for (int i=0;i<karts.GetLength(0); i++)
//    {
//        for (int j=0;j<karts.GetLength(1);j++)
//        {
//            if (j == 0)
//            {
//                karts[i, j, k] = random.Next(0, 4);
//                Console.Write( mast[karts[i, j, k]] + " ");
//            }
//            else
//            {
//                karts[i, j, k] = random.Next(0, 13);
//                Console.Write(nominal[karts[i, j, k]] + " ");
//            }
//        }
//        Console.WriteLine();
//    }
//    Console.WriteLine();
//}

//Random random = new Random();
//int[,,] mas = new int[4, 6, 8];
//for (int k = 0; k < mas.GetLength(2); k++)
//{
//    for (int i = 0; i < mas.GetLength(0); i++)
//    {
//        for (int j = 0; j < mas.GetLength(1); j++)
//        {
//            mas[i, j, k] = random.Next(10, 101);
//            Console.Write(mas[i,j,k]+" ");
//        }
//        Console.WriteLine();
//    }
//    Console.WriteLine();
//}
//Console.WriteLine();
//Console.Write("Введите число для вставки последнего элемента: ");
//int last=int.Parse(Console.ReadLine());
//mas[mas.GetUpperBound(0),mas.GetUpperBound(1),mas.GetUpperBound(2)] = last;
//Console.Write("Введите число для вставки первого элемента: ");
//int first = int.Parse(Console.ReadLine());
//mas[mas.GetLowerBound(0), mas.GetLowerBound(1), mas.GetLowerBound(2)] = first;
//Console.Write("Введите три числа через запятую(номер элемента): ");
//string strNumbers= Console.ReadLine();
//string[] numbers = strNumbers.Split(",");
//Console.Write("Введите число для вставки: ");
//int num = int.Parse(Console.ReadLine());
//mas[int.Parse(numbers[0]), int.Parse(numbers[1]), int.Parse(numbers[2])]=num;

//for (int k = 0; k < mas.GetLength(2); k++)
//{
//    for (int i = 0; i < mas.GetLength(0); i++)
//    {
//        for (int j = 0; j < mas.GetLength(1); j++)
//        {
//            Console.Write(mas[i, j, k] + " ");
//        }
//        Console.WriteLine();
//    }
//    Console.WriteLine();
//}
//Console.WriteLine();
//mas[mas.GetUpperBound(0), mas.GetUpperBound(1), mas.GetUpperBound(2)] = 0;
//mas[mas.GetLowerBound(0), mas.GetLowerBound(1), mas.GetLowerBound(2)] = 0;
//Console.Write("Введите три числа через запятую(номер элемента): ");
//strNumbers = Console.ReadLine();
//numbers = strNumbers.Split(",");
//mas[int.Parse(numbers[0]), int.Parse(numbers[1]), int.Parse(numbers[2])] = 0;
//for (int k = 0; k < mas.GetLength(2); k++)
//{
//    for (int i = 0; i < mas.GetLength(0); i++)
//    {
//        for (int j = 0; j < mas.GetLength(1); j++)
//        {

//            Console.Write(mas[i, j, k] + " ");
//        }
//        Console.WriteLine();
//    }
//    Console.WriteLine();
//}
//Console.WriteLine();

//Random random = new Random();
//int[,] mas1 = new int[3, 3];
//int[,] mas2 = new int[3, 3];
//for (int i = 0; i < mas1.GetLength(0); i++)
//{
//    for (int j = 0; j < mas1.GetLength(1);j++)
//    {
//        mas1[i, j] = random.Next(1, 21);
//    }
//}
//for (int i = 0; i < mas2.GetLength(0); i++)
//{
//    for (int j = 0; j < mas2.GetLength(1);j++)
//    {
//        mas2[i, j] = random.Next(1, 21);
//    }
//}
//int[,,] mas3 = new int[3, 3, 2];
//for (int k = 0; k < mas3.GetLength(2); k++)
//{
//    for (int i = 0; i < mas3.GetLength(0); i++)
//    {
//        for (int j = 0; j < mas3.GetLength(1);j++)
//        {
//            if (k == 0) mas3[i, j, k] = mas1[i, j];
//            else mas3[i,j,k]= mas2[i, j];
//            Console.Write(mas3[i,j,k]+" ");
//        }
//        Console.WriteLine();
//    }
//    Console.WriteLine();
//}

//int[,] mas = new int[12, 10];
//int count = 1;
//for (int i = 0; i < mas.GetLength(1); i++)
//{
//    for (int j = 0; j < mas.GetLength(0); j++)
//    {
//        mas[j, i] = count++;
//    }
//}
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    for (int j = 0; j < mas.GetLength(1); j++)
//    {
//        Console.Write(mas[i, j] + " ");
//    }
//    Console.WriteLine();
//}
//int[,] mas = new int[12, 10];
//int count = 1;
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    for (int j = mas.GetLength(1)-1; j >=0; j--)
//    {
//        mas[i, j] = count++;
//    }
//}
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    for (int j = 0; j < mas.GetLength(1); j++)
//    {
//        Console.Write(mas[i, j] + " ");
//    }
//    Console.WriteLine();
//}

//int[,] mas = new int[12, 10];
//int count = 1;
//for (int i = mas.GetLength(1)-1; i >=0; i--)
//{
//    for (int j = mas.GetLength(0)-1; j >= 0; j--)
//    {
//        mas[j, i] = count++;
//    }
//}
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    for (int j = 0; j < mas.GetLength(1); j++)
//    {
//        Console.Write(mas[i, j] + " ");
//    }
//    Console.WriteLine();
//}


