using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MasterMind.Chain_of_Responsibility;
using MasterMind.Checker;
using MasterMind.Extentions;
using MasterMind.Generator;
using MasterMind.Iterators;
using MasterMind.score;

namespace MasterMind.Screens
{
    public partial class GameScreen : Form
    {
        List<LineOfPegs> lines = new List<LineOfPegs>();
        List<ResultView> results = new List<ResultView>();
        private List<int> generatedValues;
        private int currentLine = 0;
        public GameScreen()
        {
            InitializeComponent();
        }

        private void GenerateValues()
        {
            Generator.Generator generator = new Generator.Generator(4);
            generator.Generate();
            generatedValues = generator.GetGeneratedColor;
        }

        private void DrawLines()
        {
            for (int i = 0; i < 10; i++)
            {
                LineOfPegs line = new LineOfPegs(i);
                for (int j = 0; j < 4; j++)
                {
                    RoundButton roundButton = new RoundButton();
                    roundButton.Location = new Point(40 + 60 * j, 20 + 40 * i);
                    roundButton.Height = 40;
                    roundButton.Width = 40;
                    roundButton.BackColor = Color.LightGray;
                    roundButton.Show();
                    roundButton.MouseDown += new MouseEventHandler(RoundButton_Click);
                    Controls.Add(roundButton);
                    line.Attach(roundButton);
                }

                if (i == 0)
                {
                    line.IsActive = true;
                    line.Notify();
                }
                lines.Add(line);
            }
        }

        private void DrawResults()
        {
            for (int i = 0; i < 10; i++)
            {
                ResultView line = new ResultView(i);
                for (int j = 0; j < 4; j++)
                {
                    RoundButton roundButton = new RoundButton();
                    roundButton.Location = new Point(280 + 15 * j, 20 + 40 * i);
                    roundButton.Height = 20;
                    roundButton.Width = 20;
                    roundButton.BackColor = Color.LightGray;
                    roundButton.Enabled = false;
                    roundButton.Show();
                    Controls.Add(roundButton);
                    line.Add(roundButton);
                }
                results.Add(line);
            }
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            GenerateValues();
            DrawLines();
            DrawResults();   
        }
        private void RoundButton_Click(object sender, MouseEventArgs e)
        {
            RoundButton btnSender = (RoundButton)sender;
            Clicker left = new LeftClicker();
            Clicker right = new RightClicker();
            Clicker middle = new MiddleClicker();
            left.SetSuccessor(right);
            right.SetSuccessor(middle);
            left.HandleRequest(btnSender, e.Button);
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            lines[currentLine]._roundButtons.ForEach(item => item.SetColor(Color.Gray));
        }

        private void Check_Click(object sender, EventArgs e)
        {
            if (lines[currentLine].CheckForColor())
            {
                IChecker iChecker = new Checker.Checker(results[this.currentLine]);
                Checker.Checker.GeneratedValues = generatedValues;
                LineOfPegs currentLine = lines[this.currentLine];
                bool result = iChecker.Check(currentLine);
                lines[this.currentLine].IsActive = false;
                lines[this.currentLine].Notify();
                if (result)
                {
                    MessageBox.Show("You won");
                    IScore iScore = new score.Score();
                    int score = iScore.CalculateScore(this.currentLine);
                    this.Close();
                    SaveScreen saveScreen = new SaveScreen(true, score);
                    saveScreen.Show();
                }
                else if (!result && this.currentLine == 9)
                {
                    MessageBox.Show("You lose!");
                    int score = 0;
                    this.Close();
                    SaveScreen saveScreen = new SaveScreen(false, score);
                    saveScreen.Show();
                }
                this.currentLine++;
                lines[this.currentLine].IsActive = true;
                lines[this.currentLine].Notify();
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
            StartScreen.StartScreenForm.Show();
        }
    }
}
