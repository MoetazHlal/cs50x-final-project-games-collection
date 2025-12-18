using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS50XFinalProject
{
    public partial class GuessTN : Form
    {
        // Important members
        private readonly Form frm1;
        private int secretNum = -1;
        private int score = 0;

        // Form constructor
        public GuessTN(Form frm)
        {
            InitializeComponent();
            this.frm1 = frm;
        }

        // Form closing event
        private void GuessTN_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm1.Show();
        }

        // This function generates limited random number
        private int RandomNum(int min, int max)
        {
            Random random = new Random();
            int secretNumber = random.Next(min, max);
            return secretNumber;
        }

        // this func generates a random number based on user's score
        private void scoreBased_numGen()
        {
            int max = 0;

            if (score < 100)
            {
                if (score >= 0)
                {
                    secretNum = RandomNum(0, 5);
                    max = 5;
                }

                if (score >= 10)
                {
                    secretNum = RandomNum(0, 10);
                    max = 10;
                }


                if (score >= 20)
                {
                    secretNum = RandomNum(0, 15);
                    max = 15;
                }


                if (score >= 50)
                {
                    secretNum = RandomNum(0, 20);
                    max = 20;
                }


                if (score >= 65)
                {
                    secretNum = RandomNum(0, 25);
                    max = 25;
                }
            }

            else
            {
                secretNum = RandomNum(0, 35);
                max = 65;
            }

            lblMenuText.Text = "Guess a number between 0 - " + max.ToString();
        }

        // Start button click event
        private void BtnStart_Click(object sender, EventArgs e)
        {
            scoreBased_numGen();
            btnStart.Enabled = false;
            textBox1.Enabled = true;
            btnGuessTN.Enabled = true;
        }

        // Guess button event
        private void btnGuessTN_Click(object sender, EventArgs e)
        {
            int answer = 0;
            // Validating if input is correct
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                int.TryParse(textBox1.Text, out answer);

                // If user's guess is correct
                if(answer == secretNum)
                {
                    // Adds 2 points to the score
                    score += 2;
                    // Telling the user that they answered correctly
                    label2.ForeColor = Color.Green;
                    label2.Text = "Correct ✅";
                    // Generates another number
                    scoreBased_numGen();
                    
                }
                // If user's guess is incorrect
                else
                {
                    // If user's score is more than 25
                    // then we remove (1 point) from their score
                    if (score >= 25) {score -= 1;}

                    // If answer is more than the secretNumber
                    if(answer > secretNum)
                    {
                        label2.Text = "High 🔺";
                        label2.ForeColor = Color.Red;
                    }

                    // If answer is less than the secretNumber
                    else if(answer < secretNum)
                    {
                        label2.ForeColor = Color.SteelBlue;
                        label2.Text = "Low 🔻";
                    }
                }

            }

            // Displaying the score in the UI
            label1.Text = "Score: " + score.ToString();
        }
    }
}
