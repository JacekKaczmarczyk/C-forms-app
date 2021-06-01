using System;
using System.Windows.Forms;

namespace Zadanie_3_05_ZT
{
    public partial class Form1 : Form
    {
        int MAX = 120;
        int MIN = 30;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox3.Text, out _))
            {
                if (textBox2.Text.IndexOf(textBox3.Text + ";", StringComparison.Ordinal) != -1)
                {
                    if (int.Parse(textBox3.Text) >= MIN && int.Parse(textBox3.Text) <= MAX)
                    {
                        textBox4.Text = "tak";
                    }
                    else
                    {
                        textBox4.Text = "nie";
                    }
                }
                else textBox4.Text = "nie";
            }
            else
            {
                textBox3.Text = "to nie liczba";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            if (int.TryParse(textBox1.Text, out _))
            {
                int x = int.Parse(textBox1.Text);
                for (int i = MIN; i <= MAX; i++)
                {
                    if (i % x == 0)
                    {
                        textBox2.Text += i + ";";
                    }
                }
            }
            else
            {
                textBox1.Text = "to nie liczba";
            }
        }
    }
}
