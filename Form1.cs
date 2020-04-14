using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoRPG
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
           
        }

        private void BtnInicioSesion_Click(object sender, EventArgs e)
        {
            
            Form5 miForm5 = new Form5();
            this.Hide();
            miForm5.Show();
            

        }

        private void BtnRegistro_Click(object sender, EventArgs e)
        {
            Form2 miForm2 = new Form2();
            this.Hide();
            miForm2.Show();
            
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
         
        
    }
}
