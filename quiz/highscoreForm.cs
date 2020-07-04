using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz
{
    public partial class highscoreForm : Form
    {
        public highscoreForm()
        {
            InitializeComponent();
            var highscorePath = Path.Combine(Directory.GetCurrentDirectory(), "highscores.txt");
            List<string> playersHighscores = File.ReadAllLines(highscorePath).ToList();
            for(int i = 0; i < playersHighscores.Count-1; i++)
            {
                for (int j = i + 1; j < playersHighscores.Count; j++)
                {
                    string[] pom = playersHighscores[i].Split(',');
                    string[] pom1 = playersHighscores[j].Split(',');
                    if (Convert.ToInt32(pom[1]) < Convert.ToInt32(pom1[1]))
                    {
                        string pomosen = playersHighscores[i];
                        playersHighscores[i] = playersHighscores[j];
                        playersHighscores[j] = pomosen;
                    }
                }
            }
                if (playersHighscores.Count != 0 && playersHighscores[0] != "")
                {
                int br = 0;
                    foreach (string line in playersHighscores)
                    {
                        if (br < 5)
                        {
                            string[] highscores = line.Split(',');
                            lblNames.Text += "\n" + highscores[0];
                            lblScores.Text += "\n" + highscores[1];
                            br++;
                        }
                        else
                        {
                            break;
                        }
                    }
                }  
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var myForm = new startForm();
            myForm.ShowDialog();
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            var highscorePath = Path.Combine(Directory.GetCurrentDirectory(), "highscores.txt");
            File.WriteAllText(highscorePath, String.Empty);
            lblNames.Text = "";
            lblScores.Text = "";
        }

        private void asda_Click(object sender, EventArgs e)
        {

        }
    }
}
