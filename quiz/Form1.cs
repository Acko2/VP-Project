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
    public partial class Form1 : Form
    {
        
        List<Question> questions = new List<Question>();
        public static List<Review> reviews = new List<Review>();
        int questionPosition = 0;
        int points = 0;
        int tleft = 30;
        int[] nums = Enumerable.Range(0, 10).ToArray();
        int[] nums2 = { 1, 2, 3, 4 };
        
        Random rnd = new Random();



        private void pickQuestion()
        {
            lblQuestion.Text = questions[nums[questionPosition]].question;
            btnAnswer1.Text = questions[nums[questionPosition]].answer1;
            btnAnswer2.Text = questions[nums[questionPosition]].answer2;
            btnAnswer3.Text = questions[nums[questionPosition]].answer3;
            btnAnswer4.Text = questions[nums[questionPosition]].answer4;
        }
        public Form1()
        {
            InitializeComponent();
            Console.WriteLine(nums);
            reviews.Clear();
            // Shuffle the array
            for (int i = 0; i < nums.Length; ++i)
            {
                int randomIndex = rnd.Next(nums.Length);
                int temp = nums[randomIndex];
                nums[randomIndex] = nums[i];
                nums[i] = temp;
            }
            timer1.Start();
            var path = "";
            if (startForm.category == "history")
            {
                 path = Path.Combine(Directory.GetCurrentDirectory(), "historyQuestions.txt");
            }
            else if (startForm.category == "trivia")
            {
                 path = Path.Combine(Directory.GetCurrentDirectory(), "triviaQuestions.txt");
            }
            else
            {
                 path = Path.Combine(Directory.GetCurrentDirectory(), "geographyQuestions.txt");
            }
            
            List<string> questionsFromFile = File.ReadAllLines(path).ToList();

            for (int i = 0; i < nums2.Length; ++i)
            {
                int randomIndex = rnd.Next(nums2.Length);
                int temp = nums2[randomIndex];
                nums2[randomIndex] = nums2[i];
                nums2[i] = temp;
            }
            
            foreach (var line in questionsFromFile)
            {
                string[] parts = line.Split(',');
                Question question = new Question();
                question.question = parts[0];
                question.answer1 = parts[nums2[0]];
                question.answer2 = parts[nums2[1]];
                question.answer3 = parts[nums2[2]];
                question.answer4 = parts[nums2[3]];
                question.correntAnswer = parts[5];
                questions.Add(question);
            }

            pickQuestion();


        }

        private void addQuestionForReview(string btnAnswer)
        {
            Review review = new Review();
            review.Question = questions[nums[questionPosition]].question;
            review.correctAnswer = questions[nums[questionPosition]].correntAnswer;
            review.yourAnswer = btnAnswer;
            reviews.Add(review);
        }

        private void showHighscores()
        {
            var highscorePath = Path.Combine(Directory.GetCurrentDirectory(), "highscores.txt");
            List<string> output = new List<String>();
            output.Add($"{startForm.playerName},{points}");
            File.AppendAllLines(highscorePath, output);
            timer1.Stop();
            for (int i = 0; i < nums2.Length; ++i)
            {
                int randomIndex = rnd.Next(nums2.Length);
                int temp = nums2[randomIndex];
                nums2[randomIndex] = nums2[i];
                nums2[i] = temp;
            }
            this.Hide();
            var myForm = new reviewForm();
            myForm.ShowDialog();
            this.Close();
        }
        private void checkAnswer(object sender, EventArgs e)
        {
            var button = (Button)sender;
            string buttonAnswer = button.Text;

            addQuestionForReview(buttonAnswer);


            if (buttonAnswer == questions[nums[questionPosition]].correntAnswer)
            {
                points++;
                
            }
            questionPosition++;

            tleft = 30;
            if(questionPosition < 10)
            {
                pickQuestion();
            }
            else
            {
                showHighscores();
                timer1.Stop();
                
            }
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = tleft + " seconds";
            if(tleft > 0)
            {
                tleft -= 1;
                timeLabel.Text = tleft + " seconds";
            }
            else
            {
                questionPosition++;
                addQuestionForReview("No answer");
                if (questionPosition < 10)
                {
                    tleft = 30;
                    pickQuestion();
                }
                else
                {
                    showHighscores();
                }
            }
        }
    }
}
