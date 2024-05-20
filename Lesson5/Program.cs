//Тема 5 Урок 1 (Перевод миллиметров в сантиметры, метры, километры, мили и ярды)
Console.Write("Введите количество миллиметров:");
const double MilliToSanti = 10;
const double MilliToMetr = 1000;
const double MilliToKillo = 1000000;
const double MilliToMile = 1609344;
const double MilliToYards = 0.0010936100483;
double millimetrs = double.Parse(Console.ReadLine());
double santimetrs = millimetrs / MilliToSanti;
double meters = millimetrs / MilliToMetr;
double killometers = millimetrs / MilliToKillo;
double mile = millimetrs / MilliToMile;
double yards = millimetrs * MilliToYards;
Console.WriteLine($"Сантиметров:{santimetrs}\nМетров:{meters}\nКилометров:{killometers}\nМиль:{mile}\nЯрдов:{yards}");

