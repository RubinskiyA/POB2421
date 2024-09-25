using OOP_8_Peregruzka;

Complex complex1 = new Complex(5, -8);
Complex complex2 = new Complex(11, 3);
Console.WriteLine(complex1);
Console.WriteLine(complex2);

Complex z=complex1+complex2;
Console.WriteLine(z);
Complex z2 = complex1 * complex2;
Console.WriteLine(z2);
Complex z3 = -complex1;
Console.WriteLine(z3);

int[,] a = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
int[,] b = new int[3, 3] { { 4, 5, 2 }, { 9, 2, 6 }, { 1,8,4 } };

int[,] c = a + b;

