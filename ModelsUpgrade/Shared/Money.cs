namespace ModelsUpgrade.Shared
{
    public record Money
    {
        public decimal Amount { get; private set; }
        public Currency Currency { get; private set; }
        public Money(decimal amount, Currency currency)
        {
            if (amount < 0)
                throw new ArgumentException("amount can not be less than 0");
            Amount = amount;
            Currency = currency;
        }
        public static Money operator +(Money a, Money b)
        {
            if (a.Currency != b.Currency)
            {
                throw new ArgumentException($"Can not perform summation operation for different Currencies type left: {a.Currency} , right: {b.Currency}");
            }

            return a with { Amount = a.Amount + b.Amount };
        }

    }
}
