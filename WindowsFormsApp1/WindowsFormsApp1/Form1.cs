using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

       

        private void label2_Click(object sender, EventArgs e)
        {

        }

        int soruno = 0;
        private void button5_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.LightBlue;

            label9.Visible =   false;
            label10.Visible = false;

            timer1.Enabled = true;

            süre = 20;
            label3.Text=süre.ToString();

            button5.Text = "ileri";
            soruno++;
            label2.Text = soruno.ToString();

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;

            if (soruno == 1)
            {
                richTextBox1.Text = "arü kuruluş yılı?";
                button1.Text = "2008";
                button2.Text = "2011";
                button3.Text = "2005";
                button4.Text = "2004";
                label10.Text = "2008";

            }
            if (soruno == 2)
            {
                richTextBox1.Text = "ardahanın kuruluş yılı";
                button1.Text = "1990";
                button2.Text = "1992";
                button3.Text = "1996";
                button4.Text = "1991";
                label10.Text = "1992";

            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Atatürk'ün doğum yılı?";
                button1.Text = "1888";
                button2.Text = "1881";
                button3.Text = "1938";
                button4.Text = "1880";
                label10.Text = "1881";

            }


        }
        int doğrusayisi = 0;
        int yanlışsayisi = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            label9.Visible = true;
            label10.Visible =true;

            timer1.Enabled = false;

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

            label9.Text = button4.Text;
            if (label10.Text == label9.Text)
            {
                doğrusayisi++;
                label6.Text = doğrusayisi.ToString();
            }
            else
            {
                yanlışsayisi++;
                label5.Text = yanlışsayisi.ToString();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label9.Visible = true;
            label10.Visible = true;

            timer1.Enabled = false;

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

            label9.Text = button3.Text;
            if (label9.Text == label10.Text)
            {
                doğrusayisi++;
                label6.Text = doğrusayisi.ToString();
            }
            else
            {
                yanlışsayisi++;
                label5.Text = yanlışsayisi.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label9.Visible = true;
            label10.Visible = true;


            timer1.Enabled = false;

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

            label9.Text = button2.Text;
            if (label9.Text == label10.Text)
            {
                doğrusayisi++;
                label6.Text = doğrusayisi.ToString();
            }
            else
            {
                yanlışsayisi++;
                label5.Text = yanlışsayisi.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label9.Visible = true;
            label10.Visible = true;


            timer1.Enabled = false;

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;


            label9.Text = button1.Text;
            if (label9.Text == label10.Text)
            {
                doğrusayisi++;
                label6.Text = doğrusayisi.ToString();
            }
            else
            {
                yanlışsayisi++;
                label5.Text = yanlışsayisi.ToString();
            }
        }


        int süre = 20;

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            süre = Convert.ToInt32(label3.Text);
            süre = süre - 1;
            label3.Text=süre.ToString();

            if (süre == 0)
            {
                timer1.Enabled = false;
                yanlışsayisi++;
                label5.Text=yanlışsayisi.ToString() ;
               
            }

        }
     private void Form1_Load(object sender, EventArgs e)
     {
            label9.Visible= false;
            label10.Visible= false;
     }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
