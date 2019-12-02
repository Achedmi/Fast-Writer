using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace keyboard2
{
    public partial class Form1 : Form
    {

        char[] letter = "azeryuop qsdffghjk xcvbn 0123456789 ".ToCharArray();
        //i-m-w-l-t-j
        Random r = new Random();
        int c;
        string word;
        int quick;
        int i = 6;
        int cf = 0;

        public Form1()
        {
            
            InitializeComponent();
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gunaPanel2.Hide();
            gunaPanel3.Hide();

        }

        public void generate()
        {
            quick = Convert.ToInt16(txtseconds.Text);
            c = Convert.ToInt16(txthearts.Text);

            txtanswer.Enabled = false;
            txtanswer.BaseColor = Color.Gray;

            lbldethstring.Text = "Death Score : " + c.ToString();

            lbltime.Text = quick.ToString();
            word = "";

            if(started)
            {
                for (int i = 15; i >= 6; i--)
			    {
                    gunaPanel3.Controls.RemoveAt(i);
			    }
            }


            int x = 30;
            for (int i = 1; i <= 10; i++)
            {
                

                Label lbltest = new Label();
                lbltest.Location = new Point(x, 85);
                x = x + 15;
                lbltest.Font = new Font("Segoe UI", 14,FontStyle.Bold);
                lbltest.Size = new Size(18, 28); 
                lbltest.BackColor = Color.Transparent;
                lbltest.ForeColor = Color.White;
                lbltest.Name = "lbltest" + i.ToString();
                lbltest.Text = letter[r.Next(0, 35)].ToString();
                
                word = word + lbltest.Text;
                gunaPanel3.Controls.Add(lbltest);

            }


        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            if ((txtseconds.Text == "How Many Seconds You Want ?" || txtseconds.Text == "" || txtseconds.Text == "0" || txthearts.Text == "How Many Hearts You Want ?" || txthearts.Text == "" || txthearts.Text == "0"))
            {
                return;
            }

            gunaPanel2.Hide();
            gunaTransition1.Show(gunaPanel3);

            generate();

 
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {

                gunaPanel1.Hide();
                gunaTransition1.Show(gunaPanel2);

        }

        private void gunaTextBox2_Enter(object sender, EventArgs e)
        {
            if (txtseconds.Text == "How Many Seconds You Want ?")
            {
                txtseconds.Text = "";
            }
        }

        private void gunaTextBox2_Leave(object sender, EventArgs e)
        {
            if (txtseconds.Text == "")
            {
                txtseconds.Text = "How Many Seconds You Want ?";
            }
        }

        private void gunaTextBox1_Enter(object sender, EventArgs e)
        {
            if (txthearts.Text == "How Many Hearts You Want ?")
            {
                txthearts.Text = "";
            }
        }

        private void gunaTextBox1_Leave(object sender, EventArgs e)
        {
            if (txthearts.Text == "")
            {
                txthearts.Text = "How Many Hearts You Want ?";
            }
        }

        private void gunaTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void gunaTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        bool started = false;
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();

            i = 6;

            txtanswer.Enabled = true;
            txtanswer.BaseColor = Color.White;
            txtanswer.Focus();

            btnstart2.Enabled = false;
            btnrestart.Enabled = false;
            btnverifie.Enabled = true;

            

        }

        private void btnrestart_Click(object sender, EventArgs e)
        {
            btnstart2.Enabled = true;
            started = true;
            generate();
            txtanswer.Text = "";
            lose = false;
           

        }

        private void btnverifie_Click(object sender, EventArgs e)
        {
            btnverifie.Enabled = false;

            if (word == txtanswer.Text)
            {
                lbldethstring.Text = "Good Job";
                timer1.Stop();
                timer2.Stop();
                //win = true;
                btnrestart.Enabled = true;
                // btnstart.Enabled = true;
                txtanswer.Enabled = false;
                txtanswer.BaseColor = Color.Gray;
                

            }
            else
            {
                timer1.Stop();
                lbldethstring.Text = "Not the same, try another time";
                btnrestart.Enabled = true;
                txtanswer.Enabled = false;
                txtanswer.BaseColor = Color.Gray;
            }
            btnstart.Enabled = false;
            
        }
        int t = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            quick--;
            lbltime.Text = quick.ToString();
            if (quick == 0)
            {
                timer1.Stop();
                timer2.Stop();
                txtanswer.Enabled = false;
                txtanswer.BaseColor = Color.Gray;

                lbldethstring.Text = "you lose";
                btnverifie.Enabled = false;
                btnrestart.Enabled = true;
                
            }

            
         

        }
        bool lose = false;
        private void txtanswer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt16(e.KeyChar) == 13)
            {
                btnverifie_Click(sender, e);
                return;
            }
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
            
            if (e.KeyChar.ToString() != gunaPanel3.Controls[i].Text && !char.IsControl(e.KeyChar))
            {
                cf++;
                c--;
                lbldethstring.Text = "Death Score : " + c.ToString();
                e.Handled = true;
                if (/*quick <= 0 ||*/ c <= 0)
                {
                    e.Handled = true;
                    lbldethstring.Text = "you lose";
                    btnverifie.Enabled = false;
                    txtanswer.BaseColor = Color.Gray;

                    btnrestart.Enabled = true;
                    txtanswer.Enabled = false;
                    timer1.Stop();
                    timer2.Stop();
                }
                getitfalse(i);
                return;
            }
            
            if (i <= gunaPanel3.Controls.Count)
            {
                i++;
                getitright(i-1);               
                removeblack(i);
                if (i == gunaPanel3.Controls.Count)
                {
                    timer1.Stop();
                    timer2.Stop();

                }
                
            }

        }


        private void timer2_Tick(object sender, EventArgs e)
        {
            if (t == 1)
            {
                gunaPanel3.Controls[i].BackColor = Color.Black;
                t = 2;

            }
            else
            {
                gunaPanel3.Controls[i].BackColor = Color.Transparent;
                t = 1;

            }
            if (i > 8 && gunaPanel3.Controls[i - 1].BackColor == Color.Black)
            {
                //MessageBox.Show("hi");
                gunaPanel3.Controls[i - 1].BackColor = Color.Transparent;
            }
            
        }

        public void removeblack(int i)
        {
                if (gunaPanel3.Controls[i-1].BackColor == Color.Black)
                {
                    gunaPanel3.Controls[i-1].BackColor = Color.Transparent;
                }
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            if (t == 1)
            {
                gunaPanel3.Controls[i].BackColor = Color.Black;
                t = 2;

            }
            else
            {
                gunaPanel3.Controls[i].BackColor = Color.Transparent;
                t = 1;
            }
                
        }
        public void getitfalse(int i)
        {
            gunaPanel3.Controls[i].ForeColor = Color.Red;
        }

        public void getitright(int i)
        {
            if (gunaPanel3.Controls[i].ForeColor != Color.Red )
            {
                gunaPanel3.Controls[i].ForeColor = Color.Green;
            }
        }

    }
}
