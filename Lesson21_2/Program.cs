Console.WriteLine("Введите путь к файлу: ");
string path = Console.ReadLine();
FileInfo fileInfo = new FileInfo(path);
if (fileInfo.Exists) 
{ 
    Console.WriteLine("Размер в байтах "+fileInfo.Length);
    Console.WriteLine("Дата изменения "+fileInfo.LastWriteTime);
    Console.WriteLine("Расширение "+fileInfo.Extension);
}
else
{
    Console.WriteLine("Файл не найден.");
}