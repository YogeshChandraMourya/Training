using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionExamples
{
    public abstract class Abstracttest
    {
        //public sealed  int Add(int a,int b)
        //{
        //    return a + b;

        //}
        public static int Add1(int a, int b)
        {
            return a + b;

        }
        public virtual int Add2(int a, int b)
        {
            return a + b;

        }
        public virtual string Add2(string a, string b)
        {
            return a + b;
        }
        public virtual string Add2(int a, int b,int c)
        {
           int  d= a + b+c;
            string e = d.ToString();
            return e;
        }
        public virtual void Command()
        {
            Console.WriteLine("Perform the given technical operation ");
        }

    }

    public class SealInitiate
    {
        public virtual void Command()
        {
            Console.WriteLine("Perform the given technical operation ");
        }

    }
    public class Follower : SealInitiate
    {
        public sealed override void Command()
        {
            Console.WriteLine("Yes I have already did the operation ");
        }
    }

    public class Disciple : Follower
    {
        public override void Command()
        {
            Console.WriteLine("can i perform the follower operation  ");
        }
    }
}
