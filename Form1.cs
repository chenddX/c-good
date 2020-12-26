using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = "admin";
            string pass = "0000";
            if (name == textBox1.Text.Trim() && pass == textBox2.Text.Trim())
            {
                //Form2 form = new Form2();
                //form.Show();
                Form5 form5 = new Form5();
                form5.Show();
                this.Hide();
            }
            else
            {
                Form6 form6 = new Form6();
                form6.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                //复选框被勾选，明文显示
                textBox2.PasswordChar = new char();
            }
            else
            {
                //复选框被取消勾选，密文显示
                textBox2.PasswordChar = '*';
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
                textBox2.PasswordChar = '*';
            
        }
    }
}
