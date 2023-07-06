using static System.Console;

namespace MatrixMultiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 2, n = 2, p = 2, q = 2, i, j;
            int[,] a = { { 1, 4}, { 2, 5 } };
            int[,] b = { { 3, 5 }, { 1, 2} };
            WriteLine("Matrix a:");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Write(a[i, j] + " ");
                }
                WriteLine();
            }
            WriteLine("Matrix b:");
            for (i = 0; i < p; i++)
            {
                for (j = 0; j < q; j++)
                {
                    Write(b[i, j] + " ");
                }
                WriteLine();
            }
            if (n != p)
            {
                WriteLine("Matrix multiplication not possible");
            }
            else
            {
                int[,] c = new int[m, q];
                for (i = 0; i < m; i++)
                {
                    for (j = 0; j < q; j++)
                    {
                        c[i, j] = 0;
                        for (int k = 0; k < n; k++)
                        {
                            c[i, j] += a[i, k] * b[k, j];
                        }
                    }
                }
                WriteLine("The product of the two matrices is :");
                for (i = 0; i < m; i++)
                {
                    for (j = 0; j < n; j++)
                    {
                        Write(c[i, j] + "\t");
                    }
                    WriteLine();
                }
            }
        }
    }
}