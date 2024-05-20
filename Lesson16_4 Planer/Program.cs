//Название проекта: Консольный планировщик задач.
//Цель проекта: Создание консольного приложения на C#, позволяющего
//пользователю добавлять, удалять, перезаписывать и выводить список
//задач с их параметрами.
int count = 0;
Object[,] tasks=new Object[0,0];
do
{
    Console.Clear();
    Console.ForegroundColor=ConsoleColor.Red;
    Console.WriteLine("         Меню\n" +
        "1 - Добавить задачу.\n" +
        "2 - Удалить задачу.\n" +
        "3 - Перезаписать задачу.\n" +
        "4 - Вывести список задач.\n" +
        "5 - Выход.");
    Console.ForegroundColor= ConsoleColor.White;
    Console.Write("Выберите пункт меню: ");
    int menu1=int.Parse(Console.ReadLine());
    switch (menu1)
    {
        case 1: 
            {
                count++;
                Object[,] temp = new Object[count,4];
                Array.Copy(tasks, temp, tasks.Length);
                Console.Write("Введите название задачи: ");
                temp[count-1,0]=Console.ReadLine();
                Console.Write("Введите дату задачи: ");
                temp[count - 1, 1] = Console.ReadLine();
                Console.Write("Введите время задачи: ");
                temp[count - 1, 2] = Console.ReadLine();
                Console.Write("Введите приоритет задачи: ");
                temp[count - 1, 3] =int.Parse(Console.ReadLine());
                tasks = new Object[count,4];
                Array.Copy(temp, tasks, temp.Length);
                
            } break;
        case 2:
            {
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine(i + 1 + ". " + tasks[i, 0] + " " + tasks[i, 1] + " " + tasks[i, 2] + " " + tasks[i, 3]);
                }
                Console.Write("Введите номер задачи для удаления: ");
                int k = int.Parse(Console.ReadLine());
                Object[,] temp = new Object[count - 1, 4];
                int size = 0;
                for (int i = 0; i < count; i++)
                {
                    if (i != k - 1)
                    {
                        temp[size, 0] = tasks[i, 0];
                        temp[size, 1] = tasks[i, 1];
                        temp[size, 2] = tasks[i, 2];
                        temp[size, 3] = tasks[i, 3];
                        size++;
                    }
                }

                count--;
                tasks = new Object[count, 4];
                Array.Copy(temp, tasks, tasks.Length);

            }
            break;
        case 3:
            {
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine(i + 1 + ". " + tasks[i, 0] + " " + tasks[i, 1] + " " + tasks[i, 2] + " " + tasks[i, 3]);
                }
                Console.Write("Введите номер задачи для удаления: ");
                int k = int.Parse(Console.ReadLine());
                Console.Write("Введите название задачи: ");
                tasks[k - 1, 0] = Console.ReadLine();
                Console.Write("Введите дату задачи: ");
                tasks[k - 1, 1] = Console.ReadLine();
                Console.Write("Введите время задачи: ");
                tasks[k - 1, 2] = Console.ReadLine();
                Console.Write("Введите приоритет задачи: ");
                tasks[k - 1, 3] = int.Parse(Console.ReadLine());
            }
            break;
        case 4: 
            { 
                Console.Clear();
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine(i+1+". "+tasks[i,0]+" " + tasks[i,1]+" " + tasks[i,2]+" " + tasks[i,3]);
                }
                Console.ReadKey();
            }
            break;
        case 5:break;
        default: Console.WriteLine("Нет такого пункта меню."); break;
    }
    if (menu1 == 5) break;
}
while (true);