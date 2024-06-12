    
//Console.WriteLine("Введите первый параметр: ");
//int firstParametr = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите второй параметр: ");
//int secondParametr = int.Parse(Console.ReadLine());
//void Print(int first, int second)
//{
//    Console.WriteLine(first);
//    Console.WriteLine(second);
//}
//Print(firstParametr,secondParametr);


//Console.WriteLine("Введите первое число: ");
//float num1 = float.Parse(Console.ReadLine());
//Console.WriteLine("Введите второе число: ");
//float num2 = float.Parse(Console.ReadLine());
//Console.WriteLine("Введите префикс: ");
//string str = Console.ReadLine();
//void funcCW(float first, float second, string str)
//{
//    float r1=first+second;
//    float r2=first*second;
//    Console.WriteLine(str+" "+r1);
//    Console.WriteLine(str +" "+ r2);

//}

//funcCW(num1,num2,str);


//int numfloatSum(int first, int second)
//{
//    return first + second;
//}
//int numfloatMultiPly(int first, int second)
//{
//    return first * second;
//}
//int numfloatSubtrac(int first, int second)
//{
//    return first - second;
//}
//float numfloatDevide(float first, float second)
//{
//    if (second != 0) return first / second;
//    throw new Exception("Деление на ноль запрещено.");
//}
//int masSum(int mas)
//{
//    int result = 0;
//    for (int i = 0; i < mas; i++)
//    {
//        result = numfloatSum(result, i);
//    }
//    return result;
//}
//void Run()
//{
//    int num1 = int.Parse(Console.ReadLine());
//    int num2 = int.Parse(Console.ReadLine());
//    float result = 0;
//    char oper = char.Parse(Console.ReadLine());
//    switch (oper)
//    {
//        case '+': result = numfloatSum(num1, num2); break;
//        case '*': result = numfloatMultiPly(num1, num2); break;
//        case '-': result = numfloatSubtrac(num1, num2); break;
//        case '/': result = numfloatDevide(num1, num2); break;

//        default: Console.WriteLine(num1 + " и " + num2 + " " + oper + " unresoved"); break;
//    }
//    result = numfloatSum(result, 1);
//}
////Run();

//int[] mas = new int[20];
//for (int i = 0; i < 20; i++)
//{
//    mas[i] = i;
//}



using System.Threading.Channels;

int sumFeb(int k)
{
    if (k == 1) return 0;
    else if (k == 2) return 1;
    else if (k > 2) return sumFeb(k - 1) + sumFeb(k - 2);
    else throw new Exception("error");
}

Console.WriteLine(sumFeb(8));