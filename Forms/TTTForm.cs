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
    public partial class TicTacToe : Form
    {
        // Important members
        enum CellState
        {
            none,
            X,
            O
        }

        CellState currentTurn = CellState.X;
        private readonly Form frm1;

        // Form constructor
        public TicTacToe(Form frm)
        {
            InitializeComponent();
            this.frm1 = frm;
        }

        // This function will check if there is a winner
        private bool IsWinner(PictureBox pb1, PictureBox pb2, PictureBox pb3)
        {
            if ((CellState)pb1.Tag != CellState.none)
            {
                if (pb1.Tag.ToString() == pb2.Tag.ToString() && pb1.Tag.ToString() == pb3.Tag.ToString())
                {
                    return true;
                }
            }

            return false;
        }

        // This function will send the winning possibilities to IsWinner method
        private void Winner(CellState cellstate)
        {
            if (
                IsWinner(btn0, btn1, btn2) ||
                IsWinner(btn3, btn4, btn5) ||
                IsWinner(btn6, btn7, btn8) ||

                IsWinner(btn0, btn3, btn6) ||
                IsWinner(btn1, btn4, btn7) ||
                IsWinner(btn2, btn5, btn8) ||

                IsWinner(btn0, btn4, btn8) ||
                IsWinner(btn2, btn4, btn6)
               )
            {
                // Notifying the user that there's a winner
                lblMenuText.Text = $"Player {cellstate} Won!";
                // if there is a winner all boxes will be disabled
                DisableallPB();
            }
        }

        // Form load event
        private void TicTacToe_Load(object sender, EventArgs e)
        {
            initiate();
            DisableallPB();
        }

        // This function will reset everything in the game for a new one
        private void initiate()
        {
            foreach (PictureBox pb in this.Controls.OfType<PictureBox>())
            {
                pb.Image = null;
                pb.Tag = CellState.none;
            }

            currentTurn = CellState.X;
        }

        // This function will disable all the boxes
        private void DisableallPB()
        {
            foreach (PictureBox pb in this.Controls.OfType<PictureBox>())
            {
                pb.Enabled = false;   
            }

            btnStart.Enabled = true;
        }

        // This function will enable all the boxes
        private void EnableAllPB()
        {
            foreach (PictureBox pb in this.Controls.OfType<PictureBox>())
            {
                pb.Enabled = true;
            }
        }

        // Form closing event
        private void TicTacToe_FormClosing(object sender, FormClosingEventArgs e) {this.frm1.Show();}

        //Box clicking event
        private void boxClicking(object sender, EventArgs e)
        {

            PictureBox pbox = sender as PictureBox;

            if ((CellState)pbox.Tag != CellState.none)
                return;

            if (currentTurn == CellState.X)
            {
                pbox.Tag = CellState.X;
                pbox.Image = Properties.Resources.Xsymbol;

                Winner(CellState.X);

                currentTurn = CellState.O;
            }
            else
            {
                pbox.Tag = CellState.O;
                pbox.Image = Properties.Resources.Osymbol;

                Winner(CellState.O);

                currentTurn = CellState.X;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            initiate();
        }

        private void btnTTT_Click(object sender, EventArgs e)
        {
            EnableAllPB();
            initiate();
            lblMenuText.Text = "Tic Tac Toe";
            btnStart.Enabled = false;
            btnStart.Text = "Play Again";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            EnableAllPB();
            initiate();
            lblMenuText.Text = "Tic Tac Toe";
            btnStart.Enabled = false;
            btnStart.Text = "Play Again";
        }
    }
}
