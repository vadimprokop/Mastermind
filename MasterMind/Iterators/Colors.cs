using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MasterMind.Iterators;

namespace MasterMind.Extentions
{
    class Colors : Aggregate
    {
        private static Colors instance;
        private static Dictionary<int, Color> colors = new Dictionary<int, Color>();
        private Colors(){}
        public static Colors CreateColors()
        {
            if (colors.Count == 0 && instance == null)
            {
                instance = new Colors();
                colors.Add(0, Color.Blue);
                colors.Add(1, Color.Red);
                colors.Add(2, Color.Green);
                colors.Add(3, Color.Gold);
                colors.Add(4, Color.Orange);
                colors.Add(5, Color.Brown);
            }
            return instance;
        }

        public override Iterator CreateIterator()
        {
            return new ColorIterator(this);
        }

        // Indexer
        public Color this[int index]
        {
            get { return colors[index]; }
        }

        public int Count => colors.Count;
    }
}
