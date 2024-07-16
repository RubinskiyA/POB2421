//Console.WriteLine("Введите имя файла замены: ");
//string fileName = Console.ReadLine();
//FileInfo fileInfo = new FileInfo(fileName);
//if (fileInfo.Exists)
//{
//    Console.WriteLine("Введите имя файла оригинала: ");
//    string fileNameReplace = Console.ReadLine();
//    fileInfo.Replace(fileNameReplace, "Arch."+fileInfo.Name);
//}

//-----------------------------------------
//using System.Collections.Concurrent;

//Console.WriteLine("Введите путь к папке:");
//string folderPath = Console.ReadLine();
//DirectoryInfo dir = new DirectoryInfo(folderPath);
//long max = 0;
//string maxFile = string.Empty;
//foreach (FileInfo file in dir.GetFiles())
//{
//    if (file.Length > max)
//    {
//        max = file.Length;
//        maxFile = file.Name;
//    }
//}
//Console.WriteLine(maxFile + " " + max);
//Console.WriteLine("Количество файлов в папке: " + dir.GetFiles().Length);

//for (int i = 0; i < dir.GetFiles().Length - 1; i++)
//{
//    for (int j = i + 1; j < dir.GetFiles().Length; j++)
//    {
//        string txt1 = File.ReadAllText(dir.GetFiles()[i].Name);
//        string txt2 = File.ReadAllText(dir.GetFiles()[j].Name);
//        if (txt1.Equals(txt2))
//        {
//            Console.WriteLine(dir.GetFiles()[i].Name + " & " + dir.GetFiles()[j].Name + " дубликаты");
//        }
//    }
//}


//---------------------------------------------------

//Console.WriteLine("Введите путь к папке:");
//string folderPath = Console.ReadLine();
//DirectoryInfo dir = new DirectoryInfo(folderPath);
//Console.WriteLine("Введите количество дней изменения: ");
//int days = int.Parse(Console.ReadLine());
//if (dir.Exists)
//{
//    foreach (FileInfo file in dir.GetFiles())
//    {
//        if ((DateTime.Now - file.LastWriteTime).Days < days)
//        {
//            Console.WriteLine(file.Name);
//        }
//    }
//}

//do
//{
//    Console.Clear();
//    Console.WriteLine("1 - создать файл.\n" +
//        "2 - считать содержимое файла\n" +
//        "3 - удалить файл\n"+
//        "4 - создать директорию\n"+
//        "5 - удалить директорию\n"+
//        "6 - выход\n" +
//        "Выберите действие: ") ;
//    int n = int.Parse(Console.ReadLine());
//    switch (n)
//    {
//        case 1: 
//            {
//                Console.Write("Введите название файла: ");
//                string fileName = Console.ReadLine();
//                CreateFile(fileName);
//            } 
//            break ;
//        case 2: 
//            {
//                Console.Write("Введите название файла: ");
//                string fileName = Console.ReadLine();
//                Console.WriteLine(ReadFile(fileName));

//            } 
//            break ;
//        case 3: 
//            {
//                Console.Write("Введите название файла: ");
//                string fileName = Console.ReadLine();
//                DelFile(fileName);
//            } 
//            break ;
//        case 4: 
//            {
//                Console.Write("Введите название директории: ");
//                string dirName = Console.ReadLine();
//                CreateDir(dirName);
//            }
//            break;
//        case 5:
//            {
//                Console.Write("Введите название директории: ");
//                string dirName = Console.ReadLine();
//                DelDir(dirName);
//            }
//            break ;
//        case 6: Environment.Exit(0);break;
//        default:break;
//    }
//    Console.ReadKey();
//}
//while (true);

//void CreateFile(string fileName)
//{
//    FileInfo fileInfo = new FileInfo(fileName);
//    if (!fileInfo.Exists) fileInfo.Create();
//    else Console.WriteLine("Файл существует.");

//}

//string ReadFile(string fileName)
//{
//    return File.ReadAllText(fileName);
//}
//void DelFile(string fileName)
//{
//    if (File.Exists(fileName)) File.Delete(fileName);
//    else Console.WriteLine("Файл не существует.");
//}
//void CreateDir(string dirName)
//{
//    DirectoryInfo dir = new DirectoryInfo(dirName);
//    if (!dir.Exists) dir.Create();
//    else Console.WriteLine("Директория существует. Введите новое название: ");
//}
//void DelDir(string dirName)
//{
//    DirectoryInfo dir = new DirectoryInfo(dirName);
//    if (dir.Exists) dir.Delete();
//    else Console.WriteLine("Директория не существует.");
//}

//bool CreateDirBool(string dirName)
//{
//    DirectoryInfo dir = new DirectoryInfo(dirName);
//    if (!dir.Exists) {dir.Create(); return true;}
//    else Console.WriteLine("Директория существует. Введите новое название: ");
//    return false;
//}
//string dirName = "";
//do
//{
//    Console.WriteLine("Введите название новой директории: ");
//    dirName = Console.ReadLine();

//}
//while (CreateDirBool(dirName)==false);

//Console.WriteLine("Введите путь к папке: ");
//string dirPath = Console.ReadLine();
//DirectoryInfo dir = new DirectoryInfo(dirPath);
//if (dir.Exists) Console.Write(dir.LastWriteTime + " " + dir.Attributes);


