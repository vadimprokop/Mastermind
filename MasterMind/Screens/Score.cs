using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MasterMind.Database;

namespace MasterMind.Screens
{
    public partial class Score : Form
    {
        public Score()
        {
            InitializeComponent();
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            this.Close();
            StartScreen.StartScreenForm.Show();
        }

        private void Score_Load(object sender, EventArgs e)
        {
            List<string> results = DatabaseOperations.GetResults();
            results.ForEach(item =>
            {
                scores.AppendText(item + "\n");
            });
        }

        private void scores_TextChanged(object sender, EventArgs e)
        {
            scores.SelectAll();
            scores.SelectionAlignment = HorizontalAlignment.Center;
            scores.DeselectAll();
        }
    }
}
