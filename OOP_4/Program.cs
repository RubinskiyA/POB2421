//Индексаторы. Урок 2.
using OOP_4;

Massive2D ourMas = new Massive2D(4,7);
ourMas.Fill();
for (int i = 0; i < ourMas.Rows; i++)
{
    for (int j = 0; j<ourMas.Cols; j++)
    {
        Console.Write(ourMas[i,j]+" ");
    }
    Console.WriteLine();
}
Console.Write("Количество уникальных элементов: "+ourMas.Different());
Console.WriteLine();

User tom = new User();
tom["name"] = "Tom";
tom["email"] = "tom@mail.ru";
tom["phone"] = "+790011234134";
Console.WriteLine(tom["name"]+" " + tom["email"]+" " + tom["phone"]);

