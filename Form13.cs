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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }
public static string userAnswer1, a;
        public static int r2,a6;
        private void Form13_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            if (r2 == 1)
            {
                textBox1.Text = a;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form9 abrir = new Form9();
            abrir.Show();
            this.Hide();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            userAnswer1 = textBox1.Text.ToLower();
            a = textBox1.Text.ToLower();



            if (userAnswer1 == "31")
            {
                Form10.pontuacao += 5;

            }
            
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Não te esqueças de responder a todas as questões!");
               
            }
            if (textBox1.Text != null)
            {
                r2 = 1;
                this.Close();
                (new Form12()).Show();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a6 = 6;
            Form1 abrir = new Form1();
            abrir.Show();
            this.Hide();
        }
    }
}
