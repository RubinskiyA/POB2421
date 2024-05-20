char[,] lamp = {{ ' ', ' ', 'X','X',' ',' '},
               { ' ', 'X', ' ',' ','X',' '},
               { 'X', ' ', ' ',' ',' ','X'},
               { ' ', 'X', 'X','X','X',' '},
               { ' ', ' ', 'X','X',' ',' '},
               { ' ', ' ', 'X','X',' ',' '},
               { ' ', ' ', 'X','X',' ',' '},
               { ' ', ' ', 'X','X',' ',' '},
               { ' ', ' ', 'X','X',' ',' '},
               { ' ', ' ', 'X','X',' ',' '},
               { 'X', 'X', 'X','X','X','X'} };
for  (int i = 0; i < lamp.GetLength(0); i++)
{
    for (int j = 0; j < lamp.GetLength(1); j++)
    {
        Console.Write(lamp[i,j]);
    }
    Console.WriteLine();
}
do
{
    if (lamp[1, 2] == ' ')
    {
        Console.WriteLine("Включить лампочку?(да/нет)");
        string io = Console.ReadLine();
        if (io == "да")
        {
            Console.Clear();
            lamp[1, 2] = 'X';
            lamp[1, 3] = 'X';
            lamp[2, 1] = 'X';
            lamp[2, 2] = 'X';
            lamp[2, 3] = 'X';
            lamp[2, 4] = 'X';
            for (int i = 0; i < lamp.GetLength(0); i++)
            {
                for (int j = 0; j < lamp.GetLength(1); j++)
                {
                    Console.Write(lamp[i, j]);
                }
                Console.WriteLine();
            }

        }
        else if (io=="нет")
        {
            Console.Clear();
            for (int i = 0; i < lamp.GetLength(0); i++)
            {
                for (int j = 0; j < lamp.GetLength(1); j++)
                {
                    Console.Write(lamp[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
    else 
    {
        Console.WriteLine("Выключить лампочку?(да/нет)");
        string io = Console.ReadLine();
        if (io == "да")
        {
            Console.Clear();
            lamp[1, 2] = ' ';
            lamp[1, 3] = ' ';
            lamp[2, 1] = ' ';
            lamp[2, 2] = ' ';
            lamp[2, 3] = ' ';
            lamp[2, 4] = ' ';
            for (int i = 0; i < lamp.GetLength(0); i++)
            {
                for (int j = 0; j < lamp.GetLength(1); j++)
                {
                    Console.Write(lamp[i, j]);
                }
                Console.WriteLine();
            }
        }
        else if(io =="нет")
        {
            Console.Clear();
            for (int i = 0; i < lamp.GetLength(0); i++)
            {
                for (int j = 0; j < lamp.GetLength(1); j++)
                {
                    Console.Write(lamp[i, j]);
                }
                Console.WriteLine();
            }

        }
    }

}
while (true);
