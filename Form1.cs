using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Proektna_NikolaKosturski102424
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        string[] izrazi = new string[] {"3+5/3+4", "2+3*5+6","65+3/5",
            "3*6+2/4","4*3+24/6","43*3-56/7","2+5*3","4/2+5","8+3*4","3-2*3",        //izrazi
            "9/3+8*5","15/3+5*6","24/4+16*2","19-3+5*4","3*4-15/5",
            "32/4+8*3","54/6+72/8","120/10+9*12","18/2+13*4","24+4/8","14*3-24/6",
            "54+64/8","34+15-32/12","76-16/7","58/12+23","56+32-12*3","43+32/42/7",
        "87+13/5","96+23/13+3","65+32"};
        string[] resenija = new string[] {"8.6","23","65.6","18.5","16","121","21","7",   //odgovori
            "20","-3","43","35","38","36","9","32","18","120","61","24.5","38","62",
            "46.3","13.7","27.8","52","6.2","89.6","100.7","97" };
        int x,counter1,counter2;
        string y;
        
        
         
        public Form1()
        {
            InitializeComponent();
            potvrdi.Enabled = false;
        }

        public string SetUpGame()
        {
            int index = rnd.Next(izrazi.Length);
            MatIzrazi.Text = izrazi[index];
            return MatIzrazi.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Resenie.Text += button1.Text;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Resenie.Text += button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Resenie.Text += button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Resenie.Text += button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Resenie.Text += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Resenie.Text += button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Resenie.Text += button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Resenie.Text += button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Resenie.Text += button9.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Resenie.Text += button12.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Resenie.Text += button13.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string brisi1, brisi2;
            brisi1 = Resenie.Text;
            brisi2 = brisi1.Remove(brisi1.Length - 1, 1);
            Resenie.Text = brisi2;
        }

        private void MatIzrazi_TextChanged(object sender, EventArgs e)
        {
            MatIzrazi.ReadOnly= true;
        }

        private void Resenie_TextChanged(object sender, EventArgs e)
        {
            Resenie.Enabled = false;
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
             Resenie.Text += button10.Text ;
        }
        private int s = 60; // sekundi
        private int m = 2; //minuti

        private void novaIgra_Click(object sender, EventArgs e) //kopce za nova igra
        {
            timer1.Enabled = false;
            s = 60;
            m = 2;
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(Tajmer);
            timer1.Interval = 1000;
            timer1.Start();
            counter1 = 0;
            label4.Text = counter1.ToString();
            counter2 = 0;
            label5.Text = counter2.ToString();
            Resenie.Text = string.Empty;
            SetUpGame();
            potvrdi.Enabled = true;
  
        }

        private void Tajmer(object sender, EventArgs e)  // funkcija za tajmerot
        {
            if (s >= 0 && m > 0)
            {
                s--;
                if (s == 0)
                {
                    m--;

                    s = 60;
                }

                label8.Text = m + ":" + s.ToString();
            }
            else if (s > 0)

            {
                s--;
                label8.Text = m + ":" + s;
            }
            else if (s == 0 && m == 0)
            {
                timer1.Stop();
                MessageBox.Show("Крај на играта");

            }
        }

        private void potvrdi_Click(object sender, EventArgs e) //kopce potvrdi
        {
            if(izrazi.Contains(MatIzrazi.Text))
            {
                x = Array.LastIndexOf(izrazi, MatIzrazi.Text);
                y = resenija[x];

                if(string.Equals(Resenie.Text,y))
                {
                    counter1++;
                    label4.Text = counter1.ToString();
                    Resenie.Text = string.Empty;
                    SetUpGame();
                }
                else
                {
                    counter2++;
                    label5.Text = counter2.ToString();
                    Resenie.Text = String.Empty;
                    SetUpGame();
                }
            }
        }
    }
}
