using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_About_Me
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            System.Media.SoundPlayer sp = new System.Media.SoundPlayer();

            System.Drawing.Text.PrivateFontCollection f = new System.Drawing.Text.PrivateFontCollection();
            f.AddFontFile("660_pricedown_rus.ttf");
            f.AddFontFile("662_old_english.ttf");
            button1.Font = new Font(f.Families[1], 35);
            button2.Font = new Font(f.Families[1], 35);
            button3.Font = new Font(f.Families[1], 35);
            button4.Font = new Font(f.Families[1], 35);
            button5.Font = new Font(f.Families[1], 35);
            button6.Font = new Font(f.Families[1], 35);

            label1.Font = new Font(f.Families[0], 35);

            if (Desktop.a == true)
            {
                sp = new SoundPlayer("sound.wav");
                sp.Play();
                panel1.Visible = true;
                progressBar1.Visible = true;
                timer1.Interval = 350;
                timer1.Enabled = true;
                timer1.Tick += timer1_Tick;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            this.Hide();
            info.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Data data = new Data();
            this.Hide();
            data.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Physique physique = new Physique();
            this.Hide();
            physique.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Multimedia multimedia = new Multimedia();
            this.Hide();
            multimedia.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hobby hobby = new Hobby();
            this.Hide();
            hobby.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Desktop desktop = new Desktop();
            this.Hide();
            desktop.Show();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
            if(progressBar1.Value == 500)
            {
                progressBar1.Visible = false;
                panel1.Visible = false;
                timer1.Stop();
                Desktop.a = false;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
