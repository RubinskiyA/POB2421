using OOP_6_Praktic_;

List<Student> students = new List<Student>();
students.Add(new Student() { FirstName = "Ivan", LastName = "Ivanov", AverageMark = 5, Group="POB2255"});
students.Add(new Aspirant() { FirstName = "Petr", LastName = "Petrov", AverageMark = 2, Group = "POB2287" });
students.Add(new Student() { FirstName = "Kate", LastName = "Katerinova", AverageMark = 4.5, Group = "POB2223" });
students.Add(new Aspirant() { FirstName = "Vasilii", LastName = "Vasiliev", AverageMark = 5, Group = "POB2215" });

foreach (var student in students)
{
    if (student is Aspirant) 
    { 
    Console.WriteLine(((Aspirant)student).getScholarShip()); 
    }
    else Console.WriteLine(student.getScholarShip());

}

