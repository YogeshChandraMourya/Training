using System;
using static System.Console;

class CalculatePercentage
{
    public static void Main(string[] args)
    {
        string subject;
        WriteLine("Enter the Marks of Student:");
        double marks= int.Parse(ReadLine());
        WriteLine("Enter Total Marks of Subject:");
        double total= int.Parse(ReadLine());
        WriteLine("Enter Subject in which the student got marks:");
        subject = ReadLine();
        double percentage = (marks / total) * 100;
        if (percentage > 0 && percentage < 40)
        {
            WriteLine($"Student failed in Subject {subject} with {percentage}%");
        }
        if (percentage >= 40 && percentage < 60)
        {
            WriteLine($"Student got D Grade with {percentage}% in {subject}");
        } 
        if (percentage >=60 && percentage < 70)
        {
            WriteLine($"Student got C Grade with {percentage}% in {subject}");
        }
        if(percentage >=70 &&  percentage < 80)
        {
            WriteLine($"Student got B Grade with {percentage}% in {subject}");
        }
        if(percentage >= 80 && percentage < 90)
        {
            WriteLine($"Student got A Grade with {percentage}% in {subject}");
        }
        if(percentage>=90)
        {
            WriteLine($"Student got O Grade with {percentage}% in {subject}");
        }
        
    }
}