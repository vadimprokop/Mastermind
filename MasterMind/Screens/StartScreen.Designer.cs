namespace MasterMind.Screens
{
    partial class StartScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Exit = new System.Windows.Forms.Button();
            this.Score = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.Mastemind = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(143, 540);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(200, 60);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Score
            // 
            this.Score.Location = new System.Drawing.Point(143, 438);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(200, 60);
            this.Score.TabIndex = 1;
            this.Score.Text = "Score";
            this.Score.UseVisualStyleBackColor = true;
            this.Score.Click += new System.EventHandler(this.Score_Click);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(143, 327);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(200, 60);
            this.Start.TabIndex = 2;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Mastemind
            // 
            this.Mastemind.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Mastemind.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Mastemind.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mastemind.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Mastemind.Location = new System.Drawing.Point(100, 42);
            this.Mastemind.Name = "Mastemind";
            this.Mastemind.Size = new System.Drawing.Size(320, 50);
            this.Mastemind.TabIndex = 3;
            this.Mastemind.Text = "MASTERMIND";
            this.Mastemind.TextChanged += new System.EventHandler(this.Mastemind_TextChanged);
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(482, 653);
            this.Controls.Add(this.Mastemind);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.Exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(500, 700);
            this.MinimumSize = new System.Drawing.Size(500, 700);
            this.Name = "StartScreen";
            this.Text = "StartScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Score;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.RichTextBox Mastemind;
    }
}