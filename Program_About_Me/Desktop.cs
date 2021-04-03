using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Program_About_Me
{
    public partial class Desktop : Form
    {
        public static bool a = true;
        public Desktop()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            a = true;
            Form1 form = new Form1();
            this.Hide();
            form.Show();
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            pictureBox4.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Я пошутил. \nЗакройте это. :)");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Check_radioButton();
        }

        public void Check_radioButton()
        {
            string a = "";

            if (radioButton1.Checked == true)
            {
                a = "netflix.ico";
            }

            if (radioButton2.Checked == true)
            {
                a = "pig.ico";
            }

            Icon ico = new Icon(a);
            this.Icon = ico;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Check_radioButton();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://metanit.com");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string cod = "ИСП";
            if (textBox1.Text == cod)
            {
                panel3.Visible = true;
                textBox1.Visible = false;
                label5.Visible = false;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            textBox1.Text = "";
            textBox1.Visible = true;
            label5.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Введите в строку (ИСП)");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void Desktop_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
