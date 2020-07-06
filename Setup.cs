using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
namespace DecideForMe
{
    public partial class Setup : Form
    {
        bool close = false;
        public Setup()
        {
            InitializeComponent();
        }

        private void Setup_Load(object sender, EventArgs e)
        {
            this.Location = Program.ms.Location;
            this.Size = Program.ms.Size;
            this.WindowState = Program.ms.WindowState;
            if (Program.ms.checkBox1.Checked == true)
            {
                if (Program.ms.radioButton13.Checked == true)
                {
                    this.label10.Visible = true;
                    this.label10.Text = "This is a predefined template. It does not require setup.";
                    this.button8.Enabled = false;
                    this.button9.Enabled = false;
                    this.Hide();
                    if (Program.iw.IsDisposed == true)
                    {
                        Program.iw = new IntWizard();                        
                    }
                    Program.iw.Size = this.Size;
                    Program.iw.Location = this.Location;
                    Program.iw.Show();
                }
                if (Program.ms.radioButton7.Checked == true)
                {
                    this.label10.Visible = true;
                    this.label10.Text = "This is a predefined template. It does not require setup.";
                    this.listBox1.Items.Add("1");
                    this.listBox1.Items.Add("2");
                    this.listBox1.Items.Add("3");
                    this.listBox1.Items.Add("4");
                    this.listBox1.Items.Add("5");
                    this.listBox1.Items.Add("6");
                    this.button8.Enabled = false;
                    this.button9.Enabled = false;
                }
                else if (Program.ms.radioButton8.Checked == true)
                {
                    this.label10.Visible = true;
                    this.label10.Text = "This is a predefined template. It does not require setup.";
                    this.listBox1.Items.Add("Color [Red]");
                    this.listBox1.Items.Add("Color [DodgerBlue]");
                    this.listBox1.Items.Add("Color [Yellow]");
                    this.listBox1.Items.Add("Color [DarkOrange]");
                    this.listBox1.Items.Add("Color [Green]");
                    this.listBox1.Items.Add("Color [Fuchsia]");
                    this.label11.Visible = true;
                    this.button8.Enabled = false;
                    this.button9.Enabled = false;
                }
                else if (Program.ms.radioButton9.Checked == true)
                {
                    this.label10.Visible = true;
                    this.label10.Text = "This is a predefined template. It does not require setup.";
                    this.listBox1.Items.Add("True");
                    this.listBox1.Items.Add("False");
                    this.listBox1.Items.Add("True");
                    this.listBox1.Items.Add("False");
                    this.listBox1.Items.Add("True");
                    this.listBox1.Items.Add("False");
                    this.listBox1.Items.Add("True");
                    this.listBox1.Items.Add("False");
                    this.listBox1.Items.Add("True");
                    this.listBox1.Items.Add("False");
                    this.listBox1.Items.Add("True");
                    this.listBox1.Items.Add("False");
                    this.listBox1.Items.Add("True");
                    this.listBox1.Items.Add("False");
                    this.button8.Enabled = false;
                    this.button9.Enabled = false;

                }
                else if (Program.ms.radioButton10.Checked == true)
                {
                    this.label10.Visible = true;
                    this.label10.Text = "This is a predefined template. It does not require setup.";
                    this.listBox1.Items.Add("1");
                    this.listBox1.Items.Add("2");
                    this.listBox1.Items.Add("3");
                    this.listBox1.Items.Add("1");
                    this.listBox1.Items.Add("2");
                    this.listBox1.Items.Add("3");
                    this.button8.Enabled = false;
                    this.button9.Enabled = false;

                }
                else if (Program.ms.radioButton11.Checked == true)
                {
                    this.label10.Visible = true;
                    this.label10.Text = "This is a predefined template. It does not require setup.";
                    this.listBox1.Items.Add("A");
                    this.listBox1.Items.Add("B");
                    this.listBox1.Items.Add("C");
                    this.listBox1.Items.Add("D");
                    this.listBox1.Items.Add("E");
                    this.listBox1.Items.Add("F");
                    this.listBox1.Items.Add("G");
                    this.listBox1.Items.Add("H");
                    this.listBox1.Items.Add("I");
                    this.listBox1.Items.Add("J");
                    this.listBox1.Items.Add("K");
                    this.listBox1.Items.Add("L");
                    this.listBox1.Items.Add("M");
                    this.listBox1.Items.Add("N");
                    this.listBox1.Items.Add("O");
                    this.listBox1.Items.Add("P");
                    this.listBox1.Items.Add("Q");
                    this.listBox1.Items.Add("R");
                    this.listBox1.Items.Add("S");
                    this.listBox1.Items.Add("T");
                    this.listBox1.Items.Add("U");
                    this.listBox1.Items.Add("V");
                    this.listBox1.Items.Add("W");
                    this.listBox1.Items.Add("X");
                    this.listBox1.Items.Add("Y");
                    this.listBox1.Items.Add("Z");
                    this.button8.Enabled = false;
                    this.button9.Enabled = false;

                }
                else if (Program.ms.radioButton12.Checked == true)
                {
                    this.label10.Visible = true;
                    this.label10.Text = "This is a predefined template. It does not require setup.";
                    this.listBox1.Items.Add("notepad.exe");
                    this.listBox1.Items.Add("mspaint.exe");
                    this.listBox1.Items.Add("charmap.exe");
                    this.listBox1.Items.Add("msconfig");
                    this.listBox1.Items.Add("devmgmt.msc");
                    this.listBox1.Items.Add("msinfo32");
                    this.listBox1.Items.Add("wordpad.exe");
                    this.listBox1.Items.Add("cmd.exe");
                    this.listBox1.Items.Add("dfrg.msc");
                    this.listBox1.Items.Add("calc.exe");
                    this.listBox1.Items.Add("explorer.exe");
                    this.listBox1.Items.Add("winver");
                    this.listBox1.Items.Add("cleanmgr.exe");
                    this.listBox1.Items.Add("wscui.cpl");
                    this.listBox1.Items.Add("taskmgr.exe");
                    this.listBox1.Items.Add("moviemk.exe");
                    this.listBox1.Items.Add("command.com");
                    this.listBox1.Items.Add("iexplore.exe");
                    this.listBox1.Items.Add("wmplayer.exe");
                    this.listBox1.Items.Add("sndrec32.exe");
                    this.listBox1.Items.Add("sndvol32.exe");
                    this.button8.Enabled = true;
                    this.button9.Enabled = true;
                    this.button11.Enabled = true;
                    this.checkBox1.Enabled = true;
                }
            }
            if (Program.ms.checkBox1.Checked == false)
            {
                if (DecideForMe.Program.ms.radioButton1.Checked == true)
                {
                    this.label2.Visible = true;
                    this.button1.Visible = true;
                    this.textBox1.Visible = true;
                }
                else if (DecideForMe.Program.ms.radioButton2.Checked == true)
                {
                    this.label4.Visible = true;
                    this.button2.Visible = true;
                    this.button4.Visible = true;
                    this.button3.Visible = true;
                    this.textBox2.Visible = true;
                }
                else if (DecideForMe.Program.ms.radioButton3.Checked == true)
                {
                    this.label5.Visible = true;
                    this.button5.Visible = true;
                    this.pictureBox1.Visible = true;
                }
                else if (DecideForMe.Program.ms.radioButton4.Checked == true)
                {
                    this.label11.Visible = true;
                    this.label6.Visible = true;
                    this.button6.Visible = true;
                }
                else if (DecideForMe.Program.ms.radioButton5.Checked == true)
                {
                    this.label7.Visible = true;
                    this.label8.Visible = true;
                    this.label9.Visible = true;
                    this.textBox3.Visible = true;
                    this.textBox4.Visible = true;
                    this.button7.Visible = true;
                    this.button11.Enabled = true;
                    this.checkBox1.Enabled = true;
                }
                else if (DecideForMe.Program.ms.radioButton6.Checked == true)
                {
                    this.label10.Visible = true;
                    this.listBox1.Items.Add("Yes");
                    this.listBox1.Items.Add("No");
                    this.listBox1.Items.Add("Yes");
                    this.listBox1.Items.Add("No");
                    this.listBox1.Items.Add("Yes");
                    this.listBox1.Items.Add("No");
                    this.listBox1.Items.Add("Yes");
                    this.listBox1.Items.Add("No");
                    this.button8.Enabled = false;
                    this.button9.Enabled = false;
                    goto label1;
                }

            label1: ;
            }
    }

