//Напишите программу, которая запрашивает у пользователя ввод строки
//и слова. Затем программа должна использовать метод Contains() для
//проверки, содержит ли введенная строка указанное слово. Выведите
//сообщение о результате проверки наличия слова в строке.

//Console.Write("Введите текст:");
//string str=Console.ReadLine();
//Console.WriteLine("Введите слово для поиска:");
//string  word = Console.ReadLine();
//if (str.Contains(word.ToLower())) Console.WriteLine("Слово есть в тексте.");
//else Console.WriteLine("Слова нет в тексте.");

//Задача 2: Замена символов в строке
//Напишите программу, которая запрашивает у пользователя ввод строки
//и символа, который нужно заменить, а также символа, на который
//нужно заменить.
//Затем программа должна использовать метод Replace() для замены
//указанного символа на другой символ во введенной строке. Выведите
//обновленную строку на экран.

//Console.Write("Введите текст:");
//string str = Console.ReadLine();
//Console.WriteLine("Введите символ для замены:");
//char ch1 = char.Parse(Console.ReadLine());
//Console.WriteLine("Введите символ для вставки:");
//char ch2 = char.Parse(Console.ReadLine());
//str=str.Replace(ch1, ch2);
//Console.WriteLine(str);

//Задача 3: Подсчет количества вхождений слова
//Напишите программу, которая запрашивает у пользователя
//ввод строки и слова. Затем программа должна использовать
//метод Contains() и цикл для подсчета количества вхождений
//указанного слова во введенной строке. Выведите количество
//вхождений на экран.

//Console.Write("Введите текст:");
//string str = Console.ReadLine();
//Console.WriteLine("Введите слово для поиска:");
//string word = Console.ReadLine();
//int count = 0;
//str = str.ToLower();
//while (str.Contains(word.ToLower()))
//{
//    int index=str.IndexOf(word.ToLower());
//    count++;
//    str=str.Remove(0, index+word.Length);
//}
//Console.WriteLine($"Число вхождений: {count}");

//Задача 4*: Замена определенных значений
//Напишите программу, которая запрашивает у
//пользователя слово и заменяет все его вхождения на *
//посимвольно.

//Console.Write("Введите текст:");
//string str = Console.ReadLine();
//Console.Write("Введите слово для замены:");
//string word = Console.ReadLine();
//string replace = "";
//for (int i = 0; i < word.Length; i++) replace += "*";
//while (str.Contains(word.ToLower()))
//{
//    str=str.Replace(word.ToLower(),replace);
//}
//Console.WriteLine(str);

//Задание 1. Разделение полного имени на отдельные компоненты:
//Пользователь вводит полное имя в формате "Имя Фамилия".
//Используя метод Split, разделите полное имя на две отдельные строки -
//имя и фамилию.
//Выведите полученные значения на экран.

//Console.WriteLine("Введите имя и фамилию: ");
//string fio = Console.ReadLine();
//string[] mas = fio.Split(' ');
//foreach (string ma in mas)
//{
//    Console.WriteLine(ma);
//}
//Задание 2. Обработка списка элементов:
//Пользователь вводит список элементов, разделенных запятой, например,
//"яблоко,банан,апельсин".
//Используя метод Split и указав запятую в качестве разделителя,
//разделите список элементов на отдельные строки.
//Выведите каждый элемент списка на отдельной строке.

//Console.WriteLine("Введите список элементов, через запятую: ");
//string fio = Console.ReadLine();
//string[] mas = fio.Split(',');
//foreach (string ma in mas)
//{
//    Console.WriteLine(ma);
//}

//Задание 3. Разделение текста на предложения:
//Пользователь вводит текст, содержащий несколько предложений.
//Используя метод Split и символы ".", "!" и "?", разделите текст на
//отдельные предложения.
//Выведите каждое предложение на отдельной строке.

//Console.WriteLine("Введите текст: ");
//string fio = Console.ReadLine();
//string[] mas = fio.Split(',','!','.','?');
//foreach (string ma in mas)
//{
//    Console.WriteLine(ma);
//}

//Задание 4. Разделение строки на числа:
//Пользователь вводит строку, содержащую числа, разделенные
//пробелами, например, "10 20 30 40".
//Используя метод Split и пробел в качестве разделителя, разделите строку
//на отдельные числа.
//Преобразуйте каждое полученное значение в числовой тип данных
//(например, int или double).
//Выполните операции или выведите полученные числа по вашему
//выбору.

using System.ComponentModel.Design;

Console.Write("Введите числа через пробел: ");
string number = Console.ReadLine();
string[] mas = number.Split(' ');
foreach (string ma in mas)
{
    bool isNumber = true;
    for(int i = 0; i < ma.Length; i++)
    {
        if (!char.IsDigit(ma[i]) && (ma[i] != ',') && (ma[i] != '.')) isNumber = false; break;
    }
    if ((isNumber)&&(!ma.Contains(',') && !ma.Contains("."))) 
        {
        Console.WriteLine(int.Parse(ma));
        }
    else 
    if (isNumber && (ma.Contains(',') || ma.Contains(".")))
    {
        if (ma.Contains('.')) 
        { string strim; 
        strim = ma.Replace('.', ',');
        Console.WriteLine(double.Parse(strim));
        }
        else
        Console.WriteLine(double.Parse(ma));
    }
}

