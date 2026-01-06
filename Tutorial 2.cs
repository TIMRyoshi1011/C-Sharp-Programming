using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logo_Quiz_3._0
{
    public partial class Form4 : Form
    {
        public Form4(string score)
        {
            InitializeComponent();
            label2.Text = Convert.ToString(score);
        }

        int time = 0;
        int score = 0;


        private void Form4_Load(object sender, EventArgs e)
        {
            time = 60;
            timer1.Start();
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Facebook" || textBox1.Text == "facebook")
            {
                if (label2.Text == "1")
                {
                    score = 2;
                    label2.Text = Convert.ToString(score);
                }

                else if (label2.Text == "0")
                {
                    score = 1;
                    label2.Text = Convert.ToString(score);
                }

                MessageBox.Show("YOUR ANSWER IS CORRECT!");
                timer1.Stop();

                Form5 form = new Form5(score.ToString());
                form.Show();
                this.Hide();

            }

            else
            {
                if (label2.Text == "1")
                {
                    score = 0;
                    label2.Text = Convert.ToString(score);
                }

                else if (label2.Text == "0")
                {
                    score -= 0;
                    label2.Text = Convert.ToString(score);
                }

                MessageBox.Show("WRONG ANSWER!");
                textBox1.Text = null;
                textBox1.Focus();
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = time--.ToString();

            if (time < 0)
            {
                timer1.Stop();

                if (label2.Text == "1" || label2.Text == "0")
                {
                    score = 0;
                    label2.Text = Convert.ToString(score);
                }

                MessageBox.Show("TIMES UP!");
                MessageBox.Show("The Answer is Facebook!");

                Form6 form = new Form6();
                form.Show();
                this.Hide();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label2.Text == "1" || label2.Text == "0")
            {
                score = 0;
                label2.Text = Convert.ToString(score);
            }

            MessageBox.Show("F _ _ e _ o _ k");
            textBox1.Focus();
        }
    }
}
