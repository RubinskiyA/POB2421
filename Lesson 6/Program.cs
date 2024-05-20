
const string id1 = "КОФЕ СТАНДАРТНЫЙ";
const string id2 = "РУЛЕТ СПРИНГ ТВ ИЗ";
const string nds = "НДС с расчитанной ";
double price1 = 69.00;
double price2 = 70.00;
double sum = price1 + price2;
double nds18 = 0.18;
double nds10 = 0.1;
string vidNaloga = "ОСН";
string numKKT = "0000143873021383";
string numFN = "8710000100265168";
string numFD = "6026";
string numFPD = "3322279314";

Console.WriteLine("______________________________________________________________");
Console.WriteLine("..............................................................");
Console.WriteLine("№  Название                        Цена       Кол.     Сумма  ");
Console.WriteLine($"1  {id1}                {price1:F2}       1       {price1*1:F2}  ");
Console.WriteLine($"   {nds}                                  {price1*nds18:F2}");
Console.WriteLine("   ставкой 18%");
Console.WriteLine();
Console.WriteLine($"2  {id2}              {price2:F2}       2       {price2*1:F2}  ");
Console.WriteLine("   КУ");
Console.WriteLine($"   {nds}                                   {price1 * nds10:F2}");
Console.WriteLine("   ставкой 10%");
Console.WriteLine("\n\n\n\n");
Console.WriteLine("..............................................................");
Console.WriteLine($"ИТОГО:                                                 {sum:F2}");
Console.WriteLine("\n");
Console.WriteLine($"Электронные средства                                   {sum:F2}");
Console.WriteLine($"НДС итога с                                             {price1 * nds18:F2}");
Console.WriteLine("рассчитанной ставкой");
Console.WriteLine("18%");
Console.WriteLine($"НДС итога с                                             {price1 * nds10:F2}");
Console.WriteLine("рассчитанной ставкой");
Console.WriteLine("10%");
Console.WriteLine("\n\n");
Console.WriteLine("..............................................................");
Console.WriteLine($"ВИД НАЛОГООБЛАЖЕНИЯ: {vidNaloga}");
Console.WriteLine($"РЕГ. НОМЕР ККТ: {numKKT}");
Console.WriteLine("ЗАВОД №:");
Console.WriteLine($"ФН №: {numFN}");
Console.WriteLine($"ФД №: {numFD}");
Console.WriteLine($"ФПД №: {numFPD}");













