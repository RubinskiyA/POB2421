using OOP_6HW;

int[] numbers = { 5, 10, 15, 20, 25 };


double average = Massive.CalculateAverage(numbers);
Console.WriteLine($"Среднее значение: {average}");

char[] chars = { 'a', 'b', 'c', 'd', 'e', 'f' };

Console.WriteLine("Исходный массив: " + new string(chars));
Massive.ReverseMas(chars);
Console.WriteLine("Измененный массив: " + new string(chars));