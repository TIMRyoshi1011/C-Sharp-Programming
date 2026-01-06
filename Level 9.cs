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
    public partial class Form15 : Form
    {
        public Form15(string score)
        {
            InitializeComponent();
            label2.Text = Convert.ToString(score);
        }

        int time = 0;
        int score = 0;

        private void Form15_Load(object sender, EventArgs e)
        {
            time = 60;
            timer1.Start();
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "BURBERRY" || textBox1.Text == "Burberry" || textBox1.Text == "burberry")
            {
                if (label2.Text == "8")
                {
                    score = 9;
                    label2.Text = Convert.ToString(score);
                }

                else if (label2.Text == "7")
                {
                    score = 8;
                    label2.Text = Convert.ToString(score);
                }

                else if (label2.Text == "6")
                {
                    score = 7;
                    label2.Text = Convert.ToString(score);
                }

                else if (label2.Text == "5")
                {
                    score = 6;
                    label2.Text = Convert.ToString(score);
                }

                else if (label2.Text == "4")
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

                Form16 form = new Form16(score.ToString());
                form.Show();
                this.Hide();

            }

            else
            {
                if (label2.Text == "8")
                {
                    score = 7;
                    label2.Text = Convert.ToString(score);
                }

                else if (label2.Text == "7")
                {
                    score = 6;
                    label2.Text = Convert.ToString(score);
                }

                else if (label2.Text == "6")
                {
                    score = 5;
                    label2.Text = Convert.ToString(score);
                }

                else if (label2.Text == "5")
                {
                    score = 4;
                    label2.Text = Convert.ToString(score);
                }

                else if (label2.Text == "4")
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
                textBox1.Text = null;
                textBox1.Focus();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = time--.ToString();

            if (time < 0)
            {
                timer1.Stop();

                if (label2.Text == "8")
                {
                    score = 6;
                    label2.Text = Convert.ToString(score);
                }

                else if (label2.Text == "7")
                {
                    score = 5;
                    label2.Text = Convert.ToString(score);
                }

                else if (label2.Text == "6")
                {
                    score = 4;
                    label2.Text = Convert.ToString(score);
                }

                else if (label2.Text == "5")
                {
                    score = 3;
                    label2.Text = Convert.ToString(score);
                }

                else if (label2.Text == "4")
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
                MessageBox.Show("The Answer is Burberry!");

                Form16 form = new Form16(score.ToString());
                form.Show();
                this.Hide();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label2.Text == "8")
            {
                score = 7;
                label2.Text = Convert.ToString(score);
            }

            else if (label2.Text == "7")
            {
                score = 6;
                label2.Text = Convert.ToString(score);
            }

            else if (label2.Text == "6")
            {
                score = 5;
                label2.Text = Convert.ToString(score);
            }

            else if (label2.Text == "5")
            {
                score = 4;
                label2.Text = Convert.ToString(score);
            }

            else if (label2.Text == "4")
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

            MessageBox.Show("B _ r b _ _ r y");
            textBox1.Focus();

        }
    }
}