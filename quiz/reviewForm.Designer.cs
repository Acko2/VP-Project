namespace quiz
{
    partial class reviewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reviewForm));
            this.lvReview = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.lvQuestion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvCorrectAnswer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvYourAnswer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnHighscore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvReview
            // 
            this.lvReview.BackColor = System.Drawing.Color.Lavender;
            this.lvReview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvReview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvQuestion,
            this.lvCorrectAnswer,
            this.lvYourAnswer});
            this.lvReview.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvReview.FullRowSelect = true;
            this.lvReview.GridLines = true;
            this.lvReview.HideSelection = false;
            this.lvReview.Location = new System.Drawing.Point(32, 96);
            this.lvReview.MultiSelect = false;
            this.lvReview.Name = "lvReview";
            this.lvReview.Size = new System.Drawing.Size(738, 293);
            this.lvReview.TabIndex = 0;
            this.lvReview.UseCompatibleStateImageBehavior = false;
            this.lvReview.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(215, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 90);
            this.label1.TabIndex = 1;
            this.label1.Text = "REVIEWS";
            // 
            // lvQuestion
            // 
            this.lvQuestion.Text = "Question";
            this.lvQuestion.Width = 492;
            // 
            // lvCorrectAnswer
            // 
            this.lvCorrectAnswer.Text = "Correct Answer";
            this.lvCorrectAnswer.Width = 120;
            // 
            // lvYourAnswer
            // 
            this.lvYourAnswer.Text = "Your answer";
            this.lvYourAnswer.Width = 120;
            // 
            // btnHighscore
            // 
            this.btnHighscore.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnHighscore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHighscore.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHighscore.FlatAppearance.BorderSize = 3;
            this.btnHighscore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHighscore.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHighscore.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHighscore.Location = new System.Drawing.Point(32, 395);
            this.btnHighscore.Name = "btnHighscore";
            this.btnHighscore.Size = new System.Drawing.Size(253, 43);
            this.btnHighscore.TabIndex = 3;
            this.btnHighscore.Text = "Highscore";
            this.btnHighscore.UseVisualStyleBackColor = false;
            this.btnHighscore.Click += new System.EventHandler(this.btnHighscore_Click);
            // 
            // reviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHighscore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvReview);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "reviewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "reviewForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvReview;
        private System.Windows.Forms.ColumnHeader lvQuestion;
        private System.Windows.Forms.ColumnHeader lvCorrectAnswer;
        private System.Windows.Forms.ColumnHeader lvYourAnswer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHighscore;
    }
}