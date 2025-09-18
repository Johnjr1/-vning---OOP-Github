namespace vning___OOP_Github
{
    
    // Class representing a bank account
   public class Account
    {
        public string Name;
        public int Amount;

        // Method to print account information
        public void PrintInfo()
        {
            Console.WriteLine($"Hello {Name}, your account has {Amount} SEK");
        }
    }
}