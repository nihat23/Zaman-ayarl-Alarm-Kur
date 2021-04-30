using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm_kur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //bu satır her ıkı yerde olabılır

            label3saat.Text = DateTime.Now.ToLongTimeString();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (dateTimePicker1.Text == textBox2tarih.Text && label3saat.Text == textBox1saat.Text)
            {
                axWindowsMediaPlayer1.URL =Application.StartupPath+"\\Polis.mp3";

            }

            label3saat.Text = DateTime.Now.ToLongTimeString();

        }

        private void button1AlarmKur_Click(object sender, EventArgs e)
        {
            timer1.Start();
            textBox1saat.Enabled = false;
            textBox2tarih.Enabled = false;
            button1AlarmKur.Enabled = false;

        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/n.beyi");

        }

        private void button3Dur_Click(object sender, EventArgs e)
        {
            textBox1saat.Enabled = true;
            textBox2tarih.Enabled = true;
            button1AlarmKur.Enabled = true;
            textBox1saat.Clear();
            textBox2tarih.Clear();
            axWindowsMediaPlayer1.close();
        }
    }
}
