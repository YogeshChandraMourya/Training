using System;using static System.Console;
class SwapTwoNumbers
{
    public static void Main(string[] args)
    {
        WriteLine("Enter a number to Swap:");
#pragma warning disable CS8604 // Possible null reference argument.
        int num= int.Parse(ReadLine());
#pragma warning restore CS8604 // Possible null reference argument.
        int remainder = num % 10;
        int divident=num / 10;
        int put = remainder * 10 + divident;
        WriteLine("The Swappes Number is:{0}",put);
    }
}