        private void button11_Click(object sender, EventArgs e)
        {
            Process.Start(this.listBox1.SelectedItem.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Add(this.textBox1.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                if (listBox1.SelectedItems.Count > 0)
                { 
                    listBox1.Items.Remove(listBox1.Items[listBox1.SelectedIndex]);
                }
            }
		    this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.One;
            if (listBox1.Items.Count > 0)
            {
                this.listBox1.SelectedIndex = new Random().Next(this.listBox1.Items.Count);
                this.listBox1.SelectedIndex = new Random().Next(this.listBox1.Items.Count);
                this.listBox1.SelectedIndex = new Random().Next(this.listBox1.Items.Count);
                this.listBox1.SelectedIndex = new Random().Next(this.listBox1.Items.Count);
                this.listBox1.SelectedIndex = new Random().Next(this.listBox1.Items.Count);
                this.listBox1.SelectedIndex = new Random().Next(this.listBox1.Items.Count);
                this.listBox1.SelectedIndex = new Random().Next(this.listBox1.Items.Count);
                this.listBox1.SelectedIndex = new Random().Next(this.listBox1.Items.Count);
                this.listBox1.SelectedIndex = new Random().Next(this.listBox1.Items.Count);
                this.listBox1.SelectedIndex = new Random().Next(this.listBox1.Items.Count);
                this.listBox1.SelectedIndex = new Random().Next(this.listBox1.Items.Count);
                this.listBox1.SelectedIndex = new Random().Next(this.listBox1.Items.Count);
                this.listBox1.SelectedIndex = new Random().Next(this.listBox1.Items.Count);
                this.listBox1.SelectedIndex = new Random().Next(this.listBox1.Items.Count);
                this.listBox1.SelectedIndex = new Random().Next(this.listBox1.Items.Count);
                this.listBox1.SelectedIndex = new Random().Next(this.listBox1.Items.Count);
                this.listBox1.SelectedIndex = new Random().Next(this.listBox1.Items.Count);
                this.listBox1.SelectedIndex = new Random().Next(this.listBox1.Items.Count);
                this.listBox1.SelectedIndex = new Random().Next(this.listBox1.Items.Count);
            }
            try
            { 
                string str1 = this.listBox1.SelectedItem.ToString().Replace("Color [", "");
		        if (this.label11.Visible) 
		        {
                    if (str1.StartsWith("A="))
                    {
                        str1 = str1.Replace("A=255, ", "");
                        str1 = str1.Replace("]", "");
                        str1 = str1.Replace("R=", "");
                        str1 = str1.Replace("G=", "");
                        str1 = str1.Replace("B=", "");
                        ListBox lb = new ListBox();
                        lb.Items.AddRange(str1.Split(','));
                        lb.SelectedIndex = 0;
                        int r = Convert.ToInt32(lb.SelectedItem.ToString());
                        lb.SelectedIndex = 1;
                        int g = Convert.ToInt32(lb.SelectedItem.ToString());
                        lb.SelectedIndex = 2;
                        int b = Convert.ToInt32(lb.SelectedItem.ToString());
                        label11.BackColor = Color.FromArgb(r, g, b);
                        label11.ForeColor = Color.FromArgb(r, g, b);
                        return;
                    }
			        this.label11.BackColor = System.Drawing.Color.FromName(str1.Replace("]", ""));
			        this.label11.ForeColor = System.Drawing.Color.FromName(str1.Replace("]", ""));
		        }
                if (Program.ms.radioButton3.Checked == true)
                {
                    this.pictureBox1.Visible = true;
                    this.pictureBox1.BackgroundImage = System.Drawing.Image.FromFile(this.listBox1.SelectedItem.ToString());
                }
		        if (checkBox1.Checked==true) 
		        {
		            Process.Start(this.listBox1.SelectedItem.ToString());
		        }
                listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            }
            catch
            {

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1 = (Convert.ToInt32(this.textBox2.Text) - 1);
            this.textBox2.Text = Convert.ToString(num1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num1 = (Convert.ToInt32(this.textBox2.Text) + 1);
            this.textBox2.Text = Convert.ToString(num1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Add(this.textBox2.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.openImageDialog.ShowDialog() == DialogResult.OK)
            {
                this.listBox1.Items.AddRange(this.openImageDialog.FileNames);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (this.openScriptDialog.ShowDialog() == DialogResult.OK)
            {
                this.textBox3.Text = this.openScriptDialog.FileName;
                this.listBox1.Items.AddRange(this.openScriptDialog.FileNames);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (this.colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.listBox1.Items.Add(this.colorDialog1.Color.ToString());
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.listBox1.SelectedItems.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
            if (Program.ms.radioButton4.Checked == true)
            {
                label11.BackColor = SystemColors.Control;
                label11.ForeColor = Color.DimGray;
            }

        }

        private void Setup_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (close == false)
            {
                Program.ms.Show();
            }
            if (close == true)
            {
                Program.ms.Dispose();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            close = true;
            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Program.ms.WindowState = this.WindowState;
            close = false;
            this.Close();
        }

        private void Setup_LocationChanged(object sender, EventArgs e)
        {
            Program.ms.Location = this.Location;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Setup_Resize(object sender, EventArgs e)
        {
            Program.ms.Size = this.Size;
        }
    }
}
