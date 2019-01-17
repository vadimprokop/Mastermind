using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using MasterMind.Generator;
using MasterMind.Iterators;

namespace MasterMind.Extentions
{
    public class RoundButton : Button, IRoundButton
    {
        static Colors colors;
        private Iterator iterator;
        public RoundButton()
        {
            colors = Colors.CreateColors();
            iterator = colors.CreateIterator();
        }
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            GraphicsPath grPath = new GraphicsPath();
            grPath.AddEllipse(1, 1, ClientSize.Width - 10, ClientSize.Height - 10);
            this.Region = new System.Drawing.Region(grPath);
            base.OnPaint(e);
        }

        public void SetColorNext()
        {
            this.BackColor = (Color)iterator.Next();
        }
        public void SetColorPrev()
        {
            this.BackColor = (Color)iterator.Prev();
        }

        public void ResetColor()
        {
            this.BackColor = Color.Gray;
        }

        void IRoundButton.Update(Line line)
        {
            //Notify
            if (!line.IsActive)
            {
                this.Enabled = false;
            }
            else
            {
                this.BackColor = Color.Gray;
                this.Enabled = true;
            }
        }

        public Color GetColor()
        {
            return this.BackColor;
        }

        public void SetColor(Color color)
        {
            this.BackColor = color;
        }
    }
}