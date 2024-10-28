namespace assignment6;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }
    void Start()
    {
        Console.Write("How many votes should be processed:");
        int numOfvotes = int.Parse(Console.ReadLine());

        VotingSystem votingSystems = new VotingSystem(100);

        for (int i =0; i < numOfvotes; i++)
        {
            Console.Write("Enter your vote (Yes/No):");
            string input = Console.ReadLine();


            VoteOption vote = (VoteOption)Enum.Parse(typeof(VoteOption), input,true);
            votingSystems.CastVote(vote);
        }
        votingSystems.DisplayResults();
    }
}

