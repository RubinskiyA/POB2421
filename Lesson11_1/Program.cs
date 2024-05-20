int greate10 = 0;
int less_10 = 0;
int max = int.MinValue;
int min = int.MaxValue;
int sum = 0;


Console.Write("Введите первое число:");
int num1 = int.Parse(Console.ReadLine());
sum += num1;
greate10 += (num1 > 10) ? 1 : 0;
if (num1<-10) less_10++;
if (num1>max) max = num1;
if (num1<min) min = num1;

Console.Write("Введите второе число:");
int num2 = int.Parse(Console.ReadLine());
sum += num2;
greate10 += (num2 > 10) ? 1 : 0;
if (num2 < -10) less_10++;
if (num2 > max) max = num2;
if (num2 < min) min = num2;

Console.Write("Введите третье число:");
int num3 = int.Parse(Console.ReadLine());
sum += num3;
greate10 += (num3 > 10) ? 1 : 0; 
if (num3 < -10) less_10++;
if (num3 > max) max = num3;
if (num3 < min) min = num3;

Console.Write("Введите четвертое число:");
int num4 = int.Parse(Console.ReadLine());
sum += num4;
greate10 += (num4 > 10) ? 1 : 0;
if (num4 < -10) less_10++;
if (num4 > max) max = num4;
if (num4 < min) min = num4;

Console.Write("Введите пятое число:");
int num5 = int.Parse(Console.ReadLine());
sum += num5;
greate10 += (num5 > 10) ? 1 : 0;
if (num5 < -10) less_10++;
if (num5 > max) max = num5;
if (num5 < min) min = num5;

Console.Write("Введите шестое число:");
int num6 = int.Parse(Console.ReadLine());
sum += num6;
greate10 += (num6 > 10) ? 1 : 0;
if (num6 < -10) less_10++;
if (num6 > max) max = num6;
if (num6 < min) min = num6;

Console.Write("Введите седьмое число:");
int num7 = int.Parse(Console.ReadLine());
sum += num7;
greate10 += (num7 > 10) ? 1 : 0;
if (num7 < -10) less_10++;
if (num7 > max) max = num7;
if (num7 < min) min = num7;

Console.Write("Введите восьмое число:");
int num8 = int.Parse(Console.ReadLine());
sum += num8;
greate10 += (num8 > 10) ? 1 : 0;
if (num8 < -10) less_10++;
if (num8 > max) max = num8;
if (num8 < min) min = num8;

Console.Write("Введите девятое число:");
int num9 = int.Parse(Console.ReadLine());
sum += num9;
greate10 += (num9 > 10) ? 1 : 0;
if (num9 < -10) less_10++;
if (num9 > max) max = num9;
if (num9 < min) min = num9;

Console.Write("Введите десятое число:");
int num10 = int.Parse(Console.ReadLine());
sum += num10;
greate10 += (num10 > 10) ? 1 : 0;
if (num10 < -10) less_10++;
if (num10 > max) max = num10;
if (num10 < min) min = num10;

double aver = (double)sum / 10;

Console.WriteLine($"Сумма все чисел равна: {sum}\n"+
    $"Чисел больше 10: {greate10}\n"+
    $"Чисел меньше -10: {less_10}\n"+
    $"Среднее арифметическое чисел: {aver}\n"+
    $"Максимальное значение: {max}\n"+
    $"Минимальное значение: {min}\n");
