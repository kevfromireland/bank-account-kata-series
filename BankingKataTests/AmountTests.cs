using BankingKata;
using NUnit.Framework;

namespace BankingKataTests
{
    [TestFixture]
    public class AmountTests
    {
        [Test]
        public void TwoAmountsFromSameNumberAreEqual()
        {
            Amount amount1 = new Amount(1);
            Amount amount2 = new Amount(1);

            Assert.That(amount1, Is.EqualTo(amount2));
        }
    }
}
