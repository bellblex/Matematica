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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void Form15_Load(object sender, EventArgs e)
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
        public static string userAnswer1, userAnswer2, userAnswer3, userAnswer4, a, b, c, d;
        public static int r2, a9;
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


            if (userAnswer1 == "B" || userAnswer1 == "b")
            {
                Form10.pontuacao += 5;

            }
            if (userAnswer2 == "A" || userAnswer2 == "a")
            {
                Form10.pontuacao += 5;

            }
            if (userAnswer3 == "E" || userAnswer2 == "e")
            {
                Form10.pontuacao += 5;

            }
            if (userAnswer4 == "D" || userAnswer4 == "d")
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
                (new Form3()).Show();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {


  Form14 abrir = new Form14();
            abrir.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a9 = 9;
            Form1 abrir = new Form1();
            abrir.Show();
            this.Hide();
        }
    }
}
