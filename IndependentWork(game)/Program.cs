Random random = new Random();
Console.WriteLine("Введите размер игрового поля: ");
int n=int.Parse(Console.ReadLine());
char[,] grid = new char[n, n];
int length = 3;
int health = 3;
char apple = 'O';
int[,] appleGeo=new int[1, 2];
char[] snake = new char[length];
Array.Fill(snake, 'X');
int[,] geoSnake = new int[length, 2];
for (int i = 0; i < geoSnake.GetLength(1); i++) geoSnake[0, i] = snake.Length-i-1;
appleGeo[0,1]=random.Next(n);
appleGeo[0,0]=random.Next(n);
char geo = 'd';
do
{
    Console.Clear();
    Console.WriteLine("Health: " + health);
    for (int i = 0;i<grid.GetLength(0); i++)
    {
        for (int j = 0;j<grid.GetLength(1); j++)
        {
            grid[i, j] = '.';

        }
    }
    
    
    switch (geo)
    {
        case 'w': case 'ц':
            {
                for (int i = snake.Length - 1; i > 0; i--)
                {
                    geoSnake[i, 0] = geoSnake[i - 1, 0];
                    geoSnake[i, 1] = geoSnake[i - 1, 1];
                }

                int temp = --geoSnake[0, 0];
                geoSnake[0, 0] = temp;
                try
                {
                    for (int i = 0; i < snake.Length; i++)
                    {
                        int x = geoSnake[i, 0];
                        int y = geoSnake[i, 1];
                        grid[x, y] = 'X';
                    }
                }
                catch(Exception ex)
                {
                    --health;
                    for (int i = 0; i < geoSnake.GetLength(1); i++) geoSnake[0, i] = snake.Length - i - 1;
                    geo = 'd';
                }
                break;
            }
        case 'a': case 'ф':
            {
                for (int i = snake.Length - 1; i > 0; i--)
                {
                    geoSnake[i, 0] = geoSnake[i - 1, 0];
                    geoSnake[i, 1] = geoSnake[i - 1, 1];
                }

                int temp = --geoSnake[0, 1];
                geoSnake[0, 1] = temp;
                try
                {
                    for (int i = 0; i < snake.Length; i++)
                    {
                        int x = geoSnake[i, 0];
                        int y = geoSnake[i, 1];
                        grid[x, y] = 'X';
                    }
                }
                catch (Exception ex)
                {
                    --health;
                    for (int i = 0; i < geoSnake.GetLength(1); i++) geoSnake[0, i] = snake.Length - i - 1;
                    geo = 'd';
                }
                break;
            }
        case 's': case 'ы':
            {
                for (int i = snake.Length - 1; i > 0; i--)
                {
                    geoSnake[i, 0] = geoSnake[i - 1, 0];
                    geoSnake[i, 1] = geoSnake[i - 1, 1];
                }

                int temp = ++geoSnake[0, 0];
                geoSnake[0, 0] = temp;
                try
                {
                    for (int i = 0; i < snake.Length; i++)
                    {
                        int x = geoSnake[i, 0];
                        int y = geoSnake[i, 1];
                        grid[x, y] = 'X';
                    }
                }
                catch (Exception ex)
                {
                    --health;
                    for (int i = 0; i < geoSnake.GetLength(1); i++) geoSnake[0, i] = snake.Length - i - 1;
                    geo = 'd';
                }
                break;
            }
        case 'd':case 'в':
            {
                for (int i = snake.Length - 1; i > 0; i--)
                {
                    geoSnake[i, 0] = geoSnake[i - 1, 0];
                    geoSnake[i, 1] = geoSnake[i - 1, 1];
                }

                 int temp = ++geoSnake[0, 1];
                geoSnake[0, 1] = temp;
                try
                {
                    for (int i = 0; i < snake.Length; i++)
                    {
                        int x = geoSnake[i, 0];
                        int y = geoSnake[i, 1];
                        grid[x, y] = 'X';
                    }
                }
                catch (Exception ex)
                {
                    --health;
                    for (int i = 0; i < geoSnake.GetLength(1); i++) geoSnake[0, i] = snake.Length - i - 1;
                    geo = 'd';
                }
                break;
            }
    }
            grid[appleGeo[0, 0], appleGeo[0, 1]] = apple;
    if (geoSnake[0, 1] == appleGeo[0, 1] && geoSnake[0, 0] == appleGeo[0, 0])
    {
        length++;
        int[,] temp = new int[length, 2];
        Array.Copy(geoSnake, temp, geoSnake.Length);
        geoSnake=new int[length, 2];
        Array.Copy(temp, geoSnake, temp.Length);
        snake=new char[length];
        Array.Fill(snake,'X');
        appleGeo[0, 1] = random.Next(n);
        appleGeo[0, 0] = random.Next(n);

    }
    for (int i = 0;i < grid.GetLength(0); i++)
    {
        for (int j=0; j < grid.GetLength(1); j++)
        {
            Console.Write(grid[i, j]+" ");
        }
        Console.WriteLine();
    }
    if (Console.KeyAvailable)
    {
        geo = Console.ReadKey().KeyChar;
    }
    Thread.Sleep(500);
    if (health == 0) break;

}
while (true);
Console.WriteLine("Game Over!");