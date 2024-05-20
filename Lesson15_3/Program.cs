//Напишите программу, которая запрашивает у пользователя 10 целых
//чисел и сохраняет их в массиве. Затем программа сортирует массив по
//возрастанию и выводит отсортированный массив на экран. Далее
//программа запрашивает у пользователя число и находит его индекс в
//массиве. Если число не найдено, программа выводит сообщение об
//ошибке.

int[] mas  = new int[10];
for (int i = 0; i < mas.Length; i++)
{
    Console.Write($"Введите {i+1} элемент массива из целых чисел: ");
    mas[i] = int.Parse(Console.ReadLine());
}
Array.Sort( mas );
Console.WriteLine();
for (int i = 0; i < mas.Length; i++)
{
    Console.Write(mas[i] + " ");
}
Console.WriteLine();
Console.WriteLine("Введите число для поиска: ");
int num=int.Parse(Console.ReadLine());
if (Array.BinarySearch(mas, num)>=0)
{
    Console.WriteLine($"Индекс нужного числа: {Array.BinarySearch(mas, num)}");
}
else Console.WriteLine("Ошибка. Число не найдено.");