namespace quiz
{
    partial class startForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(startForm));
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnHighscore = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.Gold;
            this.lblHeader.Location = new System.Drawing.Point(194, 38);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(399, 99);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "QUIZ";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnStart.FlatAppearance.BorderSize = 3;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnStart.Location = new System.Drawing.Point(274, 229);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(253, 43);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start quiz";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnHighscore
            // 
            this.btnHighscore.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnHighscore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHighscore.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnHighscore.FlatAppearance.BorderSize = 3;
            this.btnHighscore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHighscore.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHighscore.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnHighscore.Location = new System.Drawing.Point(274, 290);
            this.btnHighscore.Name = "btnHighscore";
            this.btnHighscore.Size = new System.Drawing.Size(253, 43);
            this.btnHighscore.TabIndex = 2;
            this.btnHighscore.Text = "Highscore";
            this.btnHighscore.UseVisualStyleBackColor = false;
            this.btnHighscore.Click += new System.EventHandler(this.btnHighscore_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnExit.FlatAppearance.BorderSize = 3;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnExit.Location = new System.Drawing.Point(274, 349);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(253, 43);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Lavender;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtName.Location = new System.Drawing.Point(274, 184);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(253, 34);
            this.txtName.TabIndex = 4;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblName.Location = new System.Drawing.Point(269, 151);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(177, 24);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Enter your name";
            // 
            // startForm
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnHighscore);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblHeader);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "startForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnHighscore;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
    }
}