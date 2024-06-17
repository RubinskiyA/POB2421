//передача по ссылке(меняется переменная)
//void Swap(ref int x,ref int y)
//{
//    int temp = x;
//    x = y; 
//    y = temp;
//}

//int a = 6, b = 10;
//Console.WriteLine("a="+a+" b="+b);
//Swap(ref a,ref b);
//Console.WriteLine("a=" + a + " b=" + b);

//try
//{
//    int x = int.Parse(Console.ReadLine()!);
//}
//catch(FormatException e)
//{

//}



//выходной параметр out
//int x;
//if(int.TryParse(Console.ReadLine(), out x))
//    Console.WriteLine(x);
//else Console.WriteLine("error input");

//int s;

//Sum(4, 9, out s);
//void Sum(int x,int y,out int s)
//{
//    s = x + y;
//}

//Console.WriteLine(s);




//in входной параметр
//void func(in int x)
//{

//    Console.WriteLine(x + 5) ;
//}

//Console.WriteLine("Введите число: ");
//int x;
//int.TryParse(Console.ReadLine(), out x);
//func(in x);

//void Sum(int[] mas)
//{
//    for (int i = 0; i < mas.Length; i++)
//    {
//        mas[i] *= 2;
//    }
//}

//int[] m = { 5, 3, 9, 6 };
//Sum(m);
//foreach (int item in m)
//{
//    Console.Write(item+" ");
//}

//void Sum(params int[] numbers)
//{
//    int result = 0;
//    foreach (int number in numbers)
//    {
//        result += number;
//    }
//    Console.WriteLine(result);
//}
//int[] m = { 5, 3, 9, 6 };
//Sum(1,4,6,8,65,34,12,1,12,4);


//double d;
//    Console.Write("Введите первое число: ");
//double num1;
//    double.TryParse(Console.ReadLine(),out num1);
//Console.Write("Введите первое число: ");
//double num2;
//double.TryParse(Console.ReadLine(), out num2);
//void Divide(double x,double y,out double d)
//{
//       d = 0;
//    try
//    {
//        if (y != 0) d = x / y;
//        else throw new DivideByZeroException("Делить на ноль нельзя");
//    }
//    catch (DivideByZeroException e)
//    {
//        Console.WriteLine(e.Message);
//    }
//}
//Divide(num1, num2,out d);
//Console.WriteLine(d);


//void CalculateAverage(params double[] data)
//{
//    double sum = 0;
//  foreach (var item in data)
//    {
//        sum += item;
//    }
//    Console.WriteLine($"AVG={(sum / data.Length)}") ;
//}

//CalculateAverage(1, 5, 3, 4,2);

//int[] m = { 5, 3, 9, 6 ,1};
//int count;
//void ModifyArray(int[] mas,out int count)
//{
//    count = 0;
//    for (int i=0; i<mas.Length; i++)
//    {
//        int temp;
//        temp = mas[i];
//        mas[i] *= mas[i];
//        if (mas[i]!=temp) count++;

//    }
//}
//ModifyArray(m, out count);
//foreach (int i in m) 
//{
//    Console.Write(i +" ");
//}
//Console.WriteLine("Количество элементов: "+count);

