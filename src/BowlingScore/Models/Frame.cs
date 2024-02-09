namespace BowlingScore.Models
{
    public class Frame
    {
        private Frame? NextFrame { get; set; }
        private Frame? SecondNextFrame { get; set; }
        private int FirstRoll { get; }
        private int SecondRoll { get; }

        public Frame(int firstRoll, int secondRoll)
        {
            FirstRoll = firstRoll;
            SecondRoll = secondRoll;
        }

        public bool IsStrike()
        {
            return FirstRoll == 10;
        }

        public bool IsSpare()
        {
            return FirstRoll + SecondRoll == 10;
        }

        public int GetScore()
        {
            int score = FirstRoll + SecondRoll;

            if (IsStrike())
            {
                score += GetStrikeScore();
            }
            else if (IsSpare())
            {
                score += GetSpareScore();
            }

            return score;
        }

        private int GetStrikeScore()
        {
            var strikeScore = NextFrame?.FirstRoll ?? 0;

            if (NextFrame?.IsStrike() == true)
            {
                strikeScore += SecondNextFrame?.FirstRoll ?? 0;
            }
            else
            {
                strikeScore += NextFrame?.SecondRoll ?? 0;
            }

            return strikeScore;
        }

        private int GetSpareScore()
        {
            return NextFrame?.FirstRoll ?? 0;
        }
        public void SetNextFrame(Frame nextFrame)
        {
            NextFrame = nextFrame;
        }

        public void SetSecondNextFrame(Frame secondNextFrame)
        {
            SecondNextFrame = secondNextFrame;
        }
    }
}