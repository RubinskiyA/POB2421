//using System.Security.Cryptography;

//long Fact(int n)
//{
//    long f = 1;
//    for (int i = 1; i <= n; i++)
//    {
//        f *= i;
//    }
//    return f;
//}

//long FactRec(int n)
//{
//    if (n == 0) return 1;
//    else return n * FactRec(n - 1);
//}
//Console.Write("Введите n: ");
//int n;
//int.TryParse(Console.ReadLine(), out n);
//Console.WriteLine($"Факториал {n} равен {Fact(n)}");
//Console.WriteLine($"Факториал {n} равен {FactRec(n)}");


//long EgeFunc(int n)
//{
//    if (n == 1) return 1;
//    else if (n == 2) return 3;
//    else return EgeFunc(n - 1) * n + EgeFunc(n - 2) * (n - 1);
//}
//Console.WriteLine("введите n: ");
//int n;
//int.TryParse(Console.ReadLine(), out n);
//Console.WriteLine(EgeFunc(n));

//long EgeFunc20(int n)
//{
//    if (n <= 2) return 2;
//    else return EgeFunc20(n - 1) + 2 * EgeFunc20(n - 2);
//}
//Console.WriteLine("введите n: ");
//int n;
//int.TryParse(Console.ReadLine(), out n);
//Console.WriteLine(EgeFunc20(n));

//long EgeFunc2(int n)
//{
//    if (n > 1 && n % 2 == 0) return n / 2 + EgeFunc2(n - 1) + 2;
//    else if (n > 1 && n % 2 != 0) return EgeFunc2(n - 1) + 3 * n * n;
//    else return 0;
//}

//Console.WriteLine("введите n: ");
//int n;
//int.TryParse(Console.ReadLine(), out n);
//Console.WriteLine(EgeFunc2(n));


//void Recur1(int n)
//{
//    if (n == -1) return;
//    else {
//        Recur1(n - 1);
//        Console.Write(n+" ");
//            };
//}
//Recur1(10);

//Console.WriteLine( (int)'а');//1072
//Console.WriteLine((int)'я');//1103

//void Alphabet(int n)
//{
//    if (n == 1071) return;
//    else {
//        Alphabet(n - 1);
//        Console.Write((char)n+" ");
//            };
//}
//Alphabet(1103);

//void Recur2(int n,int m)
//{
//    if (m == n) Console.Write(m + " ");

//    else if (n < m)
//    {
//        {
//            Console.Write(m + " ");
//            Recur2(n, m - 1);
//        };
//    }
//    else
//    { 
        
//            Recur2(n-1, m);
//            Console.Write(n + " ");
       
//    }
//}
//Console.WriteLine("Введите первое число:");
//int n;
//int.TryParse(Console.ReadLine(),out n);
//Console.WriteLine("Введите второе число:");
//int m;
//int.TryParse(Console.ReadLine(), out m);
//Recur2(n,m);    

//int Sum(int n)
//{
//    if (n>0&&n<10) return n;
//    else return n % 10 + Sum(n / 10);
//}
//Console.WriteLine(Sum(123));

