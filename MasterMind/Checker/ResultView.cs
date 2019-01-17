using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MasterMind.Extentions;

namespace MasterMind.Checker
{
    class ResultView
    {
        private int _numberOfLine;
        private List<IRoundButton> _roundButtons;
        public ResultView(int numberOfLine)
        {
            this._numberOfLine = numberOfLine;
            _roundButtons = new List<IRoundButton>();
        }

        public void Add(IRoundButton iRoundButton)
        {
            _roundButtons.Add(iRoundButton);
        }
        public IRoundButton this[int index]
        {
            get { return _roundButtons[index]; }
        }
    }
}
