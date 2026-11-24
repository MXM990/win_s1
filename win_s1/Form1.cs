using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace win_s1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void test_bt_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            test_bt.BackColor = Color.DarkGray;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = label2.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Name {textBox2.Text} \nPassword {textBox3.Text}");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox3.UseSystemPasswordChar = !textBox3.UseSystemPasswordChar;
        }
    }
}
