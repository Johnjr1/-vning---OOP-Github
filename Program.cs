namespace vning___OOP_Github
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Create an instance of the Account class
            Account johnsAccount = new Account();
            johnsAccount.Name = "John";
            johnsAccount.Deposit(1000);
            johnsAccount.Withdraw(500);
            johnsAccount.GetBalance();
        }
    }
}