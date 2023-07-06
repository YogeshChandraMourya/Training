using System;
using static System.Console;

class program
{
    public static void Main(string[] args)
    {
        int num, temp, remainder, reverse = 0;
        WriteLine("Enter an integer \n");
        num = int.Parse(ReadLine());
        temp = num;
        while (num > 0)
        {
            remainder = num % 10;
            reverse = reverse * 10 + remainder;
            num /= 10;
        }
        WriteLine($"Given number is = {temp}");
        WriteLine($"Its reverse is  = {reverse}");
        if (temp == reverse) { 
            WriteLine("Number is a palindrome \n");
            Console.Beep(); }
        else {
            WriteLine("Number is not a palindrome \n");
            for (int i = 0; i < 2; i++)
            {
                Console.Beep();
            } }
        ReadLine();
    }
}
