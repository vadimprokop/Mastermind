using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MasterMind.Extentions;

namespace MasterMind.Chain_of_Responsibility
{
    abstract class Clicker
    {
        protected Clicker successor;
        public void SetSuccessor(Clicker successor)
        {
            this.successor = successor;
        }
        public abstract void HandleRequest(RoundButton roundButton, MouseButtons button);

    }
}
