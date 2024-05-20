Console.WriteLine("Выберите аромат духов:\n1. Chanel\n2. Dior\n3. Tom Ford\n4. Gucci\n5.Yves Saint Laurent");
Console.Write("Ваш выбор:");
int choice = int.Parse(Console.ReadLine());

switch (choice)
{
    case 1:
        Console.WriteLine("Chanel - классический и утонченный аромат с нотами цветов и фруктов.");
        break;
    case 2:
        Console.WriteLine("Dior - стильный и современный аромат с древесными и цветочными оттенками.");
        break;
    case 3:
        Console.WriteLine("Tom Ford - эксклюзивный аромат с изысканными и роскошными нотами.");
        break;
    case 4:
        Console.WriteLine("Gucci - соблазнительный и элегантный аромат с восточными акцентами.");
        break;
    case 5:
        Console.WriteLine("Yves Saint Laurent - элегантный и женственный аромат с нотами цветов и пряностей.");
        break;
    default:
        Console.WriteLine("Ошибка: выбран недопустимый номер.");
        break;
}
    