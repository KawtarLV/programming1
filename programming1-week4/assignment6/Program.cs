using System.Diagnostics.Metrics;

namespace assignment6;

class Program
{
    const int arraySize = 6;
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }

    void Start()
    {
        int[] diceCounts = new int[6];
        int numberOfThrows = 6000;

        ThrowDice(diceCounts, numberOfThrows);
        DisplayResults(diceCounts);

    }
    void ThrowDice(int[] diceCounts, int numberOfThrows)
    {

        Random random = new Random();
        for(int i=1; i<numberOfThrows; i++)
        {
            int diceValue = random.Next(1,7);
            diceCounts[diceValue - 1]++;
        }
    }
     void DisplayResults(int[] diceCounts)
    {
        for (int i = 0; i < diceCounts.Length; i++)
        {
            Console.WriteLine($"Number of throws of value  {i + 1} = {diceCounts[i]} ");
        }
    }
}

