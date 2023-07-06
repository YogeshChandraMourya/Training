using System;
using System.Collections;

public class SortArray
{
    public static void Main()
    {
        Console.WriteLine("Enter Size of Array:");
        int i = int.Parse(Console.ReadLine());
        int[] arr = new int[i];
        for (i = 0; i < 5; i++)
        {
            Console.Write("\nEnter your number:\t");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        Array.Sort(arr);
        Console.WriteLine("Sorted Array is:");
        foreach (var result in arr)
        {
            Console.Write(result + " ");
        }
    }
}