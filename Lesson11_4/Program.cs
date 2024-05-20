//Основное задание
//Console.Write("Введите ваш возраст: ");
//int age = int .Parse(Console.ReadLine());
//if (age<18) Console.WriteLine("Вы слишком молоды для участия в выборах.");
//else if (age >= 18 && age <= 35) Console.WriteLine("Вы можете участвовать в выборах в качестве депутата.");
//else if (age >= 36 && age <= 65) Console.WriteLine("Вы можете участвовать в выборах в качестве кандидата в президенты.");
//else if (age > 65) Console.WriteLine("Ваш возраст слишком велик для участия в выборах.");
//Console.WriteLine("Кандидаты в президенты солнечного города:\r\n1 - Незнайка\r\n2 -  Лунтик\r\n3 -  Карлсон\r\n4 -  Дядя Фёдор");
//Console.Write("Введите номер кандидата за которого хотите проголосовать: ");
//int num = int.Parse(Console.ReadLine());
//switch (num)
//{
//    case 1: Console.WriteLine("А у тебя в животе арбуз вырастет!!!");break;
//    case 2: Console.WriteLine("Я родился!");break ;
//    case 3: Console.WriteLine("Спокойствие, только спокойствие!");break;
//    case 4: Console.WriteLine("Я ничей. Я сам по себе мальчик. Свой собственный.");break;
//}

//Доп. задание 1

//Random random = new Random();
//int month =random.Next(1, 13);
//switch (month)
//{
//    case 1: Console.WriteLine("Январь, сколько в нем дней?"); break;
//    case 2: Console.WriteLine("Февраль, сколько в нем дней?"); break;
//    case 3: Console.WriteLine("Март, сколько в нем дней?"); break;
//    case 4: Console.WriteLine("Апрель, сколько в нем дней?"); break;
//    case 5: Console.WriteLine("Май, сколько в нем дней?"); break;
//    case 6: Console.WriteLine("Июнь, сколько в нем дней?"); break;
//    case 7: Console.WriteLine("Июль, сколько в нем дней?"); break;
//    case 8: Console.WriteLine("Август, сколько в нем дней?"); break;
//    case 9: Console.WriteLine("Сентябрь, сколько в нем дней?"); break;
//    case 10: Console.WriteLine("Октябрь, сколько в нем дней?"); break;
//    case 11: Console.WriteLine("Ноябрь, сколько в нем дней?"); break;
//    case 12: Console.WriteLine("Декабрь, сколько в нем дней?"); break;
//    default: Console.WriteLine("Нет такого месяца"); break;
//}
//int days = int .Parse(Console.ReadLine());
//if ((month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12) && days != 31 ) Console.WriteLine("Поражение, в этом месяце 31 день");
//else if (month == 2 && (days != 28||days!=29)) Console.WriteLine("Поражение, в этом месяце 28 или 29 день");
//else if ((month == 4||month==6 || month == 9 || month == 11) && days != 30 ) Console.WriteLine("Поражение, в этом месяце 30 дней");
//else Console.WriteLine("Победа");

//Доп. задание 2

Random random = new Random();
int num = random.Next(1, 13);
switch (num)
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
}
