Console.WriteLine("Введите путь к папке: ");
string path = Console.ReadLine();
Console.WriteLine("Введите название файла: ");
string name = Console.ReadLine();
using(FileStream fs= File.Create(path+"/"+name))
    Console.WriteLine("Файл успешно создан.");
Console.WriteLine("Введите текст: ");
string content = Console.ReadLine();
File.WriteAllText(path + "/" + name,content) ;
Console.WriteLine("Файл успешно записан.");
using (FileStream fs = File.Create(path + "/Файл1.txt")) ;
using (FileStream fs = File.Create(path + "/Файл2.txt")) ;
Console.Write(File.ReadAllText(path + "/" + name));
