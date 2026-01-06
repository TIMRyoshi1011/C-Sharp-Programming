using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Logo_Quiz_3._0
{
    public partial class Form2 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();

        public Form2()
        {
            InitializeComponent();
            player.SoundLocation = "Undertale - Megalovania.wav";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            player.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            player.Stop();

            Form7 form = new Form7();
            form.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            player.Stop();

            Rules form = new Rules();
            form.Show();
            this.Hide();

        }
    }
}
