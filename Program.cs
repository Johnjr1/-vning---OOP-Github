namespace vning___OOP_Github
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Create an instance of the Account class
           Account johnsAccount = new Account();
            johnsAccount.Name = "John";
            johnsAccount.Amount = 50000;
            johnsAccount.PrintInfo();
        }
    }
}