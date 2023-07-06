using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestingPractice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingPractice.Tests
{
    [TestClass()]
    public class Test1Tests
    {
        Test1 test=new Test1();

        [TestMethod()]
        public void AddTest()
        {
            int a = int.MaxValue;
            int b = 30;
            int c = a + b;
            Assert.IsFalse (c>0);
            Assert.ThrowsException<Exception>(() => test.Add(a, b));
        }
    }
}