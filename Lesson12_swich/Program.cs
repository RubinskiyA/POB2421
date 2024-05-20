//Console.WriteLine("Введите номер дня недели");
//int n = int.Parse(Console.ReadLine());
//if (n == 1) Console.WriteLine("Понедельник");
//    else if (n == 2) Console.WriteLine("Вторник");
//        else if (n == 3) Console.WriteLine("Среда");
//            else if (n == 4) Console.WriteLine("Четверг");
//                else if (n == 5) Console.WriteLine("Пятница");
//                    else if (n == 6) Console.WriteLine("Суббота");
//                         else if (n == 7) Console.WriteLine("Воскресенье");
//                                else Console.WriteLine("Нет такого дня недели");


//switch (n)
//{
//        case 1: Console.WriteLine("Понедельник"); break;
//        case 2: Console.WriteLine("Вторник"); break ;  
//        case 3: Console.WriteLine("Среда"); break;
//        case 4: Console.WriteLine("Четверг"); break;
//        case 5: Console.WriteLine("Пятница"); break;
//        case 6: Console.WriteLine("Суббота"); break;
//        case 7: Console.WriteLine("Воскресенье"); break;
//        default: Console.WriteLine("Нет такого дня недели"); break;
//}


//Console.WriteLine("Введите номер месяца");
//int m = int.Parse(Console.ReadLine());
//switch (m)
//{
//    case 12: case 1: case 2 : Console.WriteLine("Zima"); break;
//    case 3: case 4: case 5: Console.WriteLine("Vesna"); break;
//    case 6: case 7: case 8: Console.WriteLine("Leto"); break;
//    case 9: case 10: case 11: Console.WriteLine("Osen'"); break;
//    default: Console.WriteLine("Net takogo mesyaca"); break;
//}

//Console.Write("Введите номер масти(1-крести,2-бубны,3-пики,4-черви):");
//int mast = int.Parse(Console.ReadLine());
//Console.Write("Введите номер карты(6-шесть...14-туз):");
//int card = int.Parse(Console.ReadLine());
//switch (card)
//{
//    case 6:  Console.Write("Шесть"); break;
//    case 7: Console.Write("Семь"); break;
//    case 8: Console.Write("Восемь"); break;
//    case 9: Console.Write("Девять"); break;
//    case 10: Console.Write("Десять"); break;
//    case 11: Console.Write("Валет"); break;
//    case 12: Console.Write("Дама"); break;
//    case 13: Console.Write("Король"); break;
//    case 14: Console.Write("Туз"); break;
//    default:
//        Console.Write("danger"); break;




//}
//switch (mast)
//{ 
//    case 1: Console.Write(" крести"); break;
//    case 2: Console.Write(" бубны"); break;
//    case 3: Console.Write(" пики"); break;
//    case 4: Console.Write(" черви"); break;
//    default:
//        Console.Write("danger"); break;


//}


//Console.Write("Введите сумму: ");
//int money = int.Parse(Console.ReadLine());
//if (money%100>=11&money%100<=14) Console.WriteLine($"{money} рублей");
//else switch (money % 10)
//    {
//        case 1: Console.WriteLine($"{money} рубль");break;
//        case 2: case 3: case 4:  Console.WriteLine($"{money} рубля"); break;
//        default: Console.WriteLine($"{money} рублей"); break;
//    }

//Random random = new Random();
//Console.Write("Меню:\n"+
//    "1 - сгенерировать целое число\n"+
//    "2- сгенерировать вещественное число\n"+
//    "3- сгенерировать число в диапазоне\n");
//int n = int.Parse(Console.ReadLine());
//switch (n)
//{
//    case 1:
//        {
//            Console.Write("Введите верхнюю границу числа: ");
//            int m = int.Parse(Console.ReadLine());
//            Console.WriteLine(random.Next(m + 1));
//        }
//        break;

//    case 2:
//        {
//            Console.Write("Введите верхнюю границу числа: ");
//            double m = double.Parse(Console.ReadLine());
//            Console.WriteLine($"{random.NextDouble() * m:F2}");
//        }
//        break;

//    case 3:
//        {
//            Console.Write("Введите нижнюю границу числа: ");
//            int s = int.Parse(Console.ReadLine());
//            Console.Write("Введите верхнюю границу числа: ");
//            int m = int.Parse(Console.ReadLine());
//            if (s>m)
//            {
//                int temp = s;
//                m = s;
//                s=temp;
//            }
//            Console.WriteLine(random.Next(s, m + 1));
//        }
//        break;
//}

