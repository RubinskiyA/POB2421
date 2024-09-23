namespace OOP_7_Polymorf_
{
    internal class Reader : Person
    {


        private long readerId;
        public long ReaderId
        {
            get { return readerId; }
            set { if (value > 0) readerId = value; }
        }
        public string? Faculty { get; set; }
        public Reader(string? fIO, DateOnly? dateBirth, string? phone, long n, string faculty) : base(fIO, dateBirth, phone)
        {
            ReaderId = n;
            Faculty = faculty;
        }

        public override void TakeBook(int n)
        {
            Console.WriteLine($"{FIO} взял {n} книг ");
        }

        public override void TakeBook(params string[] books)
        {

            Console.WriteLine($"{FIO} взял книги: ");
            foreach (var book in books)
            {
                Console.Write(book + ", ");
            }

        }

        public override void TakeBook(params Book[] books)
        {
            Console.WriteLine();
            Console.WriteLine($"{FIO} взял книги: ");
            foreach (var book in books)
            {
                Console.Write(book.Title + ", ");
            }
        }
    }
}
