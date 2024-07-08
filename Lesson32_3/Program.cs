using Lesson32_3;

Console.Write("Введите размер массива: ");
int n;
int.TryParse(Console.ReadLine(), out n);
MasGenerate masGenerate = new MasGenerate(n);
masGenerate.IntGen(1,100);
masGenerate.strGen(10);
masGenerate.boolGen();