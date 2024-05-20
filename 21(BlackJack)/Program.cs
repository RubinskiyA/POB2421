Random random = new Random();
string[,] nominal = 
{ 
                       { "T", "2", "3", "4", "5", "6", "7", "8", "9", "10", "V", "D", "K" },
                       {"11", "2", "3", "4", "5", "6", "7", "8", "9", "10", "10", "10", "10"}                                                              
};
int playerScore = 0;
int dealerScore = 0;
string[,] table =
 {
    {"o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o"},
    {"o", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "o"},
    {"o", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "o"},
    {"o", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "o"},
    {"o", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "o"},
    {"o", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "o"},
    {"o", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "o"},
    {"o", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "o"},
    {"o", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "o"},
    {"o", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "o"},
    {"o", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "o"},
    {"o", "o" ,"o" ,"o" ,"o" ,"o" ,"o" ,"o" ,"o" ,"o" ,"o" ,"o"}

};
bool wannaPlay = true;
while (wannaPlay==true)
{
    Console.Write("Игра Блэк Джек(Двадцать одно), если вы хотите начать игру нажмите Y, для выхода нажмите N:");

    ConsoleKeyInfo key = Console.ReadKey(false);
    switch (key.Key)
    {
        case ConsoleKey.Y:
            {
                //Первоначальный стол и раздача 4 карт
                Console.Clear();
                Console.WriteLine("    Dealer ");
                int dealerCard1 = random.Next(0, 13);
                int playerCard1 = random.Next(0, 13);
                int playerCard2 = random.Next(0, 13);
                int dealerCard2 = random.Next(0, 13);
                for (int i = 0; i < table.GetLength(0); i++)
                {
                    for (int j = 0; j < table.GetLength(1); j++)
                    {
                        table[1, 5] = nominal[0, dealerCard1];
                        table[1, 6] = nominal[0, dealerCard2];
                        table[10, 5] = nominal[0, playerCard1];
                        table[10, 6] = nominal[0, playerCard2];
                        Console.Write(table[i, j] + " ");

                    }
                   
                    playerScore = Convert.ToInt32(nominal[1, playerCard1]) + Convert.ToInt32(nominal[1, playerCard2]);
                    dealerScore = Convert.ToInt32(nominal[1, dealerCard1]) + Convert.ToInt32(nominal[1, dealerCard2]);

                    Console.WriteLine();
                }
                Console.WriteLine("         Player");
                // Игровой цикл для игрока
                bool playerTurn = true;
                while (playerTurn)
                {

                    Console.WriteLine("Ваши очки: " + playerScore + "     Очки дилера: " + dealerScore);
                    Console.WriteLine("Брать карту? Y/N");
                    var input = Console.ReadKey(true);
                    if (input.Key == ConsoleKey.Y)
                    {
                        Console.Clear();
                        int cardIndex = random.Next(0, 13);
                        playerScore += Convert.ToInt32(nominal[1, cardIndex]);
                        Console.WriteLine("Вы взяли карту: " + nominal[0, cardIndex]);
                        if (table[10, 7] == " ")
                        {
                            for (int i = 0; i < table.GetLength(0); i++)
                            {
                                for (int j = 0; j < table.GetLength(1); j++)
                                {
                                    table[10, 7] = nominal[0, cardIndex];
                                    Console.Write(table[i, j] + " ");
                                }
                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            for (int i = 0; i < table.GetLength(0); i++)
                            {
                                for (int j = 0; j < table.GetLength(1); j++)
                                {
                                    table[10, 4] = nominal[0, cardIndex];
                                    Console.Write(table[i, j] + " ");
                                }
                                Console.WriteLine();
                            }
                        }
                        if (playerScore > 21)
                        {
                            Console.WriteLine("Перебор! Вы проиграли.");
                            playerTurn = false;

                        }

                    }
                    else if (input.Key == ConsoleKey.N)
                    {
                        playerTurn = false;
                    }
                }

                // Ход дилера
                Console.Clear();
                while (dealerScore < 17)
                {
                    if (playerScore >= 21) break;
                    int cardIndex = random.Next(0, 13);
                    if (table[1, 7] == " ")
                    {
                        for (int i = 0; i < table.GetLength(0); i++)
                        {
                            for (int j = 0; j < table.GetLength(1); j++)
                            {
                                table[1, 7] = nominal[0, cardIndex];
                                Console.Write(table[i, j] + " ");
                            }
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        for (int i = 0; i < table.GetLength(0); i++)
                        {
                            for (int j = 0; j < table.GetLength(1); j++)
                            {
                                table[1, 4] = nominal[0, cardIndex];
                                Console.Write(table[i, j] + " ");
                            }
                            Console.WriteLine();
                        }
                    }
                    dealerScore += Convert.ToInt32(nominal[1, cardIndex]);
                    Console.WriteLine("Дилер взял карту: " + nominal[0, cardIndex]);
                }

                // Определение победителя
                if (playerScore <= 21 && (playerScore > dealerScore || dealerScore > 21))
                {
                    for (int i = 0; i < table.GetLength(0); i++)
                    {
                        for (int j = 0; j < table.GetLength(1); j++)
                        {
                            Console.Write(table[i, j] + " ");
                        }
                        Console.WriteLine();
                        }
                        Console.WriteLine("Поздравляем! Вы выиграли.");
                    Console.WriteLine("Ваши очки: " + playerScore + "     Очки дилера: " + dealerScore);
                    Console.WriteLine("Сыграть еще раз?Y/N");
                    var input = Console.ReadKey(true);
                    if (input.Key == ConsoleKey.Y)
                    {
                        Console.Clear();
                        table[1, 4] = " ";
                        table[1, 7] = " ";
                        table[10, 4] = " ";
                        table[10, 7] = " ";
                        continue;
                    }
                    else if (input.Key == ConsoleKey.N) break;

                }
                else if (dealerScore == playerScore)
                {
                    for (int i = 0; i < table.GetLength(0); i++)
                    {
                        for (int j = 0; j < table.GetLength(1); j++)
                        {
                            Console.Write(table[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("Ничья!");
                    Console.WriteLine("Ваши очки: " + playerScore + "     Очки дилера: " + dealerScore);
                    Console.WriteLine("Сыграть еще раз?Y/N");
                    var input = Console.ReadKey(true);
                    if (input.Key == ConsoleKey.Y)
                    {
                        Console.Clear();
                        table[1, 4] = " ";
                        table[1, 7] = " ";
                        table[10, 4] = " ";
                        table[10, 7] = " ";
                        continue;
                    }
                    else if (input.Key == ConsoleKey.N) break;

                }
                else
                {
                    for (int i = 0; i < table.GetLength(0); i++)
                    {
                        for (int j = 0; j < table.GetLength(1); j++)
                        {
                            Console.Write(table[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("Увы, вы проиграли.");
                    Console.WriteLine("Ваши очки: " + playerScore + "     Очки дилера: " + dealerScore);
                    Console.WriteLine("Сыграть еще раз?Y/N");
                    var input = Console.ReadKey(true);
                    if (input.Key == ConsoleKey.Y)
                    {
                        Console.Clear();
                        table[1, 4] = " ";
                        table[1, 7] = " ";
                        table[10, 4] = " ";
                        table[10, 7] = " ";
                        continue;
                    }
                    else if (input.Key == ConsoleKey.N) break;
                }
                break;
            }

        case ConsoleKey.N:
            {
                wannaPlay = false;
                break;
            }
        default:
            {
                Console.WriteLine("Неверная клавиша.");

                 break;
            }
    };

}
