//Random random = new Random();
//int[] mas4 = new int[random.Next(10, 31)];
//for (int i = 0; i < mas4.Length; i++)
//{
//    mas4[i] = random.Next(50);
//    Console.Write(mas4[i] + " ");
//}
//Console.WriteLine();
//for (int i = 0; i < mas4.Length - 1; i++)
//{
//    for (int j = i + 1; j < mas4.Length; j++)
//    {
//        if (mas4[i] > mas4[j])
//        {
//            int temp = mas4[i];
//            mas4[i] = mas4[j];
//            mas4[j] = temp;
//        }
//    }
//}
//for (int i = 0; i < mas4.Length; i++)
//{
//    Console.Write(mas4[i] + " ");
//}

//int[] mas = new int[random.Next(10, 31)];
//Array.Fill(mas, 5);//заполняет массив одним и тем же числом
//for (int i = 0; i < mas.Length; i++) Console.Write(mas[i]+" ");
//Console.WriteLine();
//Array.Fill(mas, 4, mas.Length/2,6) ;
//for (int i = 0; i < mas.Length; i++) Console.Write(mas[i] + " ");
//Console.WriteLine();
//int[] mas2 = new int[mas.Length];

//Array.Copy(mas, mas2, mas.Length);//копирует массив из одного в другой
//for (int i = 0;i < mas2.Length; i++)
//{
//    Console.Write(mas2[i]+" ");
//}
//Console.WriteLine();

//Console.Write(Array.IndexOf(mas2,4)+" ");//индекс первого вхождения в массив
//Console.Write(Array.LastIndexOf(mas2,4));//индекс последнего вхождения в массив
//Console.WriteLine();
//Array.Sort(mas2);
//for (int i = 0; i < mas2.Length; i++)
//{
//    Console.Write(mas2[i] + " ");
//}
//Console.WriteLine();
//Console.WriteLine(Array.BinarySearch(mas2, 4));
//Console.WriteLine();

//Array.Sort(mas4);
//for (int i = 0; i < mas4.Length; i++)
//{
//    Console.Write(mas4[i] + " ");
//}
//Console.WriteLine();
//Console.WriteLine("Введите число: ");
//int n =int.Parse(Console.ReadLine());
//Console.WriteLine(Array.BinarySearch(mas4, n));
//Console.WriteLine(mas4.Rank);
//Console.WriteLine();
//Array.Reverse(mas4);
//for (int i = 0; i < mas4.Length; i++)
//{
//    Console.Write(mas4[i] + " ");
//}
//Console.WriteLine();
//Array.Clear(mas4);
//for (int i = 0; i < mas4.Length; i++)
//{
//    Console.Write(mas4[i] + " ");
//} Console.WriteLine();

//1.Напишите программу, которая запрашивает у пользователя 5 чисел и
//сохраняет их в массиве. Затем программа выводит на экран все числа
//из массива в обратном порядке.
//int[] mas99 = new int[5];
//for (int i = 0; i < mas99.Length; i++)
//{
//    Console.Write($"Введите {i + 1} цифру:");
//    mas99[i] = int.Parse(Console.ReadLine());
//}

//Array.Reverse( mas99 );
//for (int i = 0; i < mas99.Length; i++)
//{
//    Console.Write(mas99[i] + " ");
//}
//Console.WriteLine();

//2.Напишите программу, которая запрашивает у пользователя 5 слов и
//сохраняет их в массиве. Затем программа находит и выводит самое
//длинное слово из массива.

//string[] mas1 = new string[5];
//for (int i = 0; i < mas1.Length; i++)
//{
//    Console.Write($"Введите {i + 1} слово:");
//    mas1[i] = Console.ReadLine();
//}
//int max = mas1[0].Length;
//string masStr = mas1[0];
//for  (int i = 0;i < mas1.Length; i++)
//{
//    if (mas1[i].Length > max)
//    {
//        max= mas1[i].Length;
//        masStr = mas1[i];
//    }
//}
//Console.WriteLine(masStr+" ");

//3.Создайте 2 массива случайных чисел. Соедините их с помощью
//метода Concat(). Затем программа находит и выводит среднее
//арифметическое всех чисел в массиве.

//Random random = new Random();
//int[] mas1 = new int[random.Next(5, 16)];
//int[] mas2 = new int[random.Next(5, 16)];
//int[] masSum = new int[mas1.Length + mas2.Length];
//for (int i = 0; i < mas1.Length; i++)
//{
//    mas1[i] = random.Next(20);
//    Console.Write(mas1[i] + " ");
//}
//Console.WriteLine();
//for (int i = 0; i < mas2.Length; i++)
//{
//    mas2[i] = random.Next(20);
//    Console.Write(mas2[i] + " ");
//}
//Console.WriteLine();
//masSum = mas1.Concat(mas2).ToArray();
//for (int i = 0; i < masSum.Length; i++)
//{

//    Console.Write(masSum[i] + " ");
//}
//Console.WriteLine();
//Console.WriteLine($"{masSum.Average():f2}");

Random random = new Random();
int[] mas1 = new int[10];
for (int i = 0; i < mas1.Length; i++)
{
    mas1[i] = random.Next(20);
    Console.Write(mas1[i] + " ");
}
//Console.WriteLine();
//Console.WriteLine("Max=" + mas1.Max() + " " + "Min=" + mas1.Min());

//5.Напишите программу, которая запрашивает у пользователя 5 слов и
//сохраняет их в массиве. Затем программа выводит на экран все слова
//из массива, начинающиеся на определенную букву, которую вводит
//пользователь. Для данной задачи используйте метод “IndexOf()”

//string[] mas1 = new string[5];
//for (int i = 0; i < mas1.Length; i++)
//{
//    Console.Write($"Введите {i + 1} слово:");
//    mas1[i] = Console.ReadLine();
//}
//Console.WriteLine();
//Console.WriteLine("Введите букву: ");
//char letter = char.Parse(Console.ReadLine());
//foreach (string c in mas1)
//{
//    if (c.ToLower().IndexOf(letter)==0)
//    {
//        Console.WriteLine(c);
//    }
//}
/////////////////////////////////////////
Console.WriteLine();
Console.WriteLine(mas1.Sum());