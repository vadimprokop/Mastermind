using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMind.score
{
    interface IScore
    {
        int CalculateScore(int currentLine);
    }
}
