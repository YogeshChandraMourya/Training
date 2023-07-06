using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestingPractice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace TestingPractice.Tests
{
    [TestClass()]
    public class Test2Tests
    {
        Test2 test2= new Test2();

        [TestMethod()]
        public void SubTest()
        {
            int a = int.MinValue;
            int b = 30;
            int c = a - b;
            Assert.IsTrue(c > 0);
            Assert.ThrowsException<Exception>(() => test2.Sub(a, b));
        }
    }
}