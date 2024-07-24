using System.Reflection.Metadata;

List<Contact> contacts=new List<Contact> ();
do
{
    Console.Clear();
    Console.WriteLine("1 - Добавить новый контакт.\n2 - Удалить контакт по имени.\n3 - Найти по имени или номеру.\n");
    foreach(Contact contact in contacts)
    {
        Console.WriteLine(contact.name+" "+contact.phone);
        Console.WriteLine();
    }
    int n; 
    int.TryParse(Console.ReadLine(), out n);
    switch (n)
    {
        case 1: 
            {
                Console.WriteLine("Введите имя нового контакта: ");
                string name = Console.ReadLine();
                Console.WriteLine("Введите телефон нового контакта: ");
                string phone = Console.ReadLine();
                Contact contact=new Contact(name,phone);
                contacts.Add(contact);

            } break;
        case 2:
            {
                Console.WriteLine("Введите имя контакта для удаления: ");
                string name = Console.ReadLine()!;  
                Contact contact=contacts.Find(x => x.name == name);
                contacts.Remove(contact);

            }
            break;
        case 3:
            {
                Console.WriteLine("Выберите способ поиска:1 - по имени.\n2 - по номеру телефона. ");
                int m;
                int.TryParse (Console.ReadLine(), out m);
                switch(m)
                {
                    case 1:
                        {
                            Console.WriteLine("Введите имя контакта для поиска: ");
                            string name = Console.ReadLine()!;
                            Contact contact = contacts.Find(x => x.name == name);
                            Console.WriteLine(" Искомый контакт: "+contact.name+" "+contact.phone);
                            Console.ReadKey();
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("Введите номер контакта для поиска: ");
                            string phone = Console.ReadLine()!;
                            Contact contact = contacts.Find(x => x.phone == phone);
                            Console.WriteLine(" Искомый контакт: " + contact.name + " " + contact.phone);
                            Console.ReadKey();

                        }
                        break;
                    default: break;
                }
            }
            break;
        default:

            break;
    }

}
while (true);
struct Contact
{
    public string name;
    public string phone;

    public Contact(string name, string phone)
    {
        this.name = name;
        this.phone = phone;
    }

}