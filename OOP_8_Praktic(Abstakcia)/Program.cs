using OOP_8_Praktic_Abstakcia_;

Triangle triangle = new Triangle() { A = 5, B = 3, C = 4};
Console.WriteLine($"S={triangle.GetArea():f2} P={triangle.GetPerimeter():f2}");
Circle circle = new Circle() { R=10};
Console.WriteLine($"P={circle.GetPerimeter():f2} S={circle.GetArea():f2}");
