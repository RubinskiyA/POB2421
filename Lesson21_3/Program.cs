string current = "";
    current=Directory.GetCurrentDirectory();
do
{
    Console.WriteLine("Текущая директория: "+current);
    Console.Write("Введите название папки для перехода(или /выход/ для завершения): ");
    string newPath = Console.ReadLine();
    if (newPath != "выход")
    {
        DirectoryInfo newDir = new DirectoryInfo(current + "/" + newPath);
        if ((!newDir.Exists))
        {
            newDir.Create();
            current = current + "/" + newPath;
        }
        else current = current + "/" + newPath;
    }
    else Environment.Exit(0);

}
while (true);