using OOP_6_Nasledovanie_;

//Person person = new Person("Tom");
//person.Print();

//Employee employee = new Employee("Sam", "Mircosoft");

//employee.Print();


//person = new Employee("Bob","Google" );
//person.Print();

//Client client = new Client("Nicolas", "Standart");
//Console.WriteLine(client);

////Upcasting
//Person bill =  new Employee("John", "Beeline");
//Console.WriteLine(bill.Name);

//object client1 = new Client("Nina", "Moscow");

////Downcasting

//Employee emp = (Employee)bill;
//emp.Print();

//object obj = new Employee("Boris", "Cifra");


//способы преобразования

Employee person1 = new Employee("Tom","MTS");
if (person1 is Person)
{
    Person emp1 = person1 as Person;
    //emp1.Company = "Apple";
    Console.WriteLine(emp1?.Name);
}
else
{
    Console.WriteLine("Object ne sozdan");
}
