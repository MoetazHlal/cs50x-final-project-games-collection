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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.LightSteelBlue;
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.LightSkyBlue;
        }

        private void btn_MouseDown(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.SteelBlue;
        }

        private void btn_MouseUp(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.LightSteelBlue;
        }

        private void btnGuessTN_Click(object sender, EventArgs e)
        {
            GuessTN frm = new GuessTN(this);
            frm.Show();
            this.Hide();
        }

        private void btnTTT_Click(object sender, EventArgs e)
        {
            TicTacToe frm = new TicTacToe(this);
            frm.Show();
            this.Hide();
        }

        private void btnRPS_Click(object sender, EventArgs e)
        {
            RPSForm frm = new RPSForm(this);

            frm.Show();
            this.Hide();
        }
    }
}
