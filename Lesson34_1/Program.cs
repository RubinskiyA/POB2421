DayWeek day = DayWeek.saturday;
DayWeek NextDay(DayWeek day)
{
    return (day < DayWeek.saturday) ? ++day : DayWeek.sunday;
}
Console.WriteLine(NextDay(DayWeek.monday));
//foreach (string str in Enum.GetNames(typeof(Discount))) Console.WriteLine(str);
//Console.Write("Введите число от 1 до 5: ");
//int i;
//int.TryParse(Console.ReadLine(),out i);
//if (i > 0 && i < 6)
//{
//    CommodityType commodity = (CommodityType)Enum.GetValues(typeof(CommodityType)).GetValue(i - 1)!;
//    TransportType transport = TransportType.Semitrailer;
//    switch (commodity)
//    {
//        case CommodityType.FrozenFood:
//            transport = TransportType.Refregirator; break;
//        case CommodityType.food:
//            transport = TransportType.Semitrailer; break;
//        case CommodityType.DomesticChimestry:
//            transport = TransportType.Coupling; break;
//        case CommodityType.BuildingMaterials:
//            transport = TransportType.OpenSideTruck; break;
//        case CommodityType.Petrol:
//            transport = TransportType.FuelTrack; break;

//    }
//    Console.WriteLine($"Для товара - {commodity} необходим транспорт {transport}");
//}
//else Console.WriteLine("Ошибка ввода!");

//CompareTo - сравнивает текущий экземпляр с заданным объектом, и возвращает значение : <0 - если значение текущего экзепляра меньше заданного, 0 - если равно заданному, >0 если больше.
//GetName - выводит имя константы в указанном перечислении, имеющем заданное значение
//GetNames - выводит массив констант в перечислении
//GetValues - выводит массив значений констант в заданном перечислении.
//IsDefined - возвращает признак начиния константы с указанным значением в указанном перечислении
//Parse - преобразует строковое значение в перечиляемый тип
//ToString - преобразует в строку
Console.Write("Введите название планеты на английском языке: ");
string name = Console.ReadLine()!;
if (!Enum.IsDefined(typeof(DistanceSun), name))
{
    Console.WriteLine($"Значения {name} нет в перечислении");
}
foreach(DistanceSun item in Enum.GetValues(typeof(DistanceSun)))
{
    Console.WriteLine("{0,-10}{1,-10}{2,-10}", Enum.Format(typeof(DistanceSun), item, "G"), Enum.Format(typeof(DistanceSun), item, "D"), Enum.Format(typeof(DistanceSun), item, "X"));
}
foreach(string str in Enum.GetNames(typeof(DistanceSun)))
{
    Console.WriteLine(str);
}

enum EnumName { elem1, elem2, elem3,elem4 }
enum DayWeek { monday, tuesday,wednesday,thursday , friday, saturday, sunday }
enum Discount { Default, Incentive=2,Patron=5,VIP=15}
enum CommodityType { FrozenFood, food,DomesticChimestry,BuildingMaterials,Petrol}
enum TransportType { Semitrailer, Coupling,Refregirator,OpenSideTruck, FuelTrack}
enum DistanceSun: ulong
{
    sum=0,
    Mercury=57900000,
    Venus=108200000,
    Earth=149600000,
    Mars=227900000,
    Jupiter=778300000,
    Saturn=1427000000,
    Uran=28700000000,
    Neptune=4496000000,
    Pluto=5946000000
}
