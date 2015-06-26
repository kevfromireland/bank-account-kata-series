using System;

namespace BankingKata
{
    public class Amount : IEquatable<Amount>, IComparable<Amount>
    {
        private readonly uint m_Amount;

        public Amount(uint amount)
        {
            m_Amount = amount;
        }

        public bool Equals(Amount other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return m_Amount == other.m_Amount;
        }

        public int CompareTo(Amount other)
        {
            return m_Amount.CompareTo(other.m_Amount);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Amount) obj);
        }

        public override int GetHashCode()
        {
            return (int) m_Amount;
        }
    }
}