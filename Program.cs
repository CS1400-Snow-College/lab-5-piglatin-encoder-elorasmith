// See https://aka.ms/new-console-template for more information

// Elora Smith, 2/25/25, Lab 5 Pig Latin/ Encoder

Console.WriteLine("Welcome to Pig Latin Cryptogram! Give me a sentence or phrase.");

string? phrase = Console.ReadLine();
string[] words = phrase.Split(' ');


string Vowels = "aeiouAEIOU";
for (int i = 0; i < words.Length; i++)
{
    if (Vowels.Contains(words[i][0]))
        words[i] = words[i] + "way";
    else
    {
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

