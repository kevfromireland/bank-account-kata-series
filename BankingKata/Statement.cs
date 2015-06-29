using System.IO;

namespace BankingKata
{
    public class Statement
    {
        private readonly Account m_Account;
        private readonly TextWriter m_StatementWriter;

        public Statement(Account account, TextWriter statementWriter)
        {
            m_Account = account;
            m_StatementWriter = statementWriter;
        }

        public void PrintBalance()
        {
            var balance = m_Account.CalculateBalance();
            m_StatementWriter.WriteLine("Balance: {0}", balance);
        }
    }
}