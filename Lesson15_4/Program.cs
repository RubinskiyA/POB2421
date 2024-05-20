//Создать 4 массива. Заполнить их случайными числами.
//Конечным результатом должен быть, выведенный на консоль, массив,
//хранящий следующее:
//Произведение средних арифметических (1и2) и (3и4) массивов
//поиндексно.
int[] mas1=new int[5];
int[] mas2=new int[5];
int[] mas3=new int[5];
int[] mas4=new int[5];
Random random = new Random();
for (int i = 0; i < mas1.Length; i++)
{
    mas1[i]= random.Next(1,20);
}
for (int i = 0; i < mas2.Length; i++)
{
    mas2[i] = random.Next(1, 20);
}
for (int i = 0; i < mas3.Length; i++)
{
    mas3[i] = random.Next(1, 20);
}
for (int i = 0; i < mas4.Length; i++)
{
    mas4[i] = random.Next(1, 20);
}
Console.Write("1 массив = {");
for (int i = 0;i<mas1.Length; i++)
{
    Console.Write(mas1[i]+" ");
}
Console.WriteLine("}");
Console.Write("2 массив = {");
for (int i = 0; i < mas2.Length; i++)
{
    Console.Write(mas2[i] + " ");
}
Console.WriteLine("}");
Console.Write("ср. ариф. 1 и 2 массивов = {");
for (int i = 0; i < mas1.Length; i++)
{
    Console.Write((mas1[i] + mas2[i])/2+" ");
}
Console.WriteLine("}");
Console.WriteLine();
Console.Write("3 массив = {");
for (int i = 0; i < mas3.Length; i++)
{
    Console.Write(mas3[i] + " ");
}
Console.WriteLine("}");
Console.Write("4 массив = {");
for (int i = 0; i < mas4.Length; i++)
{
    Console.Write(mas4[i] + " ");
}
Console.WriteLine("}");
Console.Write("ср. ариф. 3 и 4 массивов = {");
for (int i = 0; i < mas3.Length; i++)
{
    Console.Write((mas3[i] + mas4[i]) / 2 + " ");
}
Console.WriteLine("}");
Console.WriteLine();
Console.WriteLine("Произведение ср. арифметических:");
Console.Write("ср. ариф. 1 и 2 массивов = {");
for (int i = 0; i < mas1.Length; i++)
{
    Console.Write((mas1[i] + mas2[i]) / 2 + " ");
}
Console.WriteLine("}");
Console.Write("ср. ариф. 3 и 4 массивов = {");
for (int i = 0; i < mas3.Length; i++)
{
    Console.Write((mas3[i] + mas4[i]) / 2 + " ");
}
Console.WriteLine("}");
Console.WriteLine();
Console.Write("Произведение = {");
for (int i = 0; i < mas3.Length; i++)
{
    Console.Write((((mas1[i] + mas2[i]) / 2) * ((mas3[i] + mas4[i]) / 2)) + " ");
}
Console.WriteLine("}");
Console.WriteLine();