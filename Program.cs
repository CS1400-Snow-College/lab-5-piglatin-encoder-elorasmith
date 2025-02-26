// See https://aka.ms/new-console-template for more information

// Elora Smith, 2/25/25, Lab 5 Pig Latin/ Encoder

Console.WriteLine("Welcome to Pig Latin Cryptogram! Give me a sentence or phrase.");
string? phrase = Console.ReadLine();
string[] words = phrase.Split(' ');

foreach (string word in words)
    Console.WriteLine(word);


Console.WriteLine("Let's manipulate your phrase:");