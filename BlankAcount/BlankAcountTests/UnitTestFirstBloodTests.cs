using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlankAcount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlankAcount.Tests
{
    [TestClass()]
    public class UnitTestFirstBloodTests
    {
        [TestMethod()]
        public void TestExeptionCase()
        {
            UnitTestFirstBlood blank = new UnitTestFirstBlood("Tiep", 0);
            try
            {
                blank.Debit(2);
            }
            catch(ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, "amount <= 0 or amount > balance");
                return;
            }
            catch(Exception e)
            {
                StringAssert.Contains(e.Message, "balance = 0");
                return;
            }
            Assert.Fail("No Exeption are throw");
        }

        [TestMethod()]
        public void TestDebitCase()
        {
            UnitTestFirstBlood blank = new UnitTestFirstBlood("Tiep", 3);
            blank.Debit(2);
            Assert.AreEqual(1, blank.Balance);
        }
        [TestMethod()]
        public void TestCreditCase()
        {
            UnitTestFirstBlood blank = new UnitTestFirstBlood("Tiep", 3);
            blank.Credit(7);
            Assert.AreEqual(10, blank.Balance);
        }
        [TestMethod()]
        public void TestDebitCreditCase()
        {
            UnitTestFirstBlood blank = new UnitTestFirstBlood("Tiep", 3);
            blank.Debit(2);
            blank.Credit(9);
            Assert.AreEqual(10, blank.Balance);
        }
    }
}