using PolyaKlassa;

Console.WriteLine("Введите ФИО: ");
string fio = Console.ReadLine()!;
Console.WriteLine("Введите возвраст: ");
int age;
int.TryParse(Console.ReadLine()!, out age);
Console.WriteLine("Введите зарплату: ");
double salary;
double.TryParse(Console.ReadLine()!, out salary);
Employee employee1 = new Employee() { Age = age, Name = fio, Salary = salary };
Employee.count++;
Console.WriteLine(employee1.Name + " " + employee1.Age + " " + employee1.Salary + " " + Employee.count);
Employee employee2 = new Employee() { Age = age, Name = fio, Salary = salary };
Employee.count++;
Console.WriteLine(employee2.Name + " " + employee2.Age + " " + employee2.Salary + " " + Employee.count);