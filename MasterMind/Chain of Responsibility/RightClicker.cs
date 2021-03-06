﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MasterMind.Extentions;

namespace MasterMind.Chain_of_Responsibility
{
    class RightClicker : Clicker
    {
        public override void HandleRequest(RoundButton roundButton, MouseButtons button)
        {
            if (button == MouseButtons.Right)
            {
                roundButton.SetColorPrev();
            }
            else if (successor != null)
            {
                successor.HandleRequest( roundButton, button);
            }
        }
    }
}
