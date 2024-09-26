using OOP_9Hw;

Liquid water = new Liquid("Вода", 1);
water.PrintInfo();
water.SetDensity(0.99);
water.PrintInfo();
Alcohol vine = new Alcohol("Вино", 0.98, 12);
vine.PrintInfo();
vine.SetDensity(0.97);
vine.SetStrength(15);
vine.PrintInfo();
Console.WriteLine();
Rectangle rectangle = new Rectangle(3, 5);
Console.WriteLine($"Площадь {rectangle.Area()}");
Console.WriteLine($"Периметр {rectangle.Perimeter()}");
