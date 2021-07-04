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
using System.IO;
namespace Hangman
{
    public partial class Form2 : Form
    {
        SoundPlayer player = new SoundPlayer();
        public static bool[] check = new bool[7];
        public Form2()
        {
            InitializeComponent();
            player.SoundLocation = "DesiJourney.wav";
           
        }
        private void Cou_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SoundPlayer click1 = new SoundPlayer();
            click1.SoundLocation = "click.wav";
            click1.Play();

            Form1 form = new Form1();
            form.Show();
            this.Hide();

        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
            player.Play();
        }
        public static List<string> words = new List<string>();
        private void button1_Click(object sender, EventArgs e)
        {
             SoundPlayer click1 = new SoundPlayer();
            click1.SoundLocation = "click.wav";
            click1.Play();
            string[] arr = new string[7];
            bool ok = false;
            arr[0] = "football.txt"; check[0] = checkBox1.Checked;
            arr[1] = "countries.txt"; check[1] = Cou.Checked;
            arr[2] = "movies.txt"; check[2] = checkBox3.Checked;
            arr[3] = "animals.txt"; check[3] = checkBox4.Checked;
            arr[4] = "celeberties.txt"; check[4] = checkBox5.Checked;
            arr[5] = "games.txt"; check[5] = checkBox6.Checked;
            arr[6] = "anime.txt"; check[6] = checkBox7.Checked;
            for (int i = 0; i < 7; i++)
                ok |= (check[i]);
            if (!ok)
            {
                MessageBox.Show("Please Select a category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Form3 form = new Form3();
                form.Show();
                this.Hide();
                for (int i = 0; i < 7; i++)
                {
                    if (check[i])
                    {
                        StreamReader S = new StreamReader(arr[i]);
                        string line;
                        while ((line = S.ReadLine()) != null)
                        {
                            if (line != "")
                            {
                                words.Add(line);
                            }
                        }
                    }
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = checkBox2.Checked;
            checkBox3.Checked = checkBox2.Checked;
            checkBox4.Checked = checkBox2.Checked;
            checkBox5.Checked = checkBox2.Checked;
            checkBox6.Checked = checkBox2.Checked;
            checkBox7.Checked = checkBox2.Checked;
            Cou.Checked = checkBox2.Checked;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 7; i++)
                check[i] = false;
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = this.WindowState = FormWindowState.Minimized;

        }
    }
}
