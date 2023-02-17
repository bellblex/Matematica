using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Quiz_matematica
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
        this.WindowState = FormWindowState.Maximized;



        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = Form1.nome;
            textBox1.Text = Convert.ToString(Form10.pontuacao);
            



        }

        private void button2_Click(object sender, EventArgs e)
        {
       
            this.Close();
            (new Form16()).Show();
      
          
        }
    }
}
