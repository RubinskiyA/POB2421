using Lesson31;
using Lesson31._1;

Console.WriteLine("Введите размер массива: ");
int n;
int.TryParse(Console.ReadLine(), out n);
ArrayClass array = new ArrayClass(n);
array.Print();
Console.WriteLine($"Сумма массива: {array.Sum():f2}");
Console.WriteLine($"Максимальный элемент: {array.Max():f2}");
Console.WriteLine($"Минимальный элемент: {array.Min():f2}");
array.Sort();
array.Print();
Console.WriteLine($"Сумма: {ClassArray.Sum(array.getMas()):f2}");
