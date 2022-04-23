using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_dizinin_çarpımlarının_toplamı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Dizilerin toplamı ve çarpımı";
        }
        

    
        int x = 0, y,yedek,g=0,h,edek;
        int[] say = new int[3];
        int[] ay = new int[3];
        int n,m,b;
        private void button1_Click(object sender, EventArgs e)
        {
             say[x] = Convert.ToInt16(textBox1.Text);
            x++;
            textBox1.Clear();
            textBox1.Focus();
            if (x==3)
            {
                textBox1.Enabled = false;
            }

           
        }
    
    
        private void button2_Click(object sender, EventArgs e)
        {
             for ( y = 0; y < say.Length; y++)
            {
                listBox1.Items.Add(say[y]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
               listBox1.Items.Clear();
            for (x = 0; x <2; x++)
            {
                for (y = x + 1; y < 3; y++)
                {
                    if (say[x] > say[y])
                    {


                        yedek = say[x];
                        say[x] = say[y];
                        say[y] = yedek;

                    }

                  
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ay[g] = Convert.ToInt16(textBox2.Text);
            g++;
            textBox2.Clear();
            textBox2.Focus();
            if (g == 3)
            {
                textBox2.Enabled = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (h = 0; h < ay.Length; h++)
            {
                listBox2.Items.Add(ay[h]);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
             listBox2.Items.Clear();
            for (g = 0; g <2; g++)
            {
                for (h = g + 1; h< 3; h++)
                {
                    if (ay[g] > ay[h])
                    {


                        edek = ay[g];
                        ay[g] = ay[h];
                        ay[h] = edek;

                    }

                  
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            n = say[x] * ay[g];
            label4.Text = "Carpım sonuc" + n;
            b = n + x + g;
            label5.Text = "Toplam sonuc"+b;
        }
        }
        }
    

