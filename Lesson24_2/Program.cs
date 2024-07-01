try
{
    Console.WriteLine("Введите число: ");
    int num;
    int.TryParse(Console.ReadLine(), out num);
    void Numbers(int num, int startNum=1)
    {
        
        Console.Write(startNum+" ");
        startNum += 2;
        if (startNum >= num) return;
        else Numbers(num, startNum);
    }
    Numbers(num);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}