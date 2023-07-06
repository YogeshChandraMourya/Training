using System;
using static System.Console;
using System.Linq;
using System.Collections.Immutable;

class DeleteRepeated
{
    public static void Main(string[] args)
    {
        int[] ints = { 10,20,30,30,60,70,70,1,1,2,2};
        WriteLine("Array with Duplicates:");
        Array.ForEach(ints, i => Write(i + " "));
        WriteLine();
        WriteLine("Array After Removing Duplicate:");
        int[] unique=ints.Distinct().ToArray();
        unique.ToImmutableSortedSet();
        Array.ForEach(unique, i => Write(i+" "));
    }
}