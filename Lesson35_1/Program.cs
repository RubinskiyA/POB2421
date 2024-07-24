List<string> people = new List<string>() { "Tom", "Jerry", "Sam"};
List<string> employee = new List<string>(people);
List<string> doctrors = [];
List<string> strings = new List<string>(16);
people.Add("Bob");
people.Add("George");
Console.WriteLine(people.Count+" "+employee.Count+" "+doctrors.Count+" "+strings.Count);
Console.WriteLine(people.Capacity + " " + employee.Capacity + " " + doctrors.Capacity + " " + strings.Capacity);
doctrors.AddRange(employee);
Console.WriteLine(people.Count + " " + employee.Count + " " + doctrors.Count + " " + strings.Count);
Console.WriteLine(people.Capacity + " " + employee.Capacity + " " + doctrors.Capacity + " " + strings.Capacity);
string[] mas = { "1", "2", "3" };
doctrors.AddRange(mas);
for (int i = 0; i < doctrors.Count; i++)
{
    Console.Write(doctrors[i]+" ");
}
Console.WriteLine();
//из List в массив
string[] mas2 = new string[doctrors.Count];

doctrors.CopyTo(mas2);
//бинарный поиск
doctrors.Sort();
for (int i = 0; i < doctrors.Count; i++)
{
    Console.Write(doctrors[i] + " ");
}
Console.WriteLine();
Console.WriteLine(doctrors.BinarySearch("1"));
Console.WriteLine(doctrors.Contains("Sam"));
bool yes=doctrors.Exists(p=>p.Length==8);
Console.WriteLine(yes);
Console.WriteLine(doctrors.Find(p => p.Length == 3));
Console.WriteLine(doctrors.FindLast(p => p.Length == 3));
List<string> list = doctrors.FindAll(p => p.Length==3);
Console.WriteLine(doctrors.IndexOf("1"));
Console.WriteLine(doctrors.LastIndexOf("2"));
for (int i = 0; i < list.Count; i++)
{
    Console.Write(list[i] + " ");
}
Console.WriteLine();

doctrors.Insert(3, "Fire");
for (int i = 0; i < doctrors.Count; i++)
{
    Console.Write(doctrors[i] + " ");
}
Console.WriteLine();
doctrors.InsertRange(3, employee);

for (int i = 0; i < doctrors.Count; i++)
{
    Console.Write(doctrors[i] + " ");
}
doctrors.Reverse();
Console.WriteLine();
for (int i = 0; i < doctrors.Count; i++)
{
    Console.Write(doctrors[i] + " ");
}
doctrors.Remove("Sam");
Console.WriteLine();
for (int i = 0; i < doctrors.Count; i++)
{
    Console.Write(doctrors[i] + " ");
}
var range = doctrors.GetRange(1, 2);
Console.WriteLine();
for (int i = 0; i < range.Count; i++)
{
    Console.Write(range[i] + " ");
}
doctrors.Clear();
Console.WriteLine();
Console.WriteLine(doctrors.Count+" "+doctrors.Capacity);
Console.WriteLine();
List<string> list2 = doctrors.Where(p => p.Length == 3).ToList();
for (int i = 0; i < list2.Count; i++)
{
    Console.Write(list2[i] + " ");
}