using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling
{
    public class Game
    {
        private int[] _rolls = new int[21];
        private int _currentRoll = 0;

        private const int TOTAL_FRAMES = 10;
        private const int SECOND_ROLL = 1;
        private const int MAX_PINS_PER_FRAME = 10;
        private const int NEXT_FRAME_FIRST_ROLL = 2;


        public void Roll( int numberOfPins)
        {
            _rolls[_currentRoll] = numberOfPins;
            _currentRoll++;
        }

        public int ScoreOfGame()
        {
            int score = 0;
            var frameRollNumber = 0;

            for (int frame = 0;frame < TOTAL_FRAMES; frame++)
            {
                if (IsStrike(frameRollNumber))
                {
                    score += StrikeScore(frameRollNumber);
                }
                else
                {
                    score += NonStrikeScore(frameRollNumber);
                }
                frameRollNumber = NextFrameRollNumber(frameRollNumber);
            }
            return score;
        }

        private int NextFrameRollNumber( int frameRollNumber )
        {
            if (IsStrike(frameRollNumber))
                return frameRollNumber + 1;
            else
                return frameRollNumber + NEXT_FRAME_FIRST_ROLL;
        }


        private int NonStrikeScore(int frameRollNumber)
        {
            var frameScore = FrameScore(frameRollNumber);
            if (IsSpare(frameScore))
            {
                return SpareScore(frameScore, frameRollNumber);
            }
            else
            {
                return frameScore;
            }
        }

        private int FrameScore( int frameRollNumber)
        {
            if (IsStrike(frameRollNumber))
                return _rolls[frameRollNumber];
            else
                return _rolls[frameRollNumber] + _rolls[frameRollNumber + SECOND_ROLL];
        }

        private int SpareScore(int frameScore,int frameRollNumber)
        {
            return (frameScore + NextFrameFirstRoll(frameRollNumber));
        }

        private int StrikeScore(int frameRollNumber)
        {
            return (FrameScore(frameRollNumber) + _rolls[frameRollNumber + SECOND_ROLL] + _rolls[frameRollNumber + NEXT_FRAME_FIRST_ROLL]);
        }

        private int NextFrameFirstRoll( int frameRollNumber)
        {
            return _rolls[frameRollNumber + NEXT_FRAME_FIRST_ROLL];
        }

        private bool IsStrike(int frameRollNumber)
        {
            return _rolls[frameRollNumber] == MAX_PINS_PER_FRAME;
        }

        private bool IsSpare(int frameScore)
        {
            return (frameScore == MAX_PINS_PER_FRAME);
        }

    }
}
