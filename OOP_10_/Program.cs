//string x = "ssdfsdf";
//Console.WriteLine(x.GetHashCode());
//string y = "gfdgsdgsd";
//Console.WriteLine(y.GetHashCode());

//List<string> list = new List<string>();
//list.Add("Первая задача");
//list.Add("Вторая задача");
//list.Add("Третья задача");
//foreach (var item in list) Console.WriteLine(item);
//list.Remove("Первая задача");
//list.RemoveAt(0);
//Console.WriteLine(list.Count);
//foreach (var item in list) Console.WriteLine(item);
//-----------------------
//Учет посещений
//Dictionary<string, int> client = new Dictionary<string, int>();
//string enterString = "";

//do
//{
//    Console.WriteLine("Введите имя клиента: ");
//    enterString = Console.ReadLine()!;
//    if (enterString == "exit") break;
//    if (client.ContainsKey(enterString)) 
//    {
//        client[enterString]++; 
//    }
//    else client.Add(enterString, 1);

//}
//while (true);
//foreach (var item in client)
//{
//    Console.WriteLine(item.Key+" "+item.Value);
//}
//---------------------------
//Уникальные элементы массива

//bool IsUnique(int[] mas)
//{
//    HashSet<int> result = new HashSet<int>();
//    foreach (int ma in mas)
//    {
//        result.Add(ma);
//    }
//    return result.Count==mas.Length;
//}

//int[] m1 = { 1, 2, 3, 5 };
//int[] m2 = { 2, 5, 5, 6, 2 };
//Console.WriteLine(IsUnique(m1));
//Console.WriteLine(IsUnique(m2));

//------------------------
List < int > list= new();
SortedSet<int> sort = new();
Random random = new Random();
for (int i = 0; i < random.Next(50); i++)
{
    int m=random.Next(10,100);
    list.Add(m);
    sort.Add(m);

}
list.Sort();
foreach (int m in list)
{
    Console.Write(m +" ");
}
Console.WriteLine(  );
foreach (int m in sort)
{
    Console.Write(m + " ");
}

