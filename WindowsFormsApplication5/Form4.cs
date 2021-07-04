using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;
namespace Hangman
{
    public partial class Form4 : Form
    {
        int cnt = 0;
        SoundPlayer player = new SoundPlayer();
        List<string> s = new List<string>();
        List<Label> lab = new List<Label>();
        string word = "";
        bool isalpha(char ch)
        {
            return ((ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z'));
        }
        char tolower(char ch)
        {
            return (ch >= 'A' && ch <= 'Z')? (char)(ch + 32) : ch;
        }
        char toupper(char ch)
        {
            return (ch >= 'a' && ch <= 'z')? (char)(ch-32) : ch;
        }
        bool win()
        {
            char[] arr = word.ToCharArray();
            bool ok = true;
            for (int i=0; i<arr.Length;i++)
            {
                ok &= (arr[i] == lab[i].Text.ToCharArray()[0]);
            }
            return ok;
        }
  
        void change(Button b)
        {
            char ch = b.Text.ToCharArray()[0];
            if (word.Contains(tolower(ch)) || word.Contains(toupper(ch)))
            {
                char[] arr = word.ToCharArray();
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == tolower(ch))
                        lab[i].Text = tolower(ch).ToString();
                    else if (arr[i] == toupper(ch))
                        lab[i].Text = toupper(ch).ToString();
                }
                b.BackColor = Color.Green;
                if(win())
                {
                    MessageBox.Show("You have won !!", "Congratulations");
                    Form1 form = new Form1();
                    form.Show();
                    this.Hide();
                }
            }
            else
            {
                b.BackColor = Color.Red;
                cnt++;
                if(cnt==1)
                {
                    pictureBox1.Image=Hangman.Properties.Resources._202;
                }
                else if (cnt==2)
                {
                    pictureBox1.Image = Hangman.Properties.Resources._203;

                }
                else if (cnt == 3)
                {
                    pictureBox1.Image = Hangman.Properties.Resources._204;

                }
                else if (cnt == 4)
                {
                    pictureBox1.Image = Hangman.Properties.Resources._205;

                }
                else if (cnt == 5)
                {
                    pictureBox1.Image = Hangman.Properties.Resources._206;

                }
                else if (cnt == 6)
                {
                    pictureBox1.Image = Hangman.Properties.Resources._207;

                }
                else if (cnt == 7)
                {
                    pictureBox1.Image = Hangman.Properties.Resources._208;

                }
                else if (cnt == 8)
                {
                    pictureBox1.Image = Hangman.Properties.Resources._209;

                }
                else if (cnt == 9)
                {
                    pictureBox1.Image = Hangman.Properties.Resources._210;
                }
                label1.Text = "Wrong Characters : " + cnt.ToString();
                if (cnt >= 9)
                {
                    MessageBox.Show("You have lost, The correct word is " + word, "Sorry");
                    Form1 form = new Form1();
                    form.Show();
                    this.Hide();
                }
            }
            b.Enabled = false;
        }
        string GenerateRandomWord()
        {
            s = Form2.words;
            string a = "";
            foreach (string i in s)
            {
                if (Form3.easy)
                {
                    if (i.Length <= 7)
                        a += (i + '*');
                }
                else if(Form3.medium)
                {
                    if (i.Length <= 11 && i.Length> 7)
                        a += (i + '*');
                }
                else
                {
                    if (i.Length > 11 && i.Length<=15)
                        a += (i + '*');
                }
            }
            string[] all = a.Split('*');
            Random ran = new Random();
            return all[ran.Next(0, all.Length - 1)];
        }
        void MakeLabels()
        {
            word = GenerateRandomWord();
            char[] arr = word.ToCharArray();
            int mid;
            if (Form3.easy)
            {
                mid = 100 / arr.Length;
            }
            else if (Form3.medium)
            {
                mid = 200 / arr.Length;
            }
            else
            {
                mid = 300 / arr.Length;
            }
            for ( int i=0; i<arr.Length; i++)
            {
                lab.Add(new Label());
                lab[i].Location = new Point((i * mid) + 10, 80);
                lab[i].Text = isalpha(arr[i]) ? "_" : arr[i].ToString() ;
                lab[i].Parent = panel1;
                lab[i].BringToFront();
                lab[i].CreateControl();
            }
        }
        public Form4()
        {
            InitializeComponent();
            player.SoundLocation = "DesiJourney.wav";
            MakeLabels();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            change(button1);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            change(button2);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            change(button3);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            change(button4);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            change(button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            change(button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            change(button7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            change(button8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            change(button9);
        }
        private void button10_Click(object sender, EventArgs e)
        {
            change(button10);
        }
        private void button11_Click(object sender, EventArgs e)
        {
            change(button11);
        }
        private void button12_Click(object sender, EventArgs e)
        {
            change(button12);
        }
        private void button13_Click(object sender, EventArgs e)
        {
            change(button13);
        }
        private void button14_Click(object sender, EventArgs e)
        {
            change(button14);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            change(button15);
        }
        private void button16_Click(object sender, EventArgs e)
        {
            change(button16);
        }
        private void button17_Click(object sender, EventArgs e)
        {
            change(button17);
        }
        private void button18_Click(object sender, EventArgs e)
        {
            change(button18);
        }
        
        private void button19_Click(object sender, EventArgs e)
        {
            change(button19);
        }
        private void button20_Click(object sender, EventArgs e)
        {
            change(button20);
        }
        private void button21_Click(object sender, EventArgs e)
        {
            change(button21);
        }
        private void button22_Click(object sender, EventArgs e)
        {
            change(button22);
        }
        private void button23_Click(object sender, EventArgs e)
        {
            change(button23);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            change(button24);
        }
        private void button25_Click(object sender, EventArgs e)
        {
            change(button25);
        }
        private void button26_Click(object sender, EventArgs e)
        {
            change(button26);
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            player.Play();
            label1.Text = "Wrong Characters : " + cnt.ToString();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button28_Click(object sender, EventArgs e)
        {
            Form3.easy = false;
            Form3.medium = false;
            Form3.hard = false;
            Form3 form = new Form3();
            form.Show();
            this.Close();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            this.WindowState = this.WindowState = FormWindowState.Minimized;

        }
    }
}
