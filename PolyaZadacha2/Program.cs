using PolyaZadacha2;

Operations operations = new Operations();
operations.Print();
do
{
    Console.WriteLine("Выберите операцию для строк: \n1 - добавить строку в список. \n2 - удалить строку\n3 - найти строку по значению\n4 - очистка списка строк\n5 - отсортировать список по алфавитному порядку\n6 - искать все индексы вхождения");
    int oper;
    int.TryParse(Console.ReadLine(), out oper);
    switch (oper)
    {
        case 1: operations.Add(); break;
        case 2: operations.Delete(); break;
        case 3: operations.Find(); break;
        case 4: operations.Clear(); break;
        case 5: operations.Sort(); break;
        case 6: operations.FindAllValues(); break;
        default: break;
    }
}
while (true);