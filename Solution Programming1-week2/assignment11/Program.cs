namespace assignment11;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.start();
    }

    void start()
    {
        Console.Write("Enter your password : ");
        string userPassword = Console.ReadLine();
        bool isValidPassWord = isValidPassword(userPassword);

        if (isValidPassWord)
        {
            Console.WriteLine("Password is valid.");
        }


    }

    bool isValidPassword(string userPassword)
    {

       bool isValidPassWord = true;
       bool containsUppercase = false;
       bool containsNumber = false;

 
        if (userPassword.Length < 8)
        {
            Console.WriteLine("Password is not valid, it should be at least 8 characters long.");
            isValidPassWord = false;
        }

        foreach(char i in userPassword)
        {
            if (char.IsUpper(i))
            {
                containsUppercase = true;
            }

            if (char.IsDigit(i))
            {
                containsNumber = true;
            }
        }

        if (!containsUppercase)
        {
            Console.WriteLine("Password must contain at least one uppercase letter.");
            isValidPassWord = false;
        }

        if (!containsNumber)
        {
            Console.WriteLine("Password must contain at least one number.");
            isValidPassWord = false;
        }

        return isValidPassWord;
    }
}

