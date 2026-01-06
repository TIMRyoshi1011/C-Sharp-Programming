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
    public partial class Rules : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();

        public Rules()
        {
            InitializeComponent();
            player.SoundLocation = "Eternal.wav";
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            player.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
            this.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
