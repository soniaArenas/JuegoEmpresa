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
    public partial class Form5 : Form
    {
        ClsConexion cone;
        public Form5()
        {
            InitializeComponent();
            cone = new ClsConexion();
        }
        //controlar que los txt tengan contenido
        private void Form5_Load(object sender, EventArgs e)
        {
            //btnLogin.Enabled = false;
        }


        //private void ControlarTxt()
        //{
        //    if(txtUsuarioLogin.TextLength >0 || txtPassLogin.TextLength > 0)
        //    {
        //        btnLogin.Enabled = true;
        //    }
        //    else
        //    {
        //        btnLogin.Enabled = false;
        //    }
        //}


        //Redirecciones a otros forms mediante botones
        private void btnLogin_Click(object sender, EventArgs e)
        {
            int id = cone.ObtenerIdJugador(txtUsuarioLogin.Text);
            MessageBox.Show(id.ToString());
            Form4 miPartida = new Form4(id);
            this.Hide();
            miPartida.Show();
            this.Close();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            int id = cone.ObtenerIdJugador(txtUsuarioLogin.Text);
            int idPar = cone.ObtenerIdPartida(id);
            MessageBox.Show(id.ToString());
            Form4 miPartida = new Form4(idPar);
            this.Hide();
            miPartida.Show();
            this.Close();


        }

        private void btnOlvido_Click(object sender, EventArgs e)
        {
            Form6 formOlvido = new Form6();
            this.Hide();
            formOlvido.ShowDialog();
            this.Close();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Form1 formIni = new Form1();
            this.Hide();
            formIni.ShowDialog();
            this.Close();

        }

       
    }
}
