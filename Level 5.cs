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
    public partial class Form11 : Form
    {
        public Form11(string score)
        {
            InitializeComponent();
            label2.Text = Convert.ToString(score);
        }

        int time = 0;
        int score = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (label2.Text == "4")
            {
                score = 3;
                label2.Text = Convert.ToString(score);
            }

            else if (label2.Text == "3")
            {
                score = 2;
                label2.Text = Convert.ToString(score);
            }

            else if (label2.Text == "2")
            {
                score = 1;
                label2.Text = Convert.ToString(score);
            }

            else if (label2.Text == "1" || label2.Text == "0")
            {
                score = 0;
                label2.Text = Convert.ToString(score);
            }

            MessageBox.Show("WRONG ANSWER!");
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            time = 30;
            timer1.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label2.Text == "4")
            {
                score = 3;
                label2.Text = Convert.ToString(score);
            }

            else if (label2.Text == "3")
            {
                score = 2;
                label2.Text = Convert.ToString(score);
            }

            else if (label2.Text == "2")
            {
                score = 1;
                label2.Text = Convert.ToString(score);
            }

            else if (label2.Text == "1" || label2.Text == "0")
            {
                score = 0;
                label2.Text = Convert.ToString(score);
            }

            MessageBox.Show("WRONG ANSWER!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label2.Text == "4")
            {
                score = 3;
                label2.Text = Convert.ToString(score);
            }

            else if (label2.Text == "3")
            {
                score = 2;
                label2.Text = Convert.ToString(score);
            }

            else if (label2.Text == "2")
            {
                score = 1;
                label2.Text = Convert.ToString(score);
            }

            else if (label2.Text == "1" || label2.Text == "0")
            {
                score = 0;
                label2.Text = Convert.ToString(score);
            }

            MessageBox.Show("WRONG ANSWER!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label2.Text == "4")
            {
                score = 5;
                label2.Text = Convert.ToString(score);
            }

            else if (label2.Text == "3")
            {
                score = 4;
                label2.Text = Convert.ToString(score);
            }

            else if (label2.Text == "2")
            {
                score = 3;
                label2.Text = Convert.ToString(score);
            }

            else if (label2.Text == "1")
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

            Form12 form = new Form12(score.ToString());
            form.Show();
            this.Hide();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = time--.ToString();

            if (time < 0)
            {
                timer1.Stop();

                if (label2.Text == "4")
                {
                    score = 2;
                    label2.Text = Convert.ToString(score);
                }

                else if (label2.Text == "3")
                {
                    score = 1;
                    label2.Text = Convert.ToString(score);
                }

                else if (label2.Text == "2" || label2.Text == "1" || label2.Text == "0")
                {
                    score = 0;
                    label2.Text = Convert.ToString(score);
                }

                MessageBox.Show("TIMES UP!");
                MessageBox.Show("The Answer is Shell!");

                Form12 form = new Form12(score.ToString());
                form.Show();
                this.Hide();

            }
        }
    }
}