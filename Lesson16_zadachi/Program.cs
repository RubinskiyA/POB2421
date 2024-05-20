//int[,] mas = new int[6, 6];
//for (int i = 0; i < 6; i++)
//{
//    for (int j = 0; j < 6; j++)
//    {
//        if (i == 0) mas[i, j] = 1;
//        else if (j == 0) mas[i, j] = 1;
//        else
//        {
//            mas[i, j] = mas[i, j - 1] + mas[i - 1, j];
//        }
//    }
//}
//for (int i = 0;i < 6; i++)
//{
//      for(int j = 0;j < 6; j++)
//    {
//        Console.Write(mas[i,j]+" ");
//    }
//    Console.WriteLine();
//}

int[,] mas = new int[6, 6];
int k = 1;
for (int i = 0; i < 6; i++)
{
    int m = k;
    for (int j = 0; j < 6; j++)
    {
        if (m > 6) m = 1;
        mas[i, j] = m++;
        Console.Write(mas[i, j] + " ");
    }
    k++;
    Console.WriteLine();
}


