namespace BankSystem
{
    public class Account
    {
        public int AccountNumber;
        public string AccountType;
        public decimal Balance;
        public const decimal interestRate = .05m;
        public Account(int accountNumber, string accountType, decimal balance)
        {
            AccountNumber = accountNumber;
            AccountType = accountType;
            Balance = balance;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdrew(decimal amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient balance.");
            }
        }
        public decimal CalculateInterest(decimal durationInYears = 1)
        {
            return (Balance * durationInYears * interestRate);
        }
    }
}
