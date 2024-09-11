using OOP4_1_svoistva_;

RocketEngine rocketEngine = new RocketEngine
{
    TypeFuel = TypeOfFuel.Жидкое,
    Volume1 = 10,
    Volume2 = 20,
    Volume3 = 30,
    Speed1=20,
    Speed2=40,
    Speed3 = 60,
    Time1 = 10,
    Time2= 20,
    Time3= 30
};
Console.WriteLine(rocketEngine.SpeedTime(5));
Console.WriteLine(rocketEngine.SpeedTime(15));
Console.WriteLine(rocketEngine.SpeedTime(25));

Console.WriteLine(rocketEngine.Time());

if (rocketEngine.NumberStep(80) != -1) Console.WriteLine(rocketEngine.NumberStep(80));
else Console.WriteLine($"Орбитальный полет, время полета: {80-rocketEngine.Time()}");