//Random random = new Random();

//switch (random.Next(6, 15)
//{
//    case 6: Console.Write("Шесть"); break;
//    case 7: Console.Write("Семь"); break;
//    case 8: Console.Write("Восемь"); break;
//    case 9: Console.Write("Девять"); break;
//    case 10: Console.Write("Десять"); break;
//    case 11: Console.Write("Валет"); break;
//    case 12: Console.Write("Дама"); break;
//    case 13: Console.Write("Король"); break;
//    case 14: Console.Write("Туз"); break;
//}

//Random random = new Random();
//Console.WriteLine("Введите певый элемент: ");
//string a = Console.ReadLine();
//Console.WriteLine("Введите второй элемент: ");
//string b = Console.ReadLine();
//Console.WriteLine("Введите третий элемент: ");
//string c = Console.ReadLine();

//switch (random.Next(1, 4))
//{
//    case 1: Console.Write(a); break;
//    case 2: Console.Write(b); break;
//    case 3: Console.Write(c); break;
//}


//Random random = new Random();
//Console.WriteLine("Введите валюту:\n"+
//    "1 - доллар\n"+
//    "2- евро\n"+
//    "3- юани\n"+
//    "4- стерлинг");
//int n = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите количество валюты: ");
//decimal money = decimal.Parse(Console.ReadLine());

//switch (n)
//{
//    case 1:
//        {
//            Console.WriteLine("Введите курс доллара: "); 
//            decimal kurs = decimal.Parse(Console.ReadLine());
//            Console.WriteLine($"{money} долларов равно {kurs*money} рублей");
//        };
//        break;
//    case 2:
//        {
//            Console.WriteLine("Введите курс евро: "); 
//            decimal kurs = decimal.Parse(Console.ReadLine());
//            Console.WriteLine($"{money} евро равно {kurs * money} рублей");
//        };
//        break;
//    case 3:
//        {
//            Console.WriteLine("Введите курс юаня: "); 
//            decimal kurs = decimal.Parse(Console.ReadLine());
//            Console.WriteLine($"{money} юаней равно {kurs * money} рублей");
//        };
//        break;
//    case 4:
//        {
//            Console.WriteLine("Введите курс стерлингов: "); 
//            decimal kurs = decimal.Parse(Console.ReadLine());
//            Console.WriteLine($"{money} стерлингов равно {kurs * money} рублей");
//        };
//        break;
//}

//Random random = new Random();
//Console.Write("Выберите:\n" +
//    "1 - камень\n" +
//    "2- ножницы\n" +
//    "3- бумага\n");
//int n = int.Parse(Console.ReadLine());
//int m = random.Next(1, 4);
//switch (n)
//{
//    case 1:
//        {
//            Console.Write("Камень - ");
//            if (m == 1) Console.WriteLine("камень, Ничья");
//            else if (m == 2) Console.WriteLine("ножницы, Победа");
//            else Console.WriteLine("бумага, Поражение");
//        }; break;
//    case 2:
//        {
//            Console.Write("Ножницы - ");
//            if (m == 1) Console.WriteLine("камень, Поражение");
//            else if (m == 2) Console.WriteLine("ножницы, Ничья");
//            else Console.WriteLine("бумага, Победа");
//        }; break;
//    case 3:
//        {
//            Console.Write("Бумага - ");
//            if (m == 1) Console.WriteLine("камень, Победа");
//            else if (m == 2) Console.WriteLine("ножницы, Поражение");
//            else Console.WriteLine("бумага, Ничья");
//        }; break;
//}


//Console.WriteLine("Введите ваш возраст:");
//int age = int.Parse(Console.ReadLine());
//if (age<18) Console.WriteLine("Вы слишком молоды для участия в выборах.");
//else if (age>=18&&age<=35) Console.WriteLine("Вы можете участвовать в выборах в качестве кандидата в депутата.");
//else if (age>36&&age<=65) Console.WriteLine("Вы можете участвовать в выборах в качестве кандидата в президенты.");
//else Console.WriteLine("Ваш возраст слишком велик для участия в выборах.");
//Console.WriteLine("Кандидаты в президенты солнечного города:\r\n● Незнайка\r\n● Лунтик\r\n● Карлсон\r\n● Дядя Фёдор");
//Console.WriteLine("За кого бы вы проголосовали:");
//string name = Console.ReadLine();
//if (name =="Незнайка") Console.WriteLine("А у тебя в животе арбуз вырастет!!!");
