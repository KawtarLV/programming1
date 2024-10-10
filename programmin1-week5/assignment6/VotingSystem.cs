using System;
namespace assignment6
{
	public class VotingSystem
	{
		VoteOption[] votes;
		int numberOfVotes = 0;

		public VotingSystem(int size)
		{
			votes = new VoteOption[size];
		}
		public void CastVote(VoteOption vote)
		{
			votes[numberOfVotes] = vote;
			numberOfVotes++;

        }
        public void DisplayResults()
		{
			int yesCount = 0;
			int noCount = 0;
			for (int j =0; j< numberOfVotes; j++)
			{
				if (votes[j] == VoteOption.yes)
				{
                    yesCount++;
                }

				else
				{
				   noCount++;
				}
					
			}
			Console.WriteLine("Results:");
            Console.WriteLine($"Yes:{yesCount}");
            Console.WriteLine($"No:{noCount}");

        }


    }
}

