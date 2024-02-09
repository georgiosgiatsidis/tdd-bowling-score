namespace BowlingScore
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

    public static class BowlingScoreCalculator
    {
        public static int CalculateBowlingScore(int[] rolls)
        {
            var frames = GenerateFramesFromRolls(rolls);
            ConnectFrames(frames);
            return CalculateScoreFromFrames(frames);
        }

        private static int CalculateScoreFromFrames(Frame[] frames)
        {
            int score = 0;

            for (int i = 0; i < frames.Length && i < 10; i++)
            {
                score += frames[i].GetScore();
            }

            return score;
        }

        private static Frame[] GenerateFramesFromRolls(int[] rolls)
        {
            var frames = new List<Frame>();

            for (int i = 0; i < rolls.Length; i++)
            {
                int firstRoll = rolls[i];
                if (firstRoll == 10)
                {
                    frames.Add(new Frame(firstRoll, 0));
                }
                else
                {
                    if (i + 1 < rolls.Length)
                    {
                        int secondRoll = rolls[i + 1];
                        frames.Add(new Frame(firstRoll, secondRoll));
                        i += 1;
                    }
                    else
                    {
                        frames.Add(new Frame(firstRoll, 0));
                    }
                }
            }

            return frames.ToArray();
        }

        private static void ConnectFrames(Frame[] frames)
        {
            for (int i = 0; i < frames.Length && i < 10; i++)
            {
                if (i + 1 < frames.Length)
                {
                    frames[i].SetNextFrame(frames[i + 1]);
                }
                if (i + 2 < frames.Length)
                {
                    frames[i].SetSecondNextFrame(frames[i + 2]);
                }
            }
        }
    }
}