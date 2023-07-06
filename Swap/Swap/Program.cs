using System;
using static System.Console;

public class Swap
{
    public static void Main(string[] args)
    {
        WriteLine("Firstnumber:");
        int i = int.Parse(ReadLine());
        Console.WriteLine("Second number:");
        int j = int.Parse(ReadLine());
        int temp = i;
        i = j;
        Console.WriteLine("First Number is {0} and Second Number is {1}",i,temp);

    }
}