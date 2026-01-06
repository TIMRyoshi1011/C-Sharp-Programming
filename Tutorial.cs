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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        int time = 0;
        int score = 0;


        private void Form3_Load(object sender, EventArgs e)
        {
            time = 30;
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("WRONG ANSWER!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("WRONG ANSWER!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("WRONG ANSWER!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            score = 1;
            label2.Text = Convert.ToString(score);
            MessageBox.Show("YOUR ANSWER IS CORRECT!");
            timer1.Stop();

            Form4 form = new Form4(score.ToString());
            form.Show();
            this.Hide();


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
                MessageBox.Show("TIMES UP!");
                MessageBox.Show("The Answer is YouTube!");

                // put form

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}