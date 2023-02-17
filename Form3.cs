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
using Newtonsoft.Json;

namespace Quiz_matematica
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public static string userAnswer1, userAnswer2, userAnswer3, userAnswer4, userAnswer5, a, b, c, d, f;
        public static int r2, a10;
        private void button2_Click(object sender, EventArgs e)
        {
            userAnswer1 = textBox1.Text.ToLower();
            userAnswer2 = textBox2.Text.ToLower();
            userAnswer3 = textBox3.Text.ToLower();
            userAnswer4 = textBox4.Text.ToLower();
            userAnswer5= textBox5.Text.ToLower();
            a = textBox1.Text.ToLower();
            b = textBox2.Text.ToLower();
            c = textBox3.Text.ToLower();
            d = textBox4.Text.ToLower();
            f = textBox5.Text.ToLower();

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
            if (userAnswer5 == "v" || userAnswer5 == "V")
            {
                Form10.pontuacao += 5;

            }
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("Nao te esquecas de responder a todas as questoes!");
               
            }
            if (textBox1.Text != null && textBox2.Text != null && textBox3.Text != null && textBox4.Text != null && textBox5.Text != null)
            {
                r2 = 1;
                this.Close();
                (new Form7()).Show();
        
            }

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form15 abrir = new Form15();
            abrir.Show();
            this.Hide();

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            if (r2 == 1)
            {
                textBox1.Text = a;
                textBox2.Text = b;
                textBox3.Text = c;
                textBox4.Text = d;
                textBox5.Text = f;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a10 = 10;
            Form1 abrir = new Form1();
            abrir.Show();
            this.Hide();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        
        public static string data, json;
        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            
        }
            }
        }
