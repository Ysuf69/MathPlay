using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatematikOyunu
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        int fark = 0;
        int senincevapın;
        int puan = 0;
        
        

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            timer1.Start();
            
            süre = 16;
            süre--;
            label1.Visible = false;
            label7.Visible = false;
            textBox1.Focus();
            pictureBox2.Visible = false;
            pictureBox1.Visible = false;
            button2.Enabled = false;
            button1.Enabled = true;
            button2.Text = "Diğer Soru";
            int sayı1 = rnd.Next(600,1001);
            int sayı2 = rnd.Next(1, 601);
            label3.Text = sayı1.ToString();
            label5.Text = sayı2.ToString();
            fark = sayı1 - sayı2;
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            button1.Enabled = false;
            button2.Enabled = true;
            senincevapın = Convert.ToInt32(textBox1.Text);

            if (fark == senincevapın)
            {
                textBox2.Text = "Tebrikler doğru cevap verdiniz!";
                pictureBox1.Visible = true;
                puan = puan + 4;
                label9.Text = puan.ToString();

            }
            else if (fark != senincevapın)
            {
                textBox2.Text = "Malesef yanlış cevap, doğru cevap " + fark.ToString();
                pictureBox2.Visible = true;
            }
            timer1.Stop();

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            button1.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form2 anamenu = new Form2();
            anamenu.Show();
            this.Hide();
            süre = 0;
        }

        int süre = 16;

        private void timer1_Tick(object sender, EventArgs e)
        {
            süre--;
            if (süre==0)
            {
                timer1.Stop();
                MessageBox.Show("Süreniz bitti, diğer soruya geçin!");
                textBox2.Text = "Cevap: " + fark.ToString();
                button2.Enabled = true;
                textBox1.Enabled = false;
                button1.Enabled = false;
            }
            label11.Text = süre.ToString();
        }
    }
}
