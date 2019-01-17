using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MasterMind.Extentions;

namespace MasterMind.Generator
{
    abstract class Line
    {
        public int _numberOfLine;
        public bool IsActive;
        public List<IRoundButton> _roundButtons;

        public Line(int numberOfLine)
        {
            this.IsActive = false;
            this._numberOfLine = numberOfLine;
            _roundButtons = new List<IRoundButton>();
        }

        public List<IRoundButton> GetButtons()
        {
            return _roundButtons;
        }
        public bool CheckForColor()
        {
            for (int i = 0; i < _roundButtons.Count; i++)
            {
                if (_roundButtons[i].GetColor() == Color.Gray)
                {
                    return false;
                }
            }
            return true;
        }

        public void Attach(IRoundButton roundButton)
        {
            _roundButtons.Add(roundButton);
        }
        public void Detach(IRoundButton roundButton)
        {
            _roundButtons.Remove(roundButton);
        }
        public void Notify()
        {
            foreach (IRoundButton roundButton in _roundButtons)
            {
                roundButton.Update(this);
            }
        }
    }
}
