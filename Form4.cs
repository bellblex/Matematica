using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_matematica
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public static int r1, a3;
        private void button2_Click(object sender, EventArgs e)
        {
            
            if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false && radioButton4.Checked == false)
            {
                MessageBox.Show("Tens que escolher uma opção!");
                
               
            }
            if (radioButton1.Checked == true)
            {
                r1 = 1;
              Form10.pontuacao += 10;
                
              
            }
            if (radioButton2.Checked == true)
            {

                r1 = 2;

            }
            if (radioButton3.Checked == true )
            {
                r1 = 3;

            }
            if (radioButton4.Checked == true)
            {
                r1 = 4;

            }

                this.Close();
                (new Form5()).Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            a3 = 3;
            Form1 abrir = new Form1();
            abrir.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 abrir = new Form6();
            abrir.Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            radioButton1.Checked = false;

            if(r1 == 1)
            {
                radioButton1.Checked = true;
            }
            if (r1 == 2)
            {
                radioButton2.Checked = true;
            }
            if (r1 == 3)
            {
                radioButton3.Checked = true;
            }
            if (r1 == 4)
            {
                radioButton4.Checked = true;
            }

        }
    }
}
