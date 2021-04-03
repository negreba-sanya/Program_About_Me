using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Program_About_Me
{
    public partial class Data : Form
    {
        public Data()
        {
            InitializeComponent();
            System.Drawing.Text.PrivateFontCollection f = new System.Drawing.Text.PrivateFontCollection();
            f.AddFontFile("660_pricedown_rus.ttf");
            f.AddFontFile("662_old_english.ttf");
            button1.Font = new Font(f.Families[1], 35);
            label11.Font = new Font(f.Families[0], 35);

            label6.Font = new Font(f.Families[1], 35);
            label7.Font = new Font(f.Families[1], 35);
            label8.Font = new Font(f.Families[1], 35);
            label9.Font = new Font(f.Families[1], 35);
            label10.Font = new Font(f.Families[1], 35);

            label1.Font = new Font(f.Families[1], 30);
            label2.Font = new Font(f.Families[1], 30);
            label3.Font = new Font(f.Families[1], 30);
            label4.Font = new Font(f.Families[1], 30);
            label5.Font = new Font(f.Families[1], 30);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Close();
            form.Show();
        }

        private void Data_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
