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
    public partial class SaveScreen : Form
    {
        private bool result;
        private int score;
        public SaveScreen(bool result, int score)
        {
            InitializeComponent();
            this.result = result;
            this.score = score;
            results.AppendText(result ? "You won" : "You lost");
            results.AppendText("\nYour score is " + score);
            results.AppendText("\nPlease enter your name:");
        }

        private void results_TextChanged(object sender, EventArgs e)
        {
            results.ReadOnly = true;
            results.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string nickName = NickName.Text;
            WriteToDataBase(nickName);
            this.Close();
            StartScreen.StartScreenForm.Show();
        }

        private void WriteToDataBase(String nickName)
        {
            DatabaseOperations databaseOperations = new DatabaseOperations();
            databaseOperations.WriteToDatabase(nickName, score);
        }

        private void DoNotSave_Click(object sender, EventArgs e)
        {
            this.Close();
            StartScreen.StartScreenForm.Show();
        }

        private void NickName_TextChanged(object sender, EventArgs e)
        {
            NickName.SelectionAlignment = HorizontalAlignment.Center;
        }
    }
}
