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
    public class Test3Tests
    {
        Test3 test3 = new Test3();  
        [TestMethod()]
        public void MulTest()
        {
            int a = int.MinValue;
            int b = 30;
            int c = a * b;
            Assert.IsFalse(c < 0);
            Assert.ThrowsException<Exception>(() => test3.Mul(a, b));
        }
    }
}