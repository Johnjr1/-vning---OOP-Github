namespace vning___OOP_Github
{
    public class SavingsAccount : Account
    {
        public string Savings;

        public override void GetBalance()
        { 
            Console.WriteLine($"Hello {Name}, your savings account has {Savings} SEK.");
        }
    }
}