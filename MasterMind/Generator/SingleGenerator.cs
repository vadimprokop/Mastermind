using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMind.Generator
{
    /// <summary>
    /// Generate 1 item
    /// </summary>
    class SingleGenerator : IGenerable
    {
        protected static Random random = new Random();
        protected int randomColor;
        public virtual void Generate()
        {
            randomColor = random.Next(6);
        }
        public virtual int GetRandomColor => randomColor;
    }
}
