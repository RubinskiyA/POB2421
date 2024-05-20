//1.Сгенерировать случайное целое число в диапазоне от 0 до 5, запросить
//еще одно число у пользователя и в случае совпадения вывести на экран
//информацию о победе, в противном случае - поражении.

//Random random = new Random();
//int a = random.Next(0, 6);
//Console.Write("Введите число от 0 до 5: ");
//int b = int.Parse(Console.ReadLine());
//if (a == b) Console.WriteLine($"Вы выйграли, компьютер загадал {a}.");
//else Console.WriteLine($"Вы проиграли, компьютер загадал {a}.");

//2. Запросить у пользователя порядковый номер текущего месяца и
//вывести его название.

Console.Write("Введите порядковый номер месяца: ");
int month = int.Parse(Console.ReadLine());
Console.Write("Введите среднюю температуру месяца: ");
int avgTemp = int.Parse(Console.ReadLine());
switch (month)
{
    case 1: Console.WriteLine("Январь"); break;
    case 2: Console.WriteLine("Февраль"); break;
    case 3: Console.WriteLine("Март"); break;
    case 4: Console.WriteLine("Апрель"); break;
    case 5: Console.WriteLine("Май"); break;
    case 6: Console.WriteLine("Июнь"); break;
    case 7: Console.WriteLine("Июль"); break;
    case 8: Console.WriteLine("Август"); break;
    case 9: Console.WriteLine("Сентябрь"); break;
    case 10: Console.WriteLine("Октябрь"); break;
    case 11: Console.WriteLine("Ноябрь"); break;
    case 12: Console.WriteLine("Декабрь"); break;
    default: Console.WriteLine("Нет такого месяца"); break;
}
if (avgTemp>0&&month ==1||month ==2||month ==12) Console.WriteLine("Дождливая зима");