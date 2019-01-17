using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MasterMind.Generator;

namespace MasterMind.Checker
{
    interface IChecker
    {
        bool Check(Line line);
    }
}
