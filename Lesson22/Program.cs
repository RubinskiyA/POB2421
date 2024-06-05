//using System.Threading.Channels;

//string name = Console.ReadLine();
//void Hello(string name)
//{
//    Console.WriteLine($"Привет, {name}!");
//}

//Hello(name);

//int n=int.Parse(Console.ReadLine());
//int Multi(int n)
//{
//    int result = 1;
//    if (n==0) return 0;
//    else if (n > 0)
//    {
//        for (int i = 1; i <= n; i++)
//        {
//            result *= i;
//        }
//    Console.WriteLine(result);
//    return result;  
//    }
//    else throw new Exception("Ошибка");
//}

//int MultiMod(int n)
//{
//    if (n < 10000)
//    {
//        int r = Multi(n);
//        return r;
//        Console.WriteLine(r);
//    }
//    else throw new Exception("Ошибка переполнения памяти");
//}

//Multi(n);
using System.Collections.Concurrent;
using System.IO;
//string path = "C:/Users/c7pc10/Desktop/test/read.txt";
////string content = File.ReadAllText(path);


//////Console.WriteLine(content);
//////string[] lines = File.ReadAllLines(path);
//////foreach (string line in lines)
//////{
//////    Console.WriteLine(line);
//////    Thread.Sleep(500);

//////}
////string[] lines = { "Hello world sosiski!" ,
////                   "я выиграл"};
////File.AppendAllLines(path, lines);


//string destinationPath = "C:/Users/c7pc10/Desktop/read.txt";

////File.Move(soursePath, destinationPath);
////File.Delete(path);
//string path = "C:/Users/c7pc10/Desktop/test/test.txt";
////Directory.Delete(path, true);
//if (File.Exists(path))
//   {
//    Console.WriteLine("FIle exist");
//    }
//else Console.WriteLine("Not exist");

//string path = "C:/Users/c7pc10/Desktop/test/test.txt";
////string content = "Hello world sosiski!";

////string existFile=File.ReadAllText(path);
////existFile= existFile +"\n"+ content;
////File.WriteAllText(path, existFile);
//string destinationPath = "C:/Users/c7pc10/Desktop/test.txt";
//string content =File.ReadAllText(path);
//File.Move (path, destinationPath);
//File.WriteAllText(path, content);

Console.WriteLine("Введите название файла: ");
string nameFile = Console.ReadLine();
string path = "C:/Users/c7pc10/Desktop/test";
path+="/" + nameFile;
if (File.Exists(path))
{
    Console.WriteLine("Действительно удалить файл?(y-да,n-нет)");
    string answer = Console.ReadLine();
   
    switch (answer)
    {
        case "y":
            {
                File.Delete(path);
                Console.WriteLine("Файл успешно удален.");break;
            }
        case "n": Console.WriteLine("Не удаляю =)");break;
        default: Console.WriteLine("Для ввода доступны только y или n!"); break;
    }
    
            //if (answer == "y")
            //{
            //    File.Delete(path);
            //    Console.WriteLine("Файл успешно удален.");
            //}
            //else if (answer=="n") Console.WriteLine("Не удаляю =)");
            //else 
            //{
            //    Console.WriteLine("Для ввода доступны только y или n!");
            //    answer = Console.ReadLine();
            //}
    }
else
{
    Console.WriteLine("Файл не найден.");
}

