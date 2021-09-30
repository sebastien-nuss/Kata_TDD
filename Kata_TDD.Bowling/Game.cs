using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_TDD.Bowling
{
    public class Game
    {
        private int[] rolls = new int[21];
        private int currentRoll = 0;

        public Game()
        {
            
        }

        public void Roll(int pins)
        {
            rolls[currentRoll++] = pins;
        }

        public int Score()
        {
            int score = 0;
            int frameIndex = 0;
            for (int frame = 0; frame < 10; frame++)
            {
                if (IsStrike(frameIndex))
                {
                    score += StrikeBonus(frameIndex);
                    frameIndex++;
                }
                else if (IsSpare(frameIndex))
                {
                    score += SpareBonus(frameIndex);
                    frameIndex += 2;
                }
                else
                {
                    score += SumOfAFrame(frameIndex);
                    frameIndex += 2;
                }

            }
            return score;
        }

        private int StrikeBonus(int frameIndex)
        {
            return 10 + rolls[frameIndex + 1] + rolls[frameIndex + 2];
        }

        private int SpareBonus(int frameIndex)
        {
            return 10 + rolls[frameIndex + 2];
        }

        private int SumOfAFrame(int frameIndex)
        {
            return rolls[frameIndex] + rolls[frameIndex + 1];
        }

        private bool IsSpare(int frameIndex)
        {
            return rolls[frameIndex] + rolls[frameIndex + 1] == 10;
        }

        private bool IsStrike(int frameIndex)
        {
            return rolls[frameIndex] == 10;
        }

        public override string ToString()
        {
            string str = "";
            for (int rollIndex = 0; rollIndex < rolls.Length; rollIndex++)
            {
                str += rolls[rollIndex] + ", ";
            }
            return str;
        }
    }


}
