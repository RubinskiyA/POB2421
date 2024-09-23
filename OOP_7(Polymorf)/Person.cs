namespace OOP_7_Polymorf_
{
    internal class Person
    {
        public string? FIO { get; set; }
        public DateOnly? DateBirth { get; set; }
        public string? Phone { get; set; }

        public Person(string? fIO, DateOnly? dateBirth, string? phone)
        {
            FIO = fIO;
            DateBirth = dateBirth;
            Phone = phone;
        }

        public virtual void TakeBook(int n) { }
        public virtual void TakeBook(params string[] books) { }
        public virtual void TakeBook(params Book[] books) { }
    }
}
