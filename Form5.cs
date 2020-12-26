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
    public partial class Form5 : Form
    {
        public static string str;
        public Form5()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            str = Convert.ToString(this.textBox1.Text.Trim());
        }
        public  string SetSignTime()
        {
            return textBox1.Text.Trim();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
