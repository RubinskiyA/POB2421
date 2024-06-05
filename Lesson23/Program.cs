
using System.Text;

//FileStream
//FileStream fs= null;
//try
//{
//    fs = new FileStream("file.txt", FileMode.Open);
//    byte[] b = new byte[1024];
//    UTF8Encoding temp = new UTF8Encoding(true);
//    while (fs.Read(b, 0, b.Length) > 0)
//    {
//        Console.WriteLine(temp.GetString(b));
//    }
//}
//catch(IOException e)
//{
//    Console.WriteLine(e.Message);
//}
//finally
//{
//    if (fs != null) fs.Close();
//}

//using (FileStream fs = new FileStream("file.txt", FileMode.Open))
//{
//    byte[] b = new byte[1024];
//    UTF8Encoding temp = new UTF8Encoding(true);
//    while (fs.Read(b, 0, b.Length) > 0)
//    {
//        Console.WriteLine(temp.GetString(b));
//    }
//}

//using(FileStream fs = new FileStream("newfile.txt", FileMode.Create))
//{
//    Console.Write("Введите текст: ");
//    string str=Console.ReadLine();
//    byte[] info = new UTF8Encoding(true).GetBytes(str);
//    fs.Write(info, 0, info.Length);
//}

//Console.Write("Введите текст: ");
//string str = Console.ReadLine();
//string path = @"C:\Users\c7pc10\source\repos\POB2421\Lesson23\bin\Debug\net8.0\newasync.txt";
//using (FileStream fstream = new FileStream(path, FileMode.OpenOrCreate))
//{
//    byte[] buffer = Encoding.Default.GetBytes(str);
//        await fstream.WriteAsync(buffer, 0, buffer.Length);
//}

//using(FileStream fstream=new FileStream(path, FileMode.Open))
//{
//    byte[] buffer =new byte[fstream.Length];
//    await fstream.ReadAsync(buffer, 0, buffer.Length);
//    string text = Encoding.Default.GetString(buffer);
//    Console.Write(text);
//}

// Произвольный доступ к файлам

//string path = "note.txt";
//string text = "Hello, world!";
//using (FileStream fstream = new FileStream(path, FileMode.OpenOrCreate))
//{
//    byte[] buffer = Encoding.Default.GetBytes(text);
//    await fstream.WriteAsync(buffer, 0, buffer.Length);
//}

//using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
//{
//    fs.Seek(0, SeekOrigin.Begin);
//    byte[] output= new byte[5];
//    await fs.ReadAsync(output, 0, output.Length);
//    Console.Write(Encoding.Default.GetString(output));
//}

//StreamReader & StreamWriter

//string path = "note.txt";
//string text = "Hello, world!";

//using(StreamWriter sw = new StreamWriter(path, false))
//{
//    await sw.WriteLineAsync(text);
//}

//using (StreamWriter sw = new StreamWriter(path, true))
//{
//    await sw.WriteAsync("and me");
//    await sw.WriteAsync("4/5");

//}
// using(StreamReader  sr = new StreamReader(path))
//{
//    string textRead= await sr.ReadToEndAsync();
//    Console.WriteLine(textRead);
//}

//using (StreamReader sr = new StreamReader(path))
//{
//   string line;
//    while ((line = await sr.ReadLineAsync()) != null) {
//        Console.WriteLine(line);
//    }
//}



//-------------------------------------------------
//Console.Write("Укажите название файла с расширением: ");
//string name = Console.ReadLine();
//FileInfo file = new FileInfo(name);
////file.Create();
//using (FileStream fs = file.Create())
//{
//    Console.Write("Укажите содержимое файла: ");
//string text = Console.ReadLine();
//    byte[] buffer = Encoding.Default.GetBytes(text);
//    await fs.WriteAsync(buffer, 0, buffer.Length);

//}

//-----------------------------------------------------
//Console.Write("Введите имя файла для чтения: ");
//string fileName = Console.ReadLine();
////using (StreamReader sr = new StreamReader(fileName))
////{
////    string textRead = await sr.ReadToEndAsync();
////    Console.WriteLine(textRead);
////}
//Console.WriteLine(await File.ReadAllTextAsync(fileName)); 

//--------------------------------------------------

//Console.Write("Введите название файла откуда копировать содержимое: ");
//string fileNameSource=Console.ReadLine();
//Console.Write("Введите название файла куда копировать содержимое: ");
//string fileNameDestin = Console.ReadLine();
//FileInfo info = new FileInfo(fileNameSource);
//if (info.Exists)
//{
//    info.CopyTo(fileNameDestin);
//}

//------------------------------------------
//Console.Write("Введите путь к папке: ");
//string path = Console.ReadLine();
//Console.Write("Введите расширение: ");
//string fileEtx= Console.ReadLine();
//DirectoryInfo dirInfo = new DirectoryInfo(path);
//foreach (FileInfo fileInfo in dirInfo.GetFiles())
//{
//    if(fileInfo.Extension==fileEtx) Console.WriteLine(fileInfo.Name);
//}

//---------------------------------------------------

Console.Write("Введите имя файла для удаления: ");
string fileName = Console.ReadLine();
FileInfo fileInfo = new FileInfo(fileName);
if (fileInfo.Exists)
{
    fileInfo.Delete();
}