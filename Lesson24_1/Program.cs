using System.Security.Cryptography.X509Certificates;

static void PaliWord(string word,int currentLetter=0, int lastLetter=-1 )
{
    
    if (lastLetter == -1) { lastLetter = word.Length -1; }
    if (word[currentLetter] != word[lastLetter])
    {
        Console.Write("Not a palindrome");
        return;
    }
    else if (lastLetter == 0)
    {
        Console.Write("Is a palindrome");
        return;
    }
    else PaliWord(word, currentLetter+1, lastLetter-1);
}

try
{
    Console.WriteLine("Введите слово для проверки: ");
    string word = Console.ReadLine()!;
    PaliWord(word);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}