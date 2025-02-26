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
        //consonant conversion
}

/*
foreach (string word in words)
{
    if (word[0]=='a' || word[0]=='e' || word[0]=='i' || word[0]=='o' || word[0]=='u')
        word = word + "way";
}
*/

    



foreach (string word in words)
    Console.WriteLine(word);

enum Consonant {b,c,d,f,g,h,j,k,l,m,n,p,q,r,s,t,v,w,x,y,z}
enum Vowel {a,e,i,o,u}
