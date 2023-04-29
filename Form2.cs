using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diplom
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Visible = false;
            //Close();
            Form1 f1 = new Form1();
            f1.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
            Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Show();
            Close();
        }
    }
}
