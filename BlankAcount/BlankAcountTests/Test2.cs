using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlankAcount;

namespace BlankAcountTests
{
    [TestClass()]
    public class Test2
    {
        [TestMethod()]
        public void TestCreditCase1()
        {
            UnitTestFirstBlood blank = new UnitTestFirstBlood("Tiep", 100000);
            blank.Credit(200000);
            Assert.AreEqual(300000, blank.Balance);
        }
    }
}
