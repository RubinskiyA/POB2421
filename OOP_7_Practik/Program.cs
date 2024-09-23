using OOP_7_Practik;

Passanger passanger = new Passanger() { FIO = "Зубенко Михайл Петрович", Passport = "5164641" };
Train train = new Train() { Number = 4365, Destination = "Kaliningrad", TimeArrival = TimeOnly.Parse("11:05"), TimeDeparture = TimeOnly.Parse("18:55") };
Cashier cashier = new Cashier() { FIO = "Кривая Юлия Ахматовна" };
Reciept reciept = new Reciept() { Number = 22, Amount = 5000 };
Order order = new Order(passanger, train, cashier, reciept, DateTime.Parse("2024.10.11 10:22"));
Console.WriteLine(order);