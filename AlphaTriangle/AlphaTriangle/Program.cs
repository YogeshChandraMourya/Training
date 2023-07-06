using System;
using static System.Console;
public class AlphaTriangle
{
    public static void Main(string[] args)
    {
        char ch = 'A';
        int i, j, k, m;
        for (i = 1; i <= 6; i++)
        {
            for (k = 1; k <= i; k++)
                Write(ch++);
                Write("\n");
            ch = 'A';
        }
    }
}
