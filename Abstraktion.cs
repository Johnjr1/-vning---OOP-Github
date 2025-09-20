namespace vning___OOP_Github
{
    //Abstaktion

    //Huvudklass abstrakt
    public abstract class Donations: SavingsAccount
    {
        public abstract void Donate();
    }

    //Subklass
    public class Donation : Donations
    { 
        public override void Donate()
        {
            Console.WriteLine($"Hello {Name}, you have donated all you savings: {Savings} SEK to John.");
        }
    }
}