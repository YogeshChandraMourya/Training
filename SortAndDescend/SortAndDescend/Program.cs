
using System;
using static System.Console;

class SortAndDescend
{

    static void descOrder(char[] s)
    {
        Array.Sort(s);
        reverse(s);
    }

    static void reverse(char[] a)
    {
        int i, n = a.Length;
        char t;
        for (i = 0; i < n / 2; i++)
        {
            t = a[i];
            a[i] = a[n - i - 1];
            a[n - i - 1] = t;
        }
    }

    public static void Main(String[] args)
    {
        string a = "Question";
        a=a.ToLower();
        char[] s= a.ToCharArray();
        descOrder(s);
        string b=String.Join("", s);
        b=b.ToLower();
        WriteLine(b);
    }
}
