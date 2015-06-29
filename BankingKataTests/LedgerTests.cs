using BankingKata;
using NUnit.Framework;

namespace BankingKataTests
{
    [TestFixture]
    public class LedgerTests
    {
        [Test]
        public void TotalIsInitiallyZero()
        {
            var actualTotal = new Ledger().Accept(new BalanceCalculatingVisitor(), new Money(0m));

            var expectedTotal = new Money(0m);
            Assert.That(actualTotal, Is.EqualTo(expectedTotal));
        }

        [Test]
        public void TotalEqualsSumOfAddedMoney()
        {
            var ledger = new Ledger();

            ledger.Record(new CreditEntry(new Money(1m)));
            ledger.Record(new CreditEntry(new Money(3m)));

            var actualTotal = ledger.Accept(new BalanceCalculatingVisitor(), new Money(0m));

            var expectedTotal = new Money(4m);
            Assert.That(actualTotal, Is.EqualTo(expectedTotal));
        }

        [Test]
        public void TheTotalALogWithOnlyDebitsIsTheirNegativeSum()
        {
            var ledger = new Ledger();

            ledger.Record(new DebitEntry(new Money(1m)));
            ledger.Record(new DebitEntry(new Money(3m)));

            var actualTotal = ledger.Accept(new BalanceCalculatingVisitor(), new Money(0m));

            var expectedTotal = new Money(-4m);
            Assert.That(actualTotal, Is.EqualTo(expectedTotal));
        }
    }
}
