using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using MasterMind.Database;

namespace MasterMind.Screens
{
    public partial class StartScreen : Form
    {
        private static StartScreen _startScreen;
        public static StartScreen StartScreenForm
        {
            get
            {
                if (_startScreen == null)
                {
                    _startScreen = new StartScreen();
                }
                return _startScreen;
            }
        }
        private StartScreen()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Score_Click(object sender, EventArgs e)
        {
            Score score = new Score();
            score.Show();
            this.Hide();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            GameScreen difficult = new GameScreen();
            difficult.Show();
            this.Hide();
        }

        private void Mastemind_TextChanged(object sender, EventArgs e)
        {
            Mastemind.ReadOnly = true;
            Mastemind.SelectionAlignment = HorizontalAlignment.Center;
        }
    }
}
