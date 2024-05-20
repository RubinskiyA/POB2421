//Написать игровое приложение, где компьютер загадывает число от 1 до
//5 и пользователь должен отгадать это число.
//Пользователю дается 3 попытки, если последний не угадывает число,
//выводится сообщение, содержащее число, загаданное компьютером и
//информация о поражении.

Random random = new Random();
int count = 0;
int pcNumber = random.Next(1, 6);
Console.WriteLine(pcNumber);
while (count < 3)
{
    Console.Write($"Компьютер загадал число от 1 до 5, отгадайте его(у вас {3-count} попытки): ");
    int userNumber = int.Parse(Console.ReadLine());
    count++;
    if (userNumber == pcNumber)
    {
        Console.WriteLine("Вы угадали!");
        break;
    }
    else 
    {
        
        if (count == 1||count==2) Console.WriteLine($"Не верно :( Попробуйте снова: ");
        else Console.WriteLine($"Вы не угадали, компьютер загадал {pcNumber}");
    }
}