using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Quiz_matematica
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }
        public static int pontuacao = 0;
        public static int r1, r2, a1;

        private void Form10_Load(object sender, EventArgs e)
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
                pontuacao += 10;

            }
            if (radioButton3.Checked == true)
            {
                r1 = 3;

            }
            if (radioButton3.Checked == true)
            {
                r1 = 4;

            }
         
              
          
            this.Close();
            (new Form6()).Show();

        }
       

        private void button3_Click(object sender, EventArgs e)
        {
            a1 = 1;
            Form1 abrir = new Form1();
            abrir.Show();
            this.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
