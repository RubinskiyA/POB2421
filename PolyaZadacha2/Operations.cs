namespace PolyaZadacha2
{
    internal class Operations
    {
        public List<string>? ListString { get; set; } = new();

        public Operations()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Введите " + (i + 1) + " строку: ");
                ListString.Add(Console.ReadLine()!);
            }
        }
        public void Print()
        {
            for (int i = 0; i < 3; i++)
            {
                ListString.ForEach(Console.WriteLine);
            }
        }
    }
}
