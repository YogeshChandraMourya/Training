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
    public class TestTests
    {
        Test1 sample = new Test1();
        
        [TestMethod()]
        
        public void AddTest()
        {
            Assert.Fail();
        }
    }
}