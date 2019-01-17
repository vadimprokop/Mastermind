using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MasterMind.Generator;

namespace MasterMind.Extentions
{
    interface IRoundButton
    {
        void Update(Line line);
        Color GetColor();
        void SetColor(Color color);
    }
}
