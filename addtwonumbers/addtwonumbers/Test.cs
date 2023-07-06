
public class UnitTest
{
    public void Test()
    {
        int iNumber1;
        int iNumber2;
        Console.WriteLine("Enter first number numbers\n");

        iNumber1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Second Number\n");
        iNumber2 = int.Parse(Console.ReadLine());

        HelperClass helper = new HelperClass();
        int x = helper.Add(iNumber1, iNumber2);


        checked
        {
            Console.WriteLine("\nThe sum of " + iNumber1 + " and " + iNumber2 + " is " + x + "\n Press enter to know the difference of these numbers ");
        }

        Console.ReadKey();

        int y = helper.Subtract(iNumber1, iNumber2);
        Console.WriteLine("\nThe difference between " + iNumber1 + " and " + iNumber2 + "  is " + y);
        Console.ReadKey();
    }
}
public class HelperClass
{
    public HelperClass() { }
    public int Add(int a, int b)
    {
        int x = a + b;
        return x;
    }
    public int Subtract(int a, int b)
    {
        int x = a - b;
        return x;
    }
}
