Console.Write("Введите число для конвертации:");
double number = double.Parse(Console.ReadLine());
string numString = number.ToString();
byte numByte = byte.Parse(numString);
nint numNint = (nint)numByte;
int numInt = (int)numNint;
long numLong = (long)numInt;
double numDouble = (double)numLong;

Console.WriteLine($"{number} {number.GetType()}");
Console.WriteLine($"{numString} {numString.GetType()}");
Console.WriteLine($"{numByte} {numByte.GetType()}");
Console.WriteLine($"{numNint} {numNint.GetType()}");
Console.WriteLine($"{numInt} {numInt.GetType()}");
Console.WriteLine($"{numLong} {numLong.GetType()}");
Console.WriteLine($"{numDouble} {numDouble.GetType()}");






