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
   
    public class Test4Tests
    {
        Test4 test4 = new Test4();
        [TestMethod()]
        public void DivTest()
        {
            int a = 20;
            int b = 0;
            //int c = a / b;
            //Assert.IsTrue(c <= 0);
            Assert.ThrowsException<Exception>(() => test4.Div(a, b));
        }
    }
}