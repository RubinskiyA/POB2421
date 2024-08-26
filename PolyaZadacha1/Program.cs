using PolyaZadacha1;

Building building = new Building();

// Ввод параметров постройки
building.Type = "Двухэтажный коттедж";
building.FloorHeight = 3.0;
building.RoofHeight = 1.0;
building.Length = 10.0;
building.Width = 8.0;
building.FloorCount = 2;
building.WindowCount = 5;
building.RoomCount = 10;

// Расчет и вывод характеристик постройки
Console.WriteLine($"Высота здания: {building.CalculateBuildingHeight()}м.");
Console.WriteLine($"Площадь здания: {building.CalculateBuildingArea()}кв.м.");
Console.WriteLine($"Общее количество проемов:{building.CalculateTotalOpenings()}");