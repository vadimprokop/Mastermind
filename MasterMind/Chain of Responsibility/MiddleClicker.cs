using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MasterMind.Extentions;

namespace MasterMind.Chain_of_Responsibility
{
    class MiddleClicker : Clicker
    {
        public override void HandleRequest(RoundButton roundButton, MouseButtons button)
        {
            if (button == MouseButtons.Middle)
            {
                roundButton.ResetColor();
            }
            else if (successor != null)
            {
                successor.HandleRequest( roundButton, button);
            }
        }
    }
}
