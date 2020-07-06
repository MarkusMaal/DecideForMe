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
    public partial class IntWizard : Form
    {
        public IntWizard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sb = Convert.ToInt32(startBox.Text);
            int eb = Convert.ToInt32(endBox.Text);
            int stb = Convert.ToInt32(stepBox.Text);
            Program.ss.Location = this.Location;
            Program.ss.Show();
            for (int i = sb; i <= eb; i = i + stb)
            {
                Program.ss.listBox1.Items.Add(i.ToString());
            }
            this.Close();
        }

        private void IntWizard_Load(object sender, EventArgs e)
        {
            Program.ss.Hide();
            this.Location = Program.ss.Location;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Program.ss.Visible == true)
            {
                Program.ss.Hide();
            }
            timer1.Enabled = false;
        }

        private void IntWizard_Shown(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
