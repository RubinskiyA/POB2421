//Object obj = new object();
//Console.WriteLine(obj.GetHashCode());
//obj = 5;
//int a = 5;
//Console.WriteLine(obj.Equals(a));
//Console.WriteLine(obj.GetType());
//if (obj.GetType() == typeof(int))
//{
//    Console.WriteLine("Целый тип");
//}

//Задание 1.
//● Инициализируйте генератор случайных значений.
//● Объявите переменные и укажите в них значения имен
//пользователей. Необходимо 6 разных имен.
//● Создайте пустой одномерный строковый массив размером в 6
//ячеек.
//● С помощью генератора, в случайном порядке заполните массив
//именами из переменных.
//● Выведите значения массива на экран, в строку.
//● Задача:
//После объявления массива имен, от пользователя берутся имена,
//которые необходимо удалить и удаляются, заменяясь на “Удален”
//Затем, необходимо вывести список имен без “Удален”.

//Random random = new Random();
//string name1 = "Вася";
//string name2 = "Петя";
//string name3 = "Саша";
//string name4 = "Гриша";
//string name5 = "Леша";
//string name6 = "Ваня";
//string[] names = new string[6];
//int i = 0;
//do
//{
//    int n = random.Next(1,7);
//    string temp = String.Empty;
//    switch (n)
//    {
//        case 1: temp = name1; break;
//        case 2: temp = name2; break;
//        case 3: temp = name3; break;
//        case 4: temp = name4; break;
//        case 5: temp = name5; break;
//        case 6: temp = name6; break;
//    }
//    if (!names.Contains(temp))
//    { 
//        names[i++] = temp;
//        if (i == 6) break;
//    }
//}
//while(true);
//foreach (string name in names) Console.Write(name+", ");
//Console.WriteLine();
//Console.WriteLine("Введите имена для удаления, через пробел: ");
//string namesDel = Console.ReadLine();
//string[] mas = namesDel.Split(' ');
//foreach(string name in mas)
//{
//    int index = Array.IndexOf(names, name);
//    if (index != -1) names[index] = "Удален";
//}
//foreach (string name in names)
//    if (name!="Удален") Console.Write(name+", ");

//Задание 2.
//Создать 2 массива, создать цикл, заполняющий их случайными числами.
//Создать 3й массив, заполняемый разностями чисел первого и второго
//массива.
//int[] mas1=new int[10];
//int[] mas2=new int[10];
//int[] mas3 = new int[10];
//Random random = new Random();
//for (int i = 0; i < mas1.Length; i++)
//{
//    mas1[i]= random.Next(10,100);
//    mas2[i] = random.Next(10, 100);
//    mas3[i] = mas1[i] - mas2[i];
//}
//for (int i = 0;i < mas1.Length; i++)
//{
//    Console.Write(mas1[i]+" ");
//}
//Console.WriteLine();

//for (int i = 0; i < mas2.Length; i++)
//{
//    Console.Write(mas2[i] + " ");
//}
//Console.WriteLine();
//for (int i = 0; i < mas3.Length; i++)
//{
//    Console.Write(mas3[i] + " ");
//}
//Console.WriteLine();

//Object[] obj = new Object[6];
//for (int i = 0; i < 6; i++)
//{
//    Console.Write($"Введите {i+1} элемент массива: ");
//    obj[i] = Console.ReadLine();
//}
//string res=string.Empty;
//Array.Reverse(obj);
//for (int i = 0;i < obj.Length; i++)
//res += obj[i];
//Console.WriteLine(res);
//res=res.Substring(0,res.Length/2);
//Console.WriteLine(res);

//Создать три массива, заполнить их случайными числами.
//Создать четвертый, пустой массив, куда поместить средние
//арифметические каждого индекса, каждого массива.

int[] mas1 = new int[10];
int[] mas2 = new int[10];
int[] mas3 = new int[10];
double[] mas4 = new double[10];
Random random = new Random();
for (int i = 0; i < mas1.Length; i++)
{
    mas1[i] = random.Next(10, 100);
    mas2[i] = random.Next(10, 100);
    mas3[i] = random.Next(10, 100);
    double s = (mas1[i] + mas2[i] + mas3[i])/3.0;
    mas4[i] = s;
}
for (int i = 0; i < mas1.Length; i++)
{
    Console.Write(mas1[i] + " ");
}
Console.WriteLine();
for (int i = 0; i < mas2.Length; i++)
{
    Console.Write(mas2[i] + " ");
}
Console.WriteLine();
for (int i = 0; i < mas3.Length; i++)
{
    Console.Write(mas3[i] + " ");
}
Console.WriteLine();
for (int i = 0; i < mas4.Length; i++)
{
    Console.Write($"{mas4[i]:f2} ");
}
Console.WriteLine();