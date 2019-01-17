using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMind.score
{
    class Score : IScore
    {
        public const int MaxValue = 10000;

        public int CalculateScore(int currentLine)
        {
            return MaxValue - 1000 * currentLine;
        }
    }
}
