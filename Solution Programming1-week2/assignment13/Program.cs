namespace assignment13;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }

    void Start()
    {

        Console.Write("Enter your balance: ");
        int userBalance = int.Parse(Console.ReadLine());

        Console.Write("Enter the amount you want to withdraw: ");
        int userAmount = int.Parse(Console.ReadLine());

        bool userCanWithdraw = IsValidWithdrawal(userBalance, userAmount);

        

        if (userCanWithdraw)
        {
            int newBalance = userBalance - userAmount;
            Console.WriteLine($"Withdrawal successful. New balance {newBalance}");
        }
        else
        {
            Console.WriteLine("Withdrawal Failed.");
        }

    }

    bool IsValidWithdrawal(int userBalance, int userAmount)
    {
        bool isValid = true;

        if (userAmount >= userBalance)
        {
            Console.WriteLine("Sorry user: The withdrawal amount exceeds the balance.");
            isValid = false;
        }

        if (userAmount % 10 != 0)
        {
            Console.WriteLine("Sorry user: The withdrawal amount must be a multiple of 10.");
            isValid = false;
        }

        return isValid;
    }
}

