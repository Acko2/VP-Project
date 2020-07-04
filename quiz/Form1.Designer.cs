namespace quiz
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnAnswer1 = new System.Windows.Forms.Button();
            this.btnAnswer2 = new System.Windows.Forms.Button();
            this.btnAnswer3 = new System.Windows.Forms.Button();
            this.btnAnswer4 = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAnswer1
            // 
            this.btnAnswer1.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAnswer1.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnAnswer1.FlatAppearance.BorderSize = 3;
            this.btnAnswer1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnswer1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswer1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAnswer1.Location = new System.Drawing.Point(111, 263);
            this.btnAnswer1.Name = "btnAnswer1";
            this.btnAnswer1.Size = new System.Drawing.Size(263, 43);
            this.btnAnswer1.TabIndex = 0;
            this.btnAnswer1.TabStop = false;
            this.btnAnswer1.Tag = "1";
            this.btnAnswer1.Text = "button1";
            this.btnAnswer1.UseVisualStyleBackColor = false;
            this.btnAnswer1.Click += new System.EventHandler(this.checkAnswer);
            // 
            // btnAnswer2
            // 
            this.btnAnswer2.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAnswer2.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnAnswer2.FlatAppearance.BorderSize = 3;
            this.btnAnswer2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnswer2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswer2.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAnswer2.Location = new System.Drawing.Point(434, 263);
            this.btnAnswer2.Name = "btnAnswer2";
            this.btnAnswer2.Size = new System.Drawing.Size(263, 43);
            this.btnAnswer2.TabIndex = 1;
            this.btnAnswer2.TabStop = false;
            this.btnAnswer2.Tag = "2";
            this.btnAnswer2.Text = "button2";
            this.btnAnswer2.UseVisualStyleBackColor = false;
            this.btnAnswer2.Click += new System.EventHandler(this.checkAnswer);
            // 
            // btnAnswer3
            // 
            this.btnAnswer3.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAnswer3.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnAnswer3.FlatAppearance.BorderSize = 3;
            this.btnAnswer3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnswer3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswer3.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAnswer3.Location = new System.Drawing.Point(111, 349);
            this.btnAnswer3.Name = "btnAnswer3";
            this.btnAnswer3.Size = new System.Drawing.Size(263, 43);
            this.btnAnswer3.TabIndex = 2;
            this.btnAnswer3.TabStop = false;
            this.btnAnswer3.Tag = "3";
            this.btnAnswer3.Text = "button3";
            this.btnAnswer3.UseVisualStyleBackColor = false;
            this.btnAnswer3.Click += new System.EventHandler(this.checkAnswer);
            // 
            // btnAnswer4
            // 
            this.btnAnswer4.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAnswer4.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnAnswer4.FlatAppearance.BorderSize = 3;
            this.btnAnswer4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnswer4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswer4.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAnswer4.Location = new System.Drawing.Point(434, 349);
            this.btnAnswer4.Name = "btnAnswer4";
            this.btnAnswer4.Size = new System.Drawing.Size(263, 43);
            this.btnAnswer4.TabIndex = 3;
            this.btnAnswer4.TabStop = false;
            this.btnAnswer4.Tag = "4";
            this.btnAnswer4.Text = "button4";
            this.btnAnswer4.UseVisualStyleBackColor = false;
            this.btnAnswer4.Click += new System.EventHandler(this.checkAnswer);
            // 
            // lblQuestion
            // 
            this.lblQuestion.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblQuestion.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.Color.Gold;
            this.lblQuestion.Location = new System.Drawing.Point(111, 73);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(586, 124);
            this.lblQuestion.TabIndex = 4;
            this.lblQuestion.Text = "label1";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.Color.White;
            this.timeLabel.Location = new System.Drawing.Point(672, 23);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(0, 23);
            this.timeLabel.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.btnAnswer4);
            this.Controls.Add(this.btnAnswer3);
            this.Controls.Add(this.btnAnswer2);
            this.Controls.Add(this.btnAnswer1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Why are you looking here? Answer the question :)!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnswer1;
        private System.Windows.Forms.Button btnAnswer2;
        private System.Windows.Forms.Button btnAnswer3;
        private System.Windows.Forms.Button btnAnswer4;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timeLabel;
    }
}

