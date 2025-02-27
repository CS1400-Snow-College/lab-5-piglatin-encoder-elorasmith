// See https://aka.ms/new-console-template for more information

// Elora Smith, 2/25/25, Lab 5 Pig Latin/ Encoder

// GREETING & INPUT
Console.WriteLine("Welcome to Pig Latin Cryptogram! Give me a sentence or phrase.");
string? phrase = Console.ReadLine();
string[] words = phrase.Split(' ');

// PIG LATIN
string Vowels = "aeiouAEIOU";
for (int i = 0; i < words.Length; i++)
{
    words[i] = words[i].ToLower(); 
    if (Vowels.Contains(words[i][0]))
        words[i] = words[i] + "way";
    else
    {
        if (words[i].Contains('y') && words[i][0] != 'y')
            Vowels = "aeiouyAEIOUY";
        while (Vowels.Contains(words[i][0]) == false)
        {
            words[i] = words[i].Substring(1) + words[i][0];
         }
        words[i] = words[i] + "ay";
    }  
}
Console.Write("In Pig Latin that's: ");
foreach (string word in words)
    Console.Write($"{word} ");
Console.WriteLine();

// ENCRYPTION 
string phrase2 = "";
for (int i = 0; i < words.Length; i++)
{
    phrase2 = phrase2 + $"{words[i]} ";
}

Console.Write("We can encrypt that as: ");
for (int i = 0; i < phrase2.Length; i++)
{
    {
        if (phrase2[i] != ' ')
        {
            Random rand = new Random(); int randomOffset = rand.Next(1,26);
            char temp = phrase2[i];
            temp = (char)((int)temp + randomOffset);
            if (((int)temp + randomOffset) > 122)
                randomOffset -= 26;
            Console.Write(temp);
        }
        else
        Console.Write(phrase2[i]);
    } 
}

