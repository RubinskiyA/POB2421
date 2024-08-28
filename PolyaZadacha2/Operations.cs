namespace PolyaZadacha2
{
    internal class Operations
    {
        public List<string>? ListString { get; set; } = new();

        public Operations()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Введите " + (i + 1) + " строку: ");
                ListString.Add(Console.ReadLine()!);
            }
        }
        public void Print()
        {
            if (ListString.Count == 0)
            {
                Console.WriteLine("Список пуст");
            }
            else
            {
                Console.WriteLine("Список доступных строк: ");
                for (int i = 0; i < ListString.Count; i++)
                {
                    Console.WriteLine(i + " " + ListString[i]);
                }
            }
        }
        public void Delete()
        {
            if (ListString.Count != 0)
            {
                try
                {
                    Console.WriteLine("Введите индекс для удаления строки: ");
                    int ind;
                    int.TryParse(Console.ReadLine(), out ind);
                    ListString.RemoveAt(ind);
                    Print();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public void Add()
        {
            Console.WriteLine("Введите содержимое новой строки: ");
            string newString = Console.ReadLine()!;
            ListString.Add(newString);
            Print();
        }
        public void Clear()
        {
            Console.WriteLine("Вы уверены, что хотите очистить список?(да/нет): ");
            string answer = Console.ReadLine()!;
            if (answer == "да"||answer=="yes") ListString.Clear();
            Print();
        }
        public void Find()
        {
            Console.WriteLine("Введите значение для поиска: ");
            string answer = Console.ReadLine()!;
            if (ListString.IndexOf(answer) != -1) Console.WriteLine("Элемент найдет с индексом " + ListString.IndexOf(answer));
            else Console.WriteLine("Элемент не найден");
        }
        public void Sort()
        {
            ListString.Sort();
            Print();
        }
        public void FindAllValues()
        {
            Console.WriteLine("Введите значение для поиска: ");
            string value= Console.ReadLine()!;
            int count = 0;
            int[] mas= new int[count];
            for (int i = 0;i<ListString.Count;i++)
            {
                if (ListString[i].Equals(value))
                {
                    count++;
                    Array.Resize(ref mas, count);
                    mas[count - 1] = i;
                }
            }
            if (count == 0) Console.WriteLine("Элемент не найден.");
            else
            {
                Console.WriteLine("Элементы найдены под индексами: ");
                for (int i = 0; i < count; i++)
                {
                    Console.Write(mas[i] + " ");
                }
                Console.WriteLine();
            }

        }

    }
}
