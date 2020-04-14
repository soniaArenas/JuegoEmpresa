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
    public partial class Form2 : Form
    {
        ClsConexion cone;
        public Form2()
        {
            InitializeComponent();
            cone = new ClsConexion();
           
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            btnRegistro.Enabled = false;
            
        }

        private void ChbPolitica_CheckedChanged(object sender, EventArgs e)
        {
            if (chbPolitica.Checked )
            {
                btnRegistro.Enabled = true;
            }
            else
            {
                btnRegistro.Enabled = false;
            }
        }

        private void LklPolitica_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 formPolitica = new Form3();
           
            formPolitica.Show();
           
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void BtnRegistro_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cone.InsertarJugador(txtUsuRegistro.Text,txtPassRegistro.Text,txtPreguntaSecreta.Text,txtMail.Text,txtCiudad.Text,Convert.ToInt32(txtEdad.Text)));
           int id= cone.ObtenerIdJugador(txtUsuRegistro.Text);
            cone.InsertarPartida(id,1,2,1000,100,0,0,0,0,0,2);
           int idPar= cone.ObtenerIdPartida(id);
            Form4 miPartida = new Form4(idPar);
            this.Hide();
            miPartida.Show();
            this.Close();
        }
    }
}
