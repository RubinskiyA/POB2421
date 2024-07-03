using Lesson30;

Telephone telephone1 = new Telephone();
Console.WriteLine(telephone1.getDaySay());
Console.WriteLine(telephone1.getTimeSay());
Console.WriteLine(telephone1.getCoastSay());
Telephone telephone2 = new Telephone(6, 10, 1.2);
Console.WriteLine(telephone2.getDaySay());
Console.WriteLine(telephone2.getTimeSay());
Console.WriteLine(telephone2.getCoastSay());
telephone2.setCoastSay(2.60);
Console.WriteLine(telephone2.getCoastSay());
Console.WriteLine(telephone2.getTotal());
