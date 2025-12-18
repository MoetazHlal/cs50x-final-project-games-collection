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
    public partial class RPSForm : Form
    {
        // Important members
        Form frm1;
        int score = 0;


        //Form constructor
        public RPSForm(Form frm)
        {
            InitializeComponent();
            this.frm1 = frm;    
        }

        // This function will generate a limited random number
        private int RandomNum(int min, int max)
        {
            Random random = new Random();
            int secretNumber = random.Next(min, max);
            return secretNumber;
        }

        // This function will validate if there's a winner
        private bool Winner(Button btn, int number)
        {

            if (btn.Tag.ToString() == "1" && number == 3)
            {
                return true;
            }

            else if (btn.Tag.ToString() == "2" && number == 1)
            {
                return true;
            }

            else if(btn.Tag.ToString() == "3" && number == 2)
            {
                return true;
            }

            else
            {
                return false;
            }

        }

        // Form closing event
        private void RPSForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm1.Show();
        }

        // Button click event
        private void ButtonClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int random = RandomNum(1, 3);
            
            if (Winner(btn, random) && btn.Tag.ToString() != random.ToString())
            {
                lblMenuText.ForeColor = Color.Green;
                score += 2;
                lblMenuText.Text = "You Won 🏆";
            }

            else
            {
                if(btn.Tag.ToString() == random.ToString())
                {
                    lblMenuText.ForeColor = Color.SteelBlue;
                    lblMenuText.Text = "Tie 🤝";
                }

                else if (random == 1)
                {
                    lblMenuText.ForeColor = Color.IndianRed;
                    lblMenuText.Text = "You lost ⛰️";
                }

                else if (random == 2)
                {
                    lblMenuText.ForeColor = Color.IndianRed;
                    lblMenuText.Text = "You lost 📃";
                }

                else if (random == 3)
                {
                    lblMenuText.ForeColor = Color.IndianRed;
                    lblMenuText.Text = "You lost ✂";
                }

                if(score > 10 && !(btn.Tag.ToString() == random.ToString()))
                {
                    score -= 1;
                }
            }
            label1.Text = "Score: " + score.ToString();
        }
    }
}
