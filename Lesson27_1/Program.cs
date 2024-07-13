Console.WriteLine("Укажите количество рублей: ");
decimal rubles=decimal.Parse(Console.ReadLine());
decimal rublesToTenge =Converter.ToTenge(rubles);
Console.WriteLine($"В тенге: {rublesToTenge}");
decimal rublesToDollars=Converter.ToDollars(rubles);
Console.WriteLine($"В долларах: {rublesToDollars}");
decimal rublesToEuros=Converter.ToEuros(rubles);
Console.WriteLine($"В евро: {rublesToEuros}");
decimal rublesToZlotiy=Converter.ToZlotiy(rubles);
Console.WriteLine($"В злотых: {rublesToZlotiy}");
decimal rublesToYuans=Converter.ToYuans(rubles);
Console.WriteLine($"В юанях: {rublesToYuans}");
decimal rublesToRupees=Converter.ToRupees(rubles);
Console.WriteLine($"В рупии: {rublesToRupees}");


public class Converter
{
    public static decimal ToTenge(decimal rubles)
    {
        return rubles * 5.23m;
    }
    public static decimal ToDollars(decimal rubles)
    {
        return rubles * 0.013m;
    }
    public static decimal ToEuros(decimal rubles)
    {
        return rubles * 0.0115m;
    }
    public static decimal ToZlotiy(decimal rubles)
    {
        return rubles * 0.053m;
    }
    public static decimal ToYuans(decimal rubles)
    {
        return rubles * 0.083m;
    }
    public static decimal ToRupees(decimal rubles)
    {
        return rubles * 1.0m;
    }
}



