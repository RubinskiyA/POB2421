//double Division(double a, double b)
//{
//    if (b != 0) return a / b;
//    else throw new DivideByZeroException("Делить на ноль нельзя!");
//}
//do
//{
//    //FileStream fs = null;
//    try
//    {
//        Console.WriteLine("Введите первое положительное число: ");
//        int n = int.Parse(Console.ReadLine());
//        if (n < 0) throw new Exception("Введено отрицательное число");
//        Console.WriteLine("Введите второе положительное число: ");
//        int m = int.Parse(Console.ReadLine());
//        if (m < 0) throw new Exception("Введено отрицательное число");
//        Console.WriteLine(Division(n, m));
//        //fs = new FileStream("text.txt", FileMode.Open);
//    }
//    catch (FormatException e)
//    {
//        Console.WriteLine(e.Message);
//    }
//    catch (ArithmeticException e)
//    {
//        Console.WriteLine(e.Message);
//    }
//    catch (IndexOutOfRangeException e)
//    {
//        Console.WriteLine(e.Message);
//    }
//    catch (Exception e)
//    {
//        Console.WriteLine(e.Message);
//    }
//    //finally
//    //{
//    //    if (fs != null) fs.Close();
//    //}
//}
//while (true);
//using System.Text;

//Console.WriteLine("Введите путь к файлу: ");
//string filePath = Console.ReadLine();
//if (filePath == null) throw new Exception("Вы не ввели путь!");
//try
//{
//    //Console.WriteLine(File.ReadAllText(filePath));
////или так:
//    FileInfo fileInfo = new FileInfo(filePath);
//    using (FileStream fs = fileInfo.OpenRead())
//    {
//        byte[] b = new byte[1024];
//        UTF8Encoding temp = new UTF8Encoding(true);
//        while (fs.Read(b, 0, b.Length) > 0)
//        {
//            Console.WriteLine(temp.GetString(b));
//        }
//    }


//}
//catch(IOException e)
//{
//    Console.WriteLine(e.Message);
//}
//---------------------------------
//do
//{
//    try
//    {
//    Console.Write("Введите положительное число для вычисления его корня: ");
//    int m = int.Parse(Console.ReadLine());
//    if (m < 0) throw new Exception("Введено отрицательное число!");
//        Console.WriteLine(Math.Sqrt(m));
//    }
//    catch (Exception e)
//    {
//        Console.WriteLine(e.Message);
//    }
//}
//while (true);

//--------------------------------
//try
//{
//    Console.WriteLine("Введите стоку: ");
//    int a = int.Parse( Console.ReadLine());
//    Console.WriteLine(a);
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}


//try
//{
//    Console.WriteLine("Введите путь к файлу из которого будет копирование: ");
//    string file1Path = Console.ReadLine();
//    Console.WriteLine("Введите путь к файлу в которое будет копирование: ");
//    string file2Path = Console.ReadLine();
//    await File.WriteAllTextAsync(file2Path,await File.ReadAllTextAsync(file1Path));
//}
//catch (IOException e)
//{
//    Console.WriteLine(e.Message);
//}
string current = Environment.CurrentDirectory;
do
{
    Console.Write(current+'>');
    string command= Console.ReadLine();
    string[] commands = command.Split(" ");
    switch (commands[0])
    {
        case "dir":
            {
                DirectoryInfo d = new DirectoryInfo(current);
                foreach (var s in d.GetFileSystemInfos())
                {
                    Console.WriteLine(s.Name);
                }
            }
            break;
        case "cd":
            {
                switch (commands[1])
                {
                    case "/":
                        {
                            DirectoryInfo dirs = new DirectoryInfo(current);
                            current=dirs.Root.FullName;
                        }
                        break;
                    case "..":
                        {
                            try
                            {
                                DirectoryInfo dirs = new DirectoryInfo(current);
                                if ((dirs.Parent!.FullName) != null) current = dirs.Parent!.FullName;
                                else throw new Exception("Выше не куда!");
                                
                            }
                            catch(Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                        }
                        break;
                    default:
                        {
                            if (Directory.Exists(commands[1])) current = commands[1];
                            else throw new Exception("Нет такого каталога!");
                        }
                        break ;
                }
            }
            break;
    }

} while (true);