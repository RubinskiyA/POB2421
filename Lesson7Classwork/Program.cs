//Анкета о пользователе.

//Console.WriteLine("Как вас зовут?");
//string name = Console.ReadLine();
//Console.WriteLine("Сколько вам лет?");
//int old =int.Parse(Console.ReadLine());
//Console.WriteLine("Откуда вы?");
//string city = Console.ReadLine();
//Console.WriteLine("Кем вы работаете?");
//string work = Console.ReadLine();
//Console.WriteLine("Расскажите о ваших увлечениях:");
//string hobby = Console.ReadLine();


//Console.WriteLine($"Пользователя зовут {name}, ему {old} лет. Он из города {city}. Его профессия {work}. Он увлекается {hobby}.");

//Чек с вводимыми данными

//const string INN = "390001234567";
//const string COMP = "Бульбазавр и КО";

//Console.Write("Введите название продукта:");
//string name1 = Console.ReadLine();
//Console.Write("Введите количество:");
//int count1 = int.Parse(Console.ReadLine());
//Console.Write("Введите цену:");
//decimal price1 = decimal.Parse(Console.ReadLine());

//Console.Write("Введите название продукта:");
//string name2 = Console.ReadLine();
//Console.Write("Введите количество:");
//int count2 = int.Parse(Console.ReadLine());
//Console.Write("Введите цену:");
//decimal price2 = decimal.Parse(Console.ReadLine()); 
//Console.Write("Введите название продукта:");

//string name3 = Console.ReadLine();
//Console.Write("Введите количество:");
//int count3 = int.Parse(Console.ReadLine());
//Console.Write("Введите цену:");
//decimal price3 = decimal.Parse(Console.ReadLine()); 
//Console.Write("Введите название продукта:");

//string name4 = Console.ReadLine();
//Console.Write("Введите количество:");
//int count4 = int.Parse(Console.ReadLine());
//Console.Write("Введите цену:");
//decimal price4 = decimal.Parse(Console.ReadLine());
//decimal sum = count1*price1+count2*price2+count3*price3+count4*price4;

//Console.Title = "Чек";
//Console.WriteLine("--------------------------------\n" +
//    $"Организация {COMP}\n" +
//    $"ИНН {INN}\n" +
//    "*****************************\n" +
//($"{"N",-4}{"Название",-10}{"Цена",-6}{"Кол.",-6}{"Сумма",-6}\n") +
//($"{1,-4}{name1,-10}{price1,-6}{count1,-6}{(count1 * price1),-6}\n") +
//($"{2,-4}{name2,-10}{price2,-6}{count2,-6}{(count2 * price2),-6}\n") +
//($"{3,-4}{name3,-10}{price3,-6}{count3,-6}{(count3 * price3),-6}\n") +
//($"{4,-4}{name4,-10}{price4,-6}{count4,-6}{(count4 * price4),-6}\n") +
//($"{"Итог",-26}{sum}"));

//Приветствие и возраст пользователя.

//Console.Write("Введите свое ФИО:");
//string fio = Console.ReadLine();
//Console.Write("Введите дату рождения(yyyy.MM.dd):");
//DateTime birthDay = DateTime.Parse(Console.ReadLine());
//int age = DateTime.Now.Year-birthDay.Year;
//Console.WriteLine($"Привет, {fio}. Ваш возраст {age} лет.");


