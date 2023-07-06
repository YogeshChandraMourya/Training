using System;
using static System.Console;
class program
{
    public static void Main()
    {
        int a, i;
        WriteLine("Multiples of 18 are : ");
        for (i = 1; i < 100; i++)
        {
            a = i % 18;
            if (a == 0)
            {
                WriteLine(i);
            }
        }
        Read();
    }
}
