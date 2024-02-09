using BowlingScore;

class Program
{
    static void Main()
    {
        int[] rolls = { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 };

        int score = BowlingScoreCalculator.CalculateBowlingScore(rolls);
        Console.WriteLine(score);
    }
}
