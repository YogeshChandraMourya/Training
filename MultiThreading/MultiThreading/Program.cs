
using System.IO;// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//int i = 0;
//while (true)
//{
//    if (i == int.MaxValue - 1)
//        i = 0;
//    i++;
//    Thread.Sleep(1000);
//    Console.WriteLine(i);
//}
//int j = 10;
//while (true)
//{
//    if (j == int.MaxValue - 1)
//        j = 0;
//    j++;
//    Thread.Sleep(1000);
//    Console.WriteLine(i);
//}

/// <summary>
/// This class explain basic Async explanation
/// </summary>
//class Multi
//{
//  static void Main()
//    {
//        Method1();
//        Method2();
//        Console.ReadKey();
//    }
//        public static async void Method1()
//        {
//        await Task.Run(() =>
//        {
//            for (int i = 1; i < 100; i++)
//            {
//                if (i % 2 != 0)
//                {
//                    Console.WriteLine("Odd Number" + i);
//                }
//                Task.Delay(1000);
//            }
//        });
//        }
//    public static async void Method2()
//    {
//        await Task.Run(() =>
//        {
//            for (int i = 2; i < 100; i++)
//            {
//                if (i % 2 == 0)
//                {
//                    Console.WriteLine("Even Number" + i);
//                }
//                Task.Delay(1000);
//            }
//        });
//    }

//}

/// <summary>
/// This class explain Task Dependency
/// </summary>


//class Program
//{
//    static void Main(string[] args)
//    {
//        callMethod();
//        Console.ReadKey();
//    }

//    public static async void callMethod()
//    {
//        Task<int> task = Method1();
//        Method2();
//        int count = await task;
//        Method3(count);
//    }

//    public static async Task<int> Method1()
//    {
//        int count = 0;
//        await Task.Run(() =>
//        {
//            for (int i = 0; i < 100; i++)
//            {
//                Console.WriteLine(" ***Method 1");
//                count += 1;
//            }
//        });
//        return count;
//    }

//    public static void Method2()
//    {
//        for (int i = 0; i < 25; i++)
//        {
//            Console.WriteLine("**************** Method 2");
//        }
//    }

//    public static void Method3(int count)
//    {
//        Console.WriteLine("Total count is ***********************" + count);
//    }
//}


