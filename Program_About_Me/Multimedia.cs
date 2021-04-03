using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Program_About_Me
{
    public partial class Multimedia : Form
    {
        public Multimedia()
        {
            InitializeComponent();
            System.Drawing.Text.PrivateFontCollection f = new System.Drawing.Text.PrivateFontCollection();
            f.AddFontFile("660_pricedown_rus.ttf");
            f.AddFontFile("662_old_english.ttf");

            button1.Font = new Font(f.Families[1], 35);

            label2.Font = new Font(f.Families[1], 30);

            label1.Font = new Font(f.Families[0], 35);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Close();
            form.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Multimedia_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }
    }
}
