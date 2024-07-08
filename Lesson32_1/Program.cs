using Lesson32_1;

NumberGenerator numberGenerator = new NumberGenerator();
Console.WriteLine(numberGenerator.GetInteger());
Console.WriteLine(numberGenerator.GetDouble().ToString("f2"));
Console.WriteLine(numberGenerator.GetBool());
Console.WriteLine(numberGenerator.GetString());

