using System.Drawing;

namespace MasterMind.Iterators
{
    abstract class Iterator
    {
        public abstract Color First();
        public abstract Color Next();
        public abstract Color Prev();
        public abstract bool IsDone();
        public abstract Color CurrentItem();
    }
}
