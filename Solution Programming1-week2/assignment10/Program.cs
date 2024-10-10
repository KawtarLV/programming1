namespace assignment10;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();

    }

    void Start()
    { 
        Console.Write("Enter a letter : ");
        char letter = char.Parse(Console.ReadLine().ToLower());

        bool isVowel = IsLetterVowel(letter);

        if (isVowel)
        {
            Console.WriteLine($"{letter} is a vowel.");
        }
        else
        {
            Console.WriteLine($"{letter} is a consonant.");
        }

    }

    bool IsLetterVowel(char letter)
    {
        switch (letter)
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
                return true;

            default:
                return false;
        }
    }
}

