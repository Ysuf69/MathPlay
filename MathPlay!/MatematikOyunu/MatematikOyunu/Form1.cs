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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        int toplam = 0;
        int senincevapın;
        int puan = 0;
        

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            textBox2.Enabled = false;
            textBox1.Enabled = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            button1.Enabled = false;
            button2.Enabled = true;
            senincevapın = Convert.ToInt32(textBox1.Text);
            textBox1.Enabled = false;

            if (toplam == senincevapın)
            {
                textBox2.Text = "Tebrikler doğru cevap verdiniz!";
                pictureBox1.Visible = true;
                puan = puan + 4;
                label9.Text = puan.ToString();
                
                
                
            }
            else if (toplam != senincevapın)
            { 
                textBox2.Text ="Malesef yanlış cevap, doğru cevap "+ toplam.ToString();
                pictureBox2.Visible = true;
                
            }
            timer1.Stop();
            

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            süre--;
            süre = 16;
            label1.Visible = false;
            label7.Visible = false;
            textBox1.Focus();
            pictureBox2.Visible = false;   
            pictureBox1.Visible = false;
            button2.Enabled = false;
            button1.Enabled = true;
            button2.Text = "Diğer Soru";
            int sayı1 = rnd.Next(1, 1001);
            int sayı2 = rnd.Next(1, 1001);
            label3.Text = sayı1.ToString();
            label5.Text = sayı2.ToString();
            toplam = sayı1 + sayı2;
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Enabled = true;
            textBox2.BackColor = Color.White;
           

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
                textBox2.Text = "Cevap: " + toplam.ToString();
                button2.Enabled = true;
                textBox1.Enabled = false;
                button1.Enabled = false;
            }
            label11.Text = süre.ToString();

        }
    }
}
