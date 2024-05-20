using System.ComponentModel.Design;

Console.Write("Введите ключевые слова, через пробел:");
string cencureWord=Console.ReadLine();
string[] forbiddenWords = cencureWord.Split(' ');
string sentence = "";
do
{
    Console.Write("Введите слова для составления предложения: ");
    string word = Console.ReadLine();
    for (int i=0; i < forbiddenWords.Length; i++)
    {
        if (word == forbiddenWords[i]) { word = "(скрыто)"; break; }
        
    }
    if (word == "конец") break;
    sentence += word + " ";
}
while (true);
Console.WriteLine($"Сформированное преложение: {sentence}");