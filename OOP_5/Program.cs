using OOP_5;

Point p1 = new Point(4, 8);
Point p2 = new Point(3, -9);
Point p3 = new Point(11, 2);

Console.Write("Количество экземпляров: " + Point.getPoints());
Console.Write("Расстояние между точками: "+Point.LengthPoint(p1,p2));
Console.Write("Расстояние между точками: " + Point.LengthPoint(p2, p3));
Console.Write("Расстояние между точками: " + Point.LengthPoint(p1, p3));




