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
    else if (Vowels.Contains(words[i][1]))
    {
        string word;
        
        {
            string word = words[i].Substring(1);
            word = word + words[i][0];
        }
    
        
    }
}
/*
    else if (Vowels.Contains(words[i][2]))
    {
        words[i] = words[i] + words[i][0] + words[i][1] + "ay";
        words[i].Remove(0, 2);
    }
    else if (Vowels.Contains(words[i][3]))
    {
        words[i] = words[i] + words[i][0] + words[i][1] + words[i][2] + "ay";
        words[i].Remove(0, 3);
    }
}



foreach (string word in words)
    Console.WriteLine(word);

