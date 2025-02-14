namespace PropertiesAssignment
{
    internal class BankAccount
    {
        public int AccountNumber { get; } = 0;
        public int AccountHolderName { get; set; }
        public int balance = 0;
        public int Balance
        {
            get
            {
                return balance;
            }
            private set
            {
                if (value > 0) { balance = value; }
            }
        }
        public BankAccount()
        {
            AccountNumber++;
        }
        public int Deposit(int deposite)
        {
            if (deposite > 0)
            {
                balance += deposite;
            }
            return balance;
        }
        public string Withdraw(int deposite)
        {
            if (deposite > 0 && balance > deposite)
            {
                return $"your new balance is {balance - deposite} ";
            }
            else
            {
                return "Invalid procees, please enter a valid value";
            }
        }
    }
}
