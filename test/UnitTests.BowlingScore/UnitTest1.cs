using BowlingScore;

namespace UnitTests.BowlingScore;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    [DataRow(new int[] { }, 0)]
    [DataRow(new int[] { 5 }, 5)]
    [DataRow(new int[] { 5, 4 }, 9)]
    [DataRow(new int[] { 5, 5 }, 10)]
    [DataRow(new int[] { 1, 2, 3 }, 6)]
    [DataRow(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, 20)]
    [DataRow(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, 20)]
    [DataRow(new int[] { 10 }, 10)]
    [DataRow(new int[] { 10, 5 }, 20)]
    [DataRow(new int[] { 5, 5, 3 }, 16)]
    [DataRow(new int[] { 10, 5, 3 }, 26)]
    [DataRow(new int[] { 0, 10, 3 }, 16)]
    [DataRow(new int[] { 0, 10, 3, 5 }, 21)]
    [DataRow(new int[] { 10, 5, 5 }, 30)]
    [DataRow(new int[] { 0, 0, 0, 10, 3, 2 }, 18)]
    [DataRow(new int[] { 0, 0, 10, 3, 2 }, 20)]
    [DataRow(new int[] { 10, 7, 3, 9, 0, 10, 0, 8, 8, 2, 0, 6, 10, 10, 10, 8, 1 }, 167)]
    [DataRow(new int[] { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 }, 300)]
    [DataRow(new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 9, 10, 5 }, 20)]
    [DataRow(new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 10, 10, 10, 10 }, 30)]
    public void TestMethod1(int[] rolls, int expected)
    {
        int score = BowlingScoreCalculator.CalculateBowlingScore(rolls);
        Assert.AreEqual(expected, score);
    }
}