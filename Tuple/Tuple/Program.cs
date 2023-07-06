using System;

class TupleSamples
{
    // tuple return type
    public (string name, string title, long year) TupleReturnLiteral(long id)
    {
        string name = string.Empty;
        string title = string.Empty;
        long year = 0;
        if (id == 1000)
        {
            name = "Tony Stark";
            title = "AI";
            year = 2002;
        }
        // tutle literal
        return (name, title, year);
    }
    public static void Main(string[] args)
    {
        TupleSamples ts = new TupleSamples();
        var author = ts.TupleReturnLiteral(1000);
        Console.WriteLine($"Author {author.name} {author.title} {author.year} ");
    }
}