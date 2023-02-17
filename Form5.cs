using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Quiz_matematica
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        public static string userAnswer1, userAnswer2, userAnswer3, userAnswer4, a, b, c, d;
        public static int r2, a4;
        private void button2_Click(object sender, EventArgs e)
        {
            userAnswer1 = textBox1.Text.ToLower();
            userAnswer2 = textBox2.Text.ToLower();
            userAnswer3 = textBox3.Text.ToLower();
            userAnswer4 = textBox4.Text.ToLower();
            a = textBox1.Text.ToLower();
            b = textBox2.Text.ToLower();
            c = textBox3.Text.ToLower();
            d = textBox4.Text.ToLower();

            if (userAnswer1 == "v" || userAnswer1 == "V")
            {
                Form10.pontuacao += 5;
            }
            if (userAnswer2 == "f" || userAnswer2 == "F")
            {
                Form10.pontuacao += 5;
            }
            if (userAnswer3 == "v" || userAnswer3 == "V")
            {
                Form10.pontuacao += 5;
            }
            if (userAnswer4 == "f" || userAnswer4 == "F")
            {
                Form10.pontuacao += 5;
            }
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Não te esqueças de responder a todas as questões!");

            }

            if (textBox1.Text != null && textBox2.Text != null && textBox3.Text != null && textBox4.Text != null)
            {   
                r2 = 1;
                this.Close();
                (new Form9()).Show();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form4 abrir = new Form4();
            abrir.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a4 = 4;
            Form1 abrir = new Form1();
            abrir.Show();
            this.Hide();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            if (r2 == 1)
            {
                textBox1.Text = a;
                textBox2.Text = b;
                textBox3.Text = c;
                textBox4.Text = d;
            }

        }
     
        
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
