Console.Write("Введите первое число: ");
int num1,num2;
int.TryParse(Console.ReadLine(), out num1);
//Console.Write("Введите второе число: ");
//int.TryParse(Console.ReadLine(),out num2);
Console.WriteLine("Выберите операцию с числами:\n1 - логическое умножение\n2 - логическое сложение\n3 - шифрование по ключу\n4 - инверсия");
int op;
int.TryParse(Console.ReadLine(),out op);

switch (op)
{
    case 1:
        {
            Console.Write("Введите второе число: ");
            int.TryParse(Console.ReadLine(), out num2);
            Console.WriteLine($"Результат логического умножения {num1} и {num2} - {LogicOperationAND(num1, num2)}");
        }; break;
    case 2:
        {
            Console.Write("Введите второе число: ");
            int.TryParse(Console.ReadLine(), out num2);
            Console.WriteLine($"Результат логического сложения {num1} и {num2} - {LogicOperationOR(num1, num2)}");
        } break;
    case 3:
        {
            Console.Write("Введите второе число(ключ): ");
            int.TryParse(Console.ReadLine(), out num2);
            Console.WriteLine($"Результат шифрования {num1} с ключом {num2} - {LogicOperationKey(num1, num2)}");
        }
        break;
    case 4:
        Console.WriteLine($"Результат инверсии числа {num1} - {LogicOperationInvers(num1)}");
        break;
    default:
        Console.WriteLine("Неверный номер операции."); break;
}


int LogicOperationAND(int x,int y)
{
    return x&y;
}
int LogicOperationOR(int x,int y)
{
    return x | y;
}
int LogicOperationKey(int x,int y)
{
    return x ^ y;
}
int LogicOperationInvers(int x)
{
    return ~x;
}
