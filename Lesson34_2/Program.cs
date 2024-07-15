Student student = new Student();
Console.Write("Введите ФИО студента: ");
student.fio = Console.ReadLine()!;
Console.Write("Введите дату рождения студента: ");
student.birthDate = DateTime.Parse(Console.ReadLine()!);
Console.Write("Введите пол студента: ");
student.gender = (Gender)Enum.Parse(typeof(Gender), Console.ReadLine()!);
Console.Write("Введите курс : ");
student.kurs = int.Parse(Console.ReadLine()!);
Console.WriteLine("Студент " + student.fio + " пол: " + student.gender + " возраст: " + student.getVozrast());


enum Gender
{
    Мужской,
    Женский
}
struct Student
{
    public string fio;
    public DateTime birthDate;
    public Gender gender;
    public int kurs;
    public int getVozrast()
    {
        return Convert.ToInt32((DateTime.Today - birthDate).Days / 356.25);
    }
}