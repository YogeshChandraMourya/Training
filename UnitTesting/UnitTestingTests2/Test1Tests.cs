using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting.Tests
{
    [TestClass()]
    public class Test1Tests
    {
        Test1 test1 = new Test1();
        [TestMethod()]
        public void AddTest()
        {
            Assert.Fail();
        }
    }
}