do
{
    Console.Write("Введите путь к файлу или папке: ");
    string path = Console.ReadLine();
    if (File.Exists(path)) { File.Delete(path); Console.WriteLine("Файл удален.");}
    else if (Directory.Exists(path)) { Directory.Delete(path); Console.WriteLine("Папка удалена."); }
    else Console.WriteLine("Файла или директории не существует.");
}
while (true);