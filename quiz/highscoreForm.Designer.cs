namespace quiz
{
    partial class highscoreForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(highscoreForm));
            this.label1 = new System.Windows.Forms.Label();
            this.lblNames = new System.Windows.Forms.Label();
            this.lblScores = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.asda = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(163, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 90);
            this.label1.TabIndex = 0;
            this.label1.Text = "HIGHSCORES";
            // 
            // lblNames
            // 
            this.lblNames.AutoSize = true;
            this.lblNames.BackColor = System.Drawing.Color.Transparent;
            this.lblNames.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNames.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblNames.Location = new System.Drawing.Point(249, 160);
            this.lblNames.Name = "lblNames";
            this.lblNames.Size = new System.Drawing.Size(30, 32);
            this.lblNames.TabIndex = 1;
            this.lblNames.Text = "s";
            // 
            // lblScores
            // 
            this.lblScores.AutoSize = true;
            this.lblScores.BackColor = System.Drawing.Color.Transparent;
            this.lblScores.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScores.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblScores.Location = new System.Drawing.Point(455, 160);
            this.lblScores.Name = "lblScores";
            this.lblScores.Size = new System.Drawing.Size(93, 32);
            this.lblScores.TabIndex = 2;
            this.lblScores.Text = "Score";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(229, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 52);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // asda
            // 
            this.asda.AutoSize = true;
            this.asda.BackColor = System.Drawing.Color.Transparent;
            this.asda.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asda.ForeColor = System.Drawing.Color.Gold;
            this.asda.Location = new System.Drawing.Point(441, 140);
            this.asda.Name = "asda";
            this.asda.Size = new System.Drawing.Size(126, 52);
            this.asda.TabIndex = 4;
            this.asda.Text = "Score";
            this.asda.Click += new System.EventHandler(this.asda_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnBack.FlatAppearance.BorderSize = 3;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBack.Location = new System.Drawing.Point(32, 376);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(119, 41);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnClear.FlatAppearance.BorderSize = 3;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnClear.Location = new System.Drawing.Point(638, 376);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(119, 41);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // highscoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.asda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblScores);
            this.Controls.Add(this.lblNames);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "highscoreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "highscoreForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNames;
        private System.Windows.Forms.Label lblScores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label asda;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClear;
    }
}