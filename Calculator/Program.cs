using Lesson30_1;

Console.Write("Введите первое число: ");
double x;
double.TryParse(Console.ReadLine(), out x);
Console.Write("Введите второе число: ");
double y;
double.TryParse(Console.ReadLine(), out y);
Calculator calculator = new Calculator();
char op;
Console.Write("Введите операцию: ");
char.TryParse(Console.ReadLine(), out op);
switch (op)
{
    case '+': Console.WriteLine(calculator.Add(x, y)); break;
    case '-': Console.WriteLine(calculator.Sub(x, y)); break;
    case '*': Console.WriteLine(calculator.Mult(x, y)); break;
    case '/':
        try { Console.WriteLine(calculator.Div(x, y)); }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }
        break;
    default: break;
}