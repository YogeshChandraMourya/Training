using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    public delegate void DelegatesDemoDelegate();
    public delegate int AddDelegate(int a, int b);
  

    public class DelegatesEx
    {
        public int Max(int a, int b)
        {
            if (a > b)
                return a;
            return b;
        }
        public int Min(int a, int b) { if (a < b) return a; return b; }

        public int Sum(int a,int b)
        {
            return a + b;
        }

        public int Sub(int a,int b)
        {
            return a - b;   
        }
        public int Mul(int a,int b)
        {
            return a * b;
        }
        public int Div(int a,int b)
        {
            return a / b;
        }

        public static void Main(string[] args)
        {
            DelegatesEx d= new DelegatesEx();
            AddDelegate a=new AddDelegate(d.Sum);
            int r = a(10, 20);
            AddDelegate b=new AddDelegate(d.Sub);
            int r1 = b(10, 5);
            AddDelegate c=new AddDelegate(d.Mul);
            int r2= c(10, 5);
            
        }
    }
}
