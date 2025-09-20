namespace vning___OOP_Github
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Create an instance of the Donation class
            Donation donation = new Donation();
            donation.Name = "Nemo";
            donation.Savings = "1000000000";
            donation.Donate();

            //Create an instance of the Account class
            Account johnsAccount = new Account();

            //Create an instance of the SavingsAccount class
            SavingsAccount johnsSavings = new SavingsAccount();

            //Set properties and call methods of the SavingsAccount class
            johnsSavings.Name = "John";
            johnsSavings.Savings = "500000";
            johnsSavings.GetBalance();

            //Use the methods of the Account class
            johnsAccount.Name = "John";
            johnsAccount.Deposit(1000);
            johnsAccount.Withdraw(500);
            johnsAccount.GetBalance();
        }
    }
}