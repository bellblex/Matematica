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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void label60_Click(object sender, EventArgs e)
        {

        }

        private void Form16_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            ActiveControl = label1;

        }
        private void Form16_Shown(object sender, EventArgs e)
        {
            label1.Focus();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form7 abrir = new Form7();
            abrir.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
