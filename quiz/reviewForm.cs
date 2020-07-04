using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz
{
    public partial class reviewForm : Form
    {
        public reviewForm()
        {
            InitializeComponent();
            
            foreach( var review in Form1.reviews)
            {
                var row = new string[] { review.Question, review.correctAnswer, review.yourAnswer };
                var lrow = new ListViewItem(row);
                if(review.correctAnswer == review.yourAnswer)
                {
                    lrow.BackColor = Color.LightGreen;
                }
                else
                {
                    lrow.BackColor = Color.LightSalmon;
                }
                
                lvReview.Items.Add(lrow);
            }
        }

        private void btnHighscore_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            var myForm = new highscoreForm();
            myForm.ShowDialog();
            this.Close();
        }
    }
}
