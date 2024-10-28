namespace assignment9;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program() ;
        program.Start();
    }

    void Start()
    {
        Bank bank = new Bank(10); // Create a bank with capacity for 10 accounts

        // Create a new account
        Console.Write("Enter account holder name: ");
        string accountHolder = Console.ReadLine();
        bank.CreateAccount(accountHolder); // Create account with input name

        // Prompt user for deposit
        Console.Write("Enter deposit amount: ");
        double depositAmount = double.Parse(Console.ReadLine());
        bank.Deposit(1, depositAmount); // Deposit into the first account

        // Display account details
        bank.DisplayAccountDetails(1);
        Console.ReadLine();
    }
}

