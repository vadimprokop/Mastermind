using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MasterMind.Extentions;

namespace MasterMind.Generator
{
    /// <summary>
    /// Generate values for game
    /// </summary>
    class Generator : IGenerable
    {
        private readonly int _amount;
        public readonly List<int> GeneratedValues;
        private readonly SingleGenerator _singleGenerator;
        public Generator(int amount)
        {
            this._amount = amount;
            GeneratedValues = new List<int>();
            _singleGenerator = new SingleGeneratorV2();
        }
        public void Generate()
        {
            for (int i = 0; i < _amount; i++)
            {
                _singleGenerator.Generate();
                GeneratedValues.Add(_singleGenerator.GetRandomColor);
            }
        }
        public List<int> GetGeneratedColor => GeneratedValues;
    }
}
