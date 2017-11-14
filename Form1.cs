using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c;
            c = 0.1;
            b = c/2;
            a = 1.1 - b;
            richTextBox1.Text = "стоимость лампы: " + a + System.Environment.NewLine;
            richTextBox1.Text += "стоимость диода: " + b;
            //textBox3.Text = b;

        }
    }
}
