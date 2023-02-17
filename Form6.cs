using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Quiz_matematica
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

 public static int r1, a2;
        private void button1_Click(object sender, EventArgs e)
        {
           
            Form10 abrir = new Form10();
            abrir.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a2 = 2;

            Form1 abrir = new Form1();
            abrir.Show();
            this.Hide();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            radioButton1.Checked = false;

            if (r1 == 1)
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

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
      
        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false && radioButton4.Checked == false)
            {
                MessageBox.Show("Não te esqueças de responder a todas as questões!");
                
            }
            if (radioButton1.Checked == true)
            {
                r1 = 1;


            }
            if (radioButton2.Checked == true)
            {

                r1 = 2;

            }
            if (radioButton3.Checked == true)
            {
                Form10.pontuacao += 10;
                r1 = 3;

            }
            if (radioButton4.Checked == true)
            {
                r1 = 4;

            }
                this.Close();
                (new Form4()).Show();


        }
    }
}
