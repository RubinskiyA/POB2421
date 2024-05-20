Console.WriteLine("Выберите действие:\n+ Сложение\n- Вычитание\n* Умножение\n/ Деление");
Console.Write("Выбор действия:");
string action = Console.ReadLine();
Console.Write("Введите первое число:");
double num1 = double.Parse(Console.ReadLine());
Console.Write("Введите второе число число:");
double num2 = double.Parse(Console.ReadLine());

switch (action)
{
    case "+":
        Console.WriteLine($"Сумма {num1} и {num2} равна {num1+num2:f2}");
        break;
    case "-":
        Console.WriteLine($"Разница {num1} и {num2} равна {num1 - num2:f2}");
        break;
    case "*":
        Console.WriteLine($"Произведение {num1} и {num2} равна {num1 * num2:f2}");
        break;
    case "/":
        {
            if (num2 == 0) Console.WriteLine("На ноль делить нельзя! Ошибка.");
            else Console.WriteLine($"Частное {num1} и {num2} равна {num1 / num2}:f2");
        }
        break;
    default:
        Console.WriteLine("Ошибка: выбран недопустимое действие.");
        break;
}
