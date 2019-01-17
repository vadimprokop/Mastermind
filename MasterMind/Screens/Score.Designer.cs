namespace MasterMind.Screens
{
    partial class Score
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
            this.Menu = new System.Windows.Forms.Button();
            this.scores = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Location = new System.Drawing.Point(170, 563);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(149, 53);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "Menu";
            this.Menu.UseVisualStyleBackColor = true;
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // scores
            // 
            this.scores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.scores.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scores.Location = new System.Drawing.Point(88, 42);
            this.scores.Name = "scores";
            this.scores.Size = new System.Drawing.Size(317, 474);
            this.scores.TabIndex = 1;
            this.scores.Text = "";
            this.scores.TextChanged += new System.EventHandler(this.scores_TextChanged);
            // 
            // Score
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(482, 653);
            this.Controls.Add(this.scores);
            this.Controls.Add(this.Menu);
            this.MaximumSize = new System.Drawing.Size(500, 700);
            this.MinimumSize = new System.Drawing.Size(500, 700);
            this.Name = "Score";
            this.Text = "Score";
            this.Load += new System.EventHandler(this.Score_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Menu;
        private System.Windows.Forms.RichTextBox scores;
    }
}