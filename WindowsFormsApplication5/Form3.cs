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

namespace Hangman
{
    public partial class Form3 : Form
    {
        public static bool easy=false;
        public static bool medium=false;
        public static bool hard=false;
        SoundPlayer player = new SoundPlayer();
        public Form3()
        {
            InitializeComponent();
            player.SoundLocation = "DesiJourney.wav";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            easy = false;
            medium = false;
            hard = false;
            List<string> tmp = new List<string>();
            Form2.words = tmp;
            Form2 form = new Form2();
            form.Show();
            this.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            easy = true;
            Form4 form = new Form4();
            form.Show();
            this.Hide();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            player.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            medium = true;
            Form4 form = new Form4();
            form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hard = true;
            Form4 form = new Form4();
            form.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = this.WindowState = FormWindowState.Minimized;

        }
    }
}
