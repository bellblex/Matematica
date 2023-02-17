using System.Diagnostics.Metrics;
using System.Security.Permissions;
using System.Xml.Linq;

namespace Quiz_matematica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string nome = "";
      

        
        private void button1_Click(object sender, EventArgs e)
        {
            nome = textBox1.Text;
            Form10 abrir= new Form10();
            abrir.Show();
            this.Hide(); 

        }

   
        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Maximized;

        }
      
       
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        
        private void SaveScore()
        {
           
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Form10.a1 == 1)
            {
                this.Close();
                (new Form10()).Show();
            }
            if (Form6.a2 == 2)
            {
                this.Close();
                (new Form6()).Show();
            }
            if (Form4.a3 == 3)
            {
                this.Close();
                (new Form4()).Show();
            }

            if (Form5.a4 == 4)
            {
                this.Close();
                (new Form5()).Show();
            }
            if (Form9.a5 == 5)
            {
                this.Close();
                (new Form9()).Show();
            }
            if (Form13.a6 == 6)
            {
                this.Close();
                (new Form13()).Show();
            }
            if (Form12.a7 == 7)
            {
                this.Close();
                (new Form12()).Show();
            }
            if (Form14.a8 == 8)
            {
                this.Close();
                (new Form14()).Show();
            }
            if (Form15.a9 == 9)
            {
                this.Close();
                (new Form15()).Show();
            }
            if (Form3.a10 == 10)
            {
                this.Close();
                (new Form3()).Show();
            }

        }
    }
}