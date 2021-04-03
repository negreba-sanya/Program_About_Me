using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Program_About_Me
{
    public partial class Hobby : Form
    {
        public Hobby()
        {
            System.Drawing.Text.PrivateFontCollection f = new System.Drawing.Text.PrivateFontCollection();
            f.AddFontFile("660_pricedown_rus.ttf");
            f.AddFontFile("662_old_english.ttf");
            InitializeComponent();
            button1.Font = new Font(f.Families[1], 35);

            label5.Font = new Font(f.Families[1], 30);
            label6.Font = new Font(f.Families[1], 30);
            label7.Font = new Font(f.Families[1], 30);

            label10.Font = new Font(f.Families[1], 35);
            label11.Font = new Font(f.Families[0], 35);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Close();
            form.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Hobby_Load(object sender, EventArgs e)
        {

        }

        private void Hobby_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
