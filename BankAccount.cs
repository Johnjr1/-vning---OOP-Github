namespace vning___OOP_Github
{

    // Class representing a bank account
    public class Account
    {
        public string Name;
        private int balance;
        public int Balance;


        // Method to deposit money into the account
        public void Deposit(int amount)
        {
            {
                balance += amount;
            }
        }

        // Method to withdraw money from the account
        public void Withdraw(int amount)
        {
            {
                balance -= amount;
            }
        }

        // Method to print account information
        public void GetBalance()
        {
            Console.WriteLine($"Hello {Name}, your account has {balance} SEK");
        }
    }
}