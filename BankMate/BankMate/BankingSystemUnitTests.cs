using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankMate
{
    public class BankingSystemUnitTests
    {
        BankingSystem manager = new BankingSystem();
        
        [TestMethod]
        public void TestAddUser()
        {
            Assert.AreEqual(manager.Users.Count, 0);
            manager.AddUser();
            Assert.AreEqual(manager.Users.Count, 1);
        }
    }
}
