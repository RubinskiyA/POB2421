//////Задание 1
//Random random = new Random();
//double[,] mas = new double[3, 3];

//    for (int i = 0; i < mas.GetLength(0); i++)
//    {
//        for (int j = 0; j < mas.GetLength(1); j++)
//        {
//            mas[i, j] = random.NextDouble() * 20;
//            Console.Write($"{mas[i, j]:f2} ");
//        }
//        Console.WriteLine();
//    }
//Console.WriteLine("Введите индексы элемента для замены, через пробел: ");
//string indexIJ=Console.ReadLine();
//string[] index = indexIJ.Split(" ");
//Console.Write("Введите число для вставки: ");
//double num = double.Parse(Console.ReadLine());
//mas[int.Parse(index[0]), int.Parse(index[1])] = num;

//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    for (int j = 0; j < mas.GetLength(1); j++)
//    {
//        Console.Write($"{mas[i, j]:f2} ");
//    }
//    Console.WriteLine();
//}

////Задание 2
string[,] letter = {{"п","у"},
                  {"р","н"},
                  {"в","е"},
                  {"и","б"},
                  {"т","й"} };
Console.WriteLine(letter[0,0]+ letter[1, 0] + letter[3, 0] + letter[2, 0] + letter[2, 1] + letter[4, 0]);
