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

namespace Quiz_matematica
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            if (r2 == 1)
            {
                textBox1.Text = a;
                textBox2.Text = b;
            }
        }

        public static string userAnswer1, userAnswer2, a, b;
        public static int r2, a7;
        private void button2_Click(object sender, EventArgs e)
        {

            userAnswer1 = textBox1.Text.ToLower();
            userAnswer2 = textBox2.Text.ToLower();
            a = textBox1.Text.ToLower();
            b = textBox2.Text.ToLower();


            if (userAnswer1 == "10")
            {
                Form10.pontuacao += 5;

            }
            if (userAnswer2 == "5")
            {
                Form10.pontuacao += 5;

            }
            
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Não te esqueças de responder a todas as questões!");
               
            }
            if (textBox1.Text != null && textBox2.Text != null)
            {
                r2 = 1;
                this.Close();
                (new Form14()).Show();
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
Form13 abrir = new Form13();
            abrir.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a7 = 7;
            Form1 abrir = new Form1();
            abrir.Show();
            this.Hide();
        }
    }
}
