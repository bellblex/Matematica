using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Quiz_matematica
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            if (r2 == 1)
            {
                textBox1.Text = a;
                textBox2.Text = b;
                textBox3.Text = c; 
            }
        }
        public static string userAnswer1, userAnswer2, userAnswer3, a, b, c;
        public static int r2, a5;
        private void button2_Click(object sender, EventArgs e)
        {
            userAnswer1 = textBox1.Text.ToLower();
            userAnswer2 = textBox2.Text.ToLower();
            userAnswer3 = textBox3.Text.ToLower();
            a = textBox1.Text.ToLower();
            b = textBox2.Text.ToLower();
            c = textBox3.Text.ToLower();

            if (userAnswer1 == "18")
            {
                Form10.pontuacao += 5;

            }
            if (userAnswer2 == "31,4" || userAnswer2 == "31.4")
            {
                Form10.pontuacao += 5;

            }
            if (userAnswer3 == "889")
            {
                Form10.pontuacao += 5;

            }
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Não te esqueças de responder a todas as questões!");
              
            }
            if (textBox1.Text != null && textBox2.Text != null && textBox3.Text != null)
            {
                r2 = 1;
                this.Close();
                (new Form13()).Show();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 abrir = new Form5();
            abrir.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a5 = 5;
            Form1 abrir = new Form1();
            abrir.Show();
            this.Hide();
        }
    }
}
