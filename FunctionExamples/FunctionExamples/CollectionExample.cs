using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionExamples
{
    public class CollectionExample
    {
        public void ExampleOfArray()
        {
            int x = 99;
            int[] arr= new int[x];

            ArrayList arrayList = new ArrayList();
            arrayList.Add(222);
            arrayList.Add("RRR");
            arrayList.Add(true);
            arrayList.Add(false);
            arrayList.AddRange(arr);

            Console.WriteLine(arrayList.ToString());

            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(78);
            stack.Pop();
            Console.WriteLine(stack.ToString());


            Queue q = new Queue();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Enqueue(560);

            q.Enqueue(4);
            q.Dequeue();
            Console.WriteLine(q.ToString());



            //object obj = "Raj"; // Boxing
            //string name = obj.ToString();// unboxing

            // Generic

            Queue<int> intQ = new Queue<int>();
            intQ.Enqueue(10);
            intQ.Enqueue(20);
            intQ.Enqueue(30);

            Console.WriteLine(intQ.ToString());

            List<string> strList = new List<string>();
            strList.Add("Ant");
            strList.Add("Apple");
            strList.Add("Ape");
            strList.Add("Anaconda");
            strList.Add("Antarctica");

            foreach (var item in strList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("________________________________________________");
            strList.Sort();
            Console.WriteLine(strList.ToString());
            foreach (var item in strList)
            {
                Console.WriteLine(item);
            }

            List<DateTime> listDates = new List<DateTime>();
            listDates.Add(DateTime.Now.AddDays(8));
            listDates.Add(DateTime.Now.AddDays(-5));
            listDates.Add(DateTime.Now.AddDays(-3));
            listDates.Add(DateTime.Now.AddDays(-2));
            listDates.Add(DateTime.Now.AddDays(3));

            foreach (var item in listDates)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("__________________________________________________");

            listDates.Sort();
            Console.WriteLine(listDates.ToString());

            foreach (var item in listDates)
            {
                Console.WriteLine(item);
            }

            var coll=from item in strList
                     orderby item ascending
                     select item;

  

            foreach (var item in coll)
            {
                Console.WriteLine(item);
            }

            List<Student> students = new List<Student>();
            students.Add(new Student { Id = 5, Name = "A", Rank = 2 });
            students.Add(new Student { Id = 2, Name = "e", Rank = 5 });
            students.Add(new Student { Id = 2, Name = "d", Rank = 4 });
            students.Add(new Student { Id = 3, Name = "b", Rank = 1 });
            students.Add(new Student { Id = 4, Name = "c", Rank = 3 });

            var orderbyNameStudents = from stu in students
                                      orderby stu.Name descending
                                      select stu.Name;
            var orderbyRankStudents = from stu in students
                                      orderby stu.Rank ascending
                                      select new { Name = stu.Name, rank = stu.Rank, id = stu.Id };
            var orderbyIdStudents = from stu in students
                                    orderby stu.Id ascending
                                    select new { Name = stu.Name, rank = stu.Rank, id = stu.Id };

        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Rank { get; set; }
    }

}
    

