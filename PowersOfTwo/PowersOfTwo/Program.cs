using System;
using static System.Console;
class PowersOfTwo
{
    public static void Main(string[] args)
    {
        WriteLine("Enter an integer,how many powers of two you want:");
#pragma warning disable CS8604 // Possible null reference argument.
        int num = int.Parse(ReadLine());
#pragma warning restore CS8604 // Possible null reference argument.
        int n = 1;
        for(int i = 0; i < num; i++)
        {
            Console.WriteLine(n);
            n = n * 2;
        }

    }
}