using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DecideForMe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.ss = new Setup();
            DecideForMe.Program.ss.Show();
            this.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.label2.Text = "Allows you to decide any word or sentence. For example: blueberry, strawberry, lemon or apple.";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.label2.Text = "Allows you to decide from any integer. For example 1;2;3;4;5 or 6 (standard dice).";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.label2.Text = "Allows you to decide from any image you choose from your computer and then display the result. For example a cat, a dog or a monkey.";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            this.label2.Text = "Allows you to decide from any color and display it. For example red, green or blue.";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            this.label2.Text = "Allows you to decide from any program or script you'd like to run. For example: Solitaire, Minesweeper or Purble Place?";
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            this.label2.Text = "Allows you to decide between a yes or a no. For example: Will I do it? Yes or no?";
        }

        private void Form1_LocationChanged(object sender, EventArgs e)
        {
            Program.ss.StartPosition = FormStartPosition.Manual;
            Program.ss.Location = this.Location;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Program.ss.Size = this.Size;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked == true)
            {
                radioButton8.Checked = true;
                radioButton7.Checked = false;
                radioButton8.Checked = false;
                radioButton7.Checked = true;
                groupBox1.Visible = false;
                groupBox2.Visible = true;
            }
            else if (this.checkBox1.Checked == false)
            {
                radioButton2.Checked = false;
                radioButton1.Checked = true;
                groupBox1.Visible = true;
                groupBox2.Visible = false;
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "Decides a random integer from 1 to 6.";
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "Decides a random color from red, blue, yellow, orange, green and fuschia";
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "Decides if you are talking truth or you're lying.";
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "Decides a random integer between 1 and 3.";
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "Decides a random letter from the alphabet (A-Z).";
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "Decides to launch an accessory in Windows.";
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "Allows you to easily add a range of numbers to the list and then decide the one.";
        }
    }
}
