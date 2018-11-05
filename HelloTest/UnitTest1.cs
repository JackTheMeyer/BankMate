using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankApp;

namespace HelloTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(Program.CreateMessage(), "Hello World");
        }
    }
}
