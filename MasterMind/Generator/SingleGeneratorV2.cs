using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMind.Generator
{
    class SingleGeneratorV2 : SingleGenerator
    {
        public override void Generate()
        {
            randomColor = random.Next(-1, 5);
        }
        public override int GetRandomColor => randomColor + 1;
    }
}
