using System.IO;
using System.Text;
using BankingKata;
using NUnit.Framework;

namespace BankingKataTests
{
    [TestFixture]
    public class StatementTests
    {
        [Test]
        public void DefaultAccountsCanHaveBalancePrinted()
        {
            var resultBuffer = new StringBuilder();

            var account = new Account(new Ledger());
            new Statement(account, new StringWriter(resultBuffer)).PrintBalance();

            Assert.That(resultBuffer.ToString(), Is.EqualTo("Balance: £0.00\r\n"));
        }
    }
}