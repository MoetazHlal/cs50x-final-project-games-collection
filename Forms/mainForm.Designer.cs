namespace CS50XFinalProject
{
    partial class mainForm
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
            this.btnGuessTN = new System.Windows.Forms.Button();
            this.btnTTT = new System.Windows.Forms.Button();
            this.btnRPS = new System.Windows.Forms.Button();
            this.lblMenuText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGuessTN
            // 
            this.btnGuessTN.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnGuessTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuessTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGuessTN.Location = new System.Drawing.Point(273, 151);
            this.btnGuessTN.Name = "btnGuessTN";
            this.btnGuessTN.Size = new System.Drawing.Size(217, 34);
            this.btnGuessTN.TabIndex = 0;
            this.btnGuessTN.Text = "Guess the number";
            this.btnGuessTN.UseVisualStyleBackColor = false;
            this.btnGuessTN.Click += new System.EventHandler(this.btnGuessTN_Click);
            this.btnGuessTN.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btnGuessTN.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnGuessTN.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btnGuessTN.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // btnTTT
            // 
            this.btnTTT.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnTTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTTT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTTT.Location = new System.Drawing.Point(273, 191);
            this.btnTTT.Name = "btnTTT";
            this.btnTTT.Size = new System.Drawing.Size(217, 34);
            this.btnTTT.TabIndex = 1;
            this.btnTTT.Text = "Tic Tac Toe";
            this.btnTTT.UseVisualStyleBackColor = false;
            this.btnTTT.Click += new System.EventHandler(this.btnTTT_Click);
            this.btnTTT.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btnTTT.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnTTT.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btnTTT.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // btnRPS
            // 
            this.btnRPS.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnRPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRPS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRPS.Location = new System.Drawing.Point(273, 231);
            this.btnRPS.Name = "btnRPS";
            this.btnRPS.Size = new System.Drawing.Size(217, 34);
            this.btnRPS.TabIndex = 2;
            this.btnRPS.Text = "Rock Paper Scissors";
            this.btnRPS.UseVisualStyleBackColor = false;
            this.btnRPS.Click += new System.EventHandler(this.btnRPS_Click);
            this.btnRPS.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btnRPS.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnRPS.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btnRPS.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // lblMenuText
            // 
            this.lblMenuText.AutoSize = true;
            this.lblMenuText.BackColor = System.Drawing.Color.Transparent;
            this.lblMenuText.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMenuText.Location = new System.Drawing.Point(213, 80);
            this.lblMenuText.Name = "lblMenuText";
            this.lblMenuText.Size = new System.Drawing.Size(328, 42);
            this.lblMenuText.TabIndex = 3;
            this.lblMenuText.Text = "Games Collection";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CS50XFinalProject.Properties.Resources.menubg_50;
            this.ClientSize = new System.Drawing.Size(768, 450);
            this.Controls.Add(this.lblMenuText);
            this.Controls.Add(this.btnRPS);
            this.Controls.Add(this.btnTTT);
            this.Controls.Add(this.btnGuessTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "mainForm";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuessTN;
        private System.Windows.Forms.Button btnTTT;
        private System.Windows.Forms.Button btnRPS;
        private System.Windows.Forms.Label lblMenuText;
    }
}

