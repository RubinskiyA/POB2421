//float d = 2.5f;
//int i = (int)d;

//Console.WriteLine(i);

//Console.WriteLine((double)5/9);



//string myPerson = ("Александр\nРубинский");
//Console.WriteLine(myPerson);


//string myString = "284";
//Console.WriteLine(int.Parse(myString));


using System.Diagnostics;

byte bt=byte.Parse(Console.ReadLine());
long freq = Stopwatch.Frequency;
Stopwatch stopwatch = new Stopwatch();
stopwatch.Start();
//int integer = (int)bt;
double doub = (double)bt;
stopwatch.Stop();
decimal sec = (decimal)stopwatch.ElapsedTicks/freq;
Console.WriteLine($"bt={bt} \n Частота таймера " + $"{freq} такт/с \n Время в тактах {stopwatch.ElapsedTicks} \n Время в секундах " + $"{sec}");
Console.WriteLine(doub);


