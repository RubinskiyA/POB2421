//Напишите программу, которая запрашивает у пользователя строку -
//слово и выводит его в обратном порядке.
//Console.WriteLine("Введите слово: ");
//string slovo = Console.ReadLine();
//for (int i = slovo.Length-1;i>=0;i--) Console.Write(slovo[i]);

//Напишите программу, где от пользователя берется на ввод строка -
//слово и производится проверка - является ли слово палиндромом или
//нет. С выводом пользователю результата

//Console.WriteLine("Введите слово: ");
//string slovo = Console.ReadLine();
//string slovo2 = "";
//for (int i = slovo.Length - 1; i >= 0; i--) slovo2 += slovo[i];
//if (slovo2.ToLower() == slovo.ToLower()) Console.WriteLine("Полиндром");
//else Console.WriteLine("Не полиндром");

//Напишите программу, которая запрашивает у пользователя строку и
//выводит каждый второй символ этой строки.

//Console.WriteLine("Введите слово: ");
//string slovo = Console.ReadLine();
//for (int i = 1;i<slovo.Length;i+=2)
//    Console.Write(slovo[i]);

//Напишите программу, которая запрашивает у пользователя строку и
//выводит ее на экран, заменяя каждую гласную букву на символ "*".

//Console.WriteLine("Введите слово: ");
//string slovo = Console.ReadLine();
//for (int i = 0;i<slovo.Length;i++)
//{
//    if (slovo[i] == 'а' || slovo[i] == 'у' || slovo[i] == 'е' ||
//        slovo[i] == 'ы' || slovo[i] == 'о' || slovo[i] == 'э' ||
//        slovo[i] == 'я' || slovo[i] == 'и' || slovo[i] == 'ю' )
//    { 
//      slovo = slovo.Remove(i, 1);
//      slovo = slovo.Insert(i, "*"); 
//    }
//}
//Console.WriteLine(slovo);

//1.Написать программу, которая выводит на экран таблицу умножения
//от 1 до 10, используя вложенный цикл for.

//for (int i = 1; i <= 10; i++)
//{
//    for (int j = 1; j <= 10; j++)
//    {
//        Console.WriteLine($"{i}*{j}={i*j}");
//    }
//    Console.WriteLine("\n");
//} 


//for (int i = 1; i <= 5; i++)
//{
//    for (int j = 1; j <= i; j++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}

//for (int i = 1; i <=1; i++)
//{
//    for (int j = 5; j >= i; j--)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}

