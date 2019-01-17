using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MasterMind.Extentions;

namespace MasterMind.Iterators
{
    class ColorIterator : Iterator
    {
        private Colors _colors;
        private int _current = 0;

        // Constructor
        public ColorIterator(Colors colors)
        {
            this._colors = colors;
        }
        // Gets first iteration item
        public override Color First()
        {
            return _colors[0];
        }
        // Gets next iteration item
        public override Color Next()
        {
            if (_current >= _colors.Count - 1)
            {
                _current -= _colors.Count;
            }
            Color ret= _colors[++_current];
            return ret;
        }
        public override Color Prev()
        {
            if (_current <= 0)
            {
                _current += _colors.Count;
            }
            Color ret = _colors[--_current];
            return ret;
        }
        // Gets current iteration item
        public override Color CurrentItem()
        {
            return _colors[_current];
        }
        // Gets whether iterations are complete
        public override bool IsDone()
        {
            return _current >= _colors.Count;
        }
    }
}