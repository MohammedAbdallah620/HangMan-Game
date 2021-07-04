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
using System.Threading;


namespace Hangman
{
    public partial class Form1 : Form
    {
       SoundPlayer player = new SoundPlayer();
        public Form1()
        {

            InitializeComponent();
            player.SoundLocation = "DesiJourney.wav";
            player.Play();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            player.Play();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SoundPlayer click1= new SoundPlayer();
            click1.SoundLocation = "click.wav";
            click1.Play();
            Form4 form = new Form4();
            form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           SoundPlayer click1 = new SoundPlayer();
            click1.SoundLocation = "click.wav";
            click1.Play();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           SoundPlayer click1 = new SoundPlayer();
            click1.SoundLocation = "click.wav";
            click1.Play();
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.WindowState = this.WindowState = FormWindowState.Minimized;
        }
    }
}
