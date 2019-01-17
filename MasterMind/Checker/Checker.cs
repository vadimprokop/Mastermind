using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MasterMind.Extentions;
using MasterMind.Generator;

namespace MasterMind.Checker
{
    class Checker : IChecker
    {
        public static List<int> GeneratedValues;
        private ResultView results;
        private Colors colors;

        public Checker(ResultView results)
        {
            this.results = results; 
            colors = Colors.CreateColors();
        }

        public bool Check(Line line)
        {
            List<IRoundButton> roundButtons = line.GetButtons();
            List<Color> currentColors = new List<Color>();
            bool checkAll = true;
            for (int i = 0; i < GeneratedValues.Count; i++)
            {
                Color color = colors[GeneratedValues[i]];
                if (!currentColors.Contains(color))
                {
                    currentColors.Add(color);
                }
            }
            for (int i = 0; i < roundButtons.Count; i++)
            {
                if (roundButtons[i].GetColor() == colors[GeneratedValues[i]])
                {
                    results[i].SetColor(Color.Black);
                    currentColors.Remove(colors[GeneratedValues[i]]);
                }
                else
                {
                    checkAll = false;
                }
            }
            for (int i = 0; i < roundButtons.Count; i++)
            {
                if (currentColors.Contains(roundButtons[i].GetColor()))
                {
                    results[i].SetColor(Color.White);
                }
            }
            return checkAll;
        }
    }
}
