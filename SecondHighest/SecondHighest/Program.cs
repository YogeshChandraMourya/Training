using System;
using System.Collections;

public class SecondHighest
{
    public static void Main()
    {
        int[] array = { 3,2,1,5,4};
        Array.Sort(array);
        Array.Reverse(array);  
        Console.WriteLine("Second Highest Value In Array " + array[1]);

        foreach (var result in array)
        {
            Console.Write(result + " ");  
        }
    }
}