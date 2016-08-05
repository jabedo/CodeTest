using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication1.Models;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ViewModel model = new ViewModel { Num = "100"};
            var setUp = Utility.GetValues(model);
            Assert.AreEqual(setUp.Count, 9);
            Assert.IsTrue(setUp.Contains(19));
            Assert.IsTrue(setUp.Contains(91));

        }
        [TestMethod]
        public void TestNull()
        {
            ViewModel model = new ViewModel { Num = "0" };
            var setUp = Utility.GetValues(model);
            Assert.AreEqual(setUp.Count, 0);
             

        }
    }
}
}
