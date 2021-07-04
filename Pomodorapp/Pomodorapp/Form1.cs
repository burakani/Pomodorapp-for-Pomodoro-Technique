using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pomodorapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int dakika = 25;
        int saniye = 60;
        private void baslatButonu_Click(object sender, EventArgs e)
        {
            baslatButonu.Enabled = false;
            timer1.Start();
            textBox8.Text = "Working...";
            button3.Enabled = true;
        }   
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value++;
            saniye--;
            label2.Text = saniye.ToString();
            label1.Text = (dakika-1).ToString();
            if(Convert.ToInt32(label2.Text) == 0)
            {
                saniye = 60;
                dakika--;
                label1.Text = dakika.ToString();
            }

            if (dakika == 0 && Convert.ToInt32(label2.Text) == 0)
            {
                timer1.Stop();
                MessageBox.Show("Time is up, Take a break for 5 minutes.");
                dakika = 25;
                label1.Text = dakika.ToString();
                saniye = 60;
                label2.Text = "00";
                baslatButonu.Enabled = true;
                textBox8.Text = "";
                progressBar1.Value = 0;
            }
        }
        private void sifirlaButonu_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            saniye = 60;
            dakika = 25;
            label1.Text = "25";
            label2.Text = "00";
            baslatButonu.Enabled = true;
            textBox8.Text = "";
            button3.Enabled = true;
            progressBar1.Value = 0;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            baslatButonu.Enabled = true;
            button3.Enabled = false;
        }
    }
}
