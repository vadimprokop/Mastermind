namespace MasterMind.Screens
{
    partial class SaveScreen
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
            this.Save = new System.Windows.Forms.Button();
            this.DoNotSave = new System.Windows.Forms.Button();
            this.results = new System.Windows.Forms.RichTextBox();
            this.NickName = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(56, 489);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(147, 57);
            this.Save.TabIndex = 0;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // DoNotSave
            // 
            this.DoNotSave.Location = new System.Drawing.Point(276, 489);
            this.DoNotSave.Name = "DoNotSave";
            this.DoNotSave.Size = new System.Drawing.Size(147, 57);
            this.DoNotSave.TabIndex = 1;
            this.DoNotSave.Text = "Do not Save";
            this.DoNotSave.UseVisualStyleBackColor = true;
            this.DoNotSave.Click += new System.EventHandler(this.DoNotSave_Click);
            // 
            // results
            // 
            this.results.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.results.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.results.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.results.Location = new System.Drawing.Point(78, 44);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(324, 96);
            this.results.TabIndex = 2;
            this.results.Text = "";
            this.results.TextChanged += new System.EventHandler(this.results_TextChanged);
            // 
            // NickName
            // 
            this.NickName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NickName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NickName.Location = new System.Drawing.Point(92, 264);
            this.NickName.Name = "NickName";
            this.NickName.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.NickName.Size = new System.Drawing.Size(295, 54);
            this.NickName.TabIndex = 3;
            this.NickName.Text = "";
            this.NickName.TextChanged += new System.EventHandler(this.NickName_TextChanged);
            // 
            // SaveScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(482, 653);
            this.Controls.Add(this.NickName);
            this.Controls.Add(this.results);
            this.Controls.Add(this.DoNotSave);
            this.Controls.Add(this.Save);
            this.MaximumSize = new System.Drawing.Size(500, 700);
            this.MinimumSize = new System.Drawing.Size(500, 700);
            this.Name = "SaveScreen";
            this.Text = "SaveScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button DoNotSave;
        private System.Windows.Forms.RichTextBox results;
        private System.Windows.Forms.RichTextBox NickName;
    }
}