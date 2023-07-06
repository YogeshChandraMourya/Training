using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Sdk;


namespace UnitTesting.Tests
{
    [TestClass()]
    public class Test1Tests

    {
        Test1 test1 = new Test1();
        [TestMethod()]
        public void AddTest()
        {
            int a = 1;
            int b=2;
            int c = test1.Add(a, b);
            int expectedOutput = 3;
            Assert.AreEqual(expectedOutput,c);
        }
        [TestMethod()]
        public void Add_Test_For_MaxValues()
        {
            int a = int.MaxValue;
            int b = 2;
            //int c = test1.Add(a, b);
            Assert.ThrowsException<Exception>(()=>test1.Add(a, b));
            //Assert.IsTrue( c>0);
        }
    }
}