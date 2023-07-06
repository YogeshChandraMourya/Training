using System;
using static System.Console;

class Program
{
    static void removeChar(string word, string ch)
    {
        word = word.Replace(ch, "");
        WriteLine(word);
    }

    // Driver code
    static void Main(string[] args)
    {
        WriteLine("Enter a String:");
        string word = ReadLine();
        WriteLine("Enter char to remove:");
        string a= ReadLine();
        removeChar(word, a);
    }

    
}
