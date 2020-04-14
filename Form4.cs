using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoRPG
{
    public partial class Form4 : Form
    {
        ClsConexion cone;
        private string idParti;
        private string tipoProyec;
        private int idPar;
        private int conteo = 0;
        public Form4(int pidpar)
        {
            InitializeComponent();
            cone = new ClsConexion();
            lblPartida.Text = pidpar.ToString();
            txtPresupuesto.Text = cone.ObtenerPresupuesto(pidpar).ToString();
            txtTrabajadores.Text = cone.ObtenerTrabajadores(pidpar).ToString();
            txtMotivacion.Text = cone.ObtenerMotivacion(pidpar).ToString();
            txtNivel.Text = cone.ObtenerLvlPartida(pidpar).ToString();
            lblLvlOf1.Text = cone.ObtenerLvlOfi1(pidpar).ToString();
            lblLvlOf2.Text = cone.ObtenerLvlOfi2(pidpar).ToString();
            lblLvlOf3.Text = cone.ObtenerLvlOfi3(pidpar).ToString();
            lblLvlOf4.Text = cone.ObtenerLvlOfi4(pidpar).ToString();
            cone.ActualizarTrLibres(Convert.ToInt32(txtTrabajadores.Text), pidpar);

        }
        public string IdPartida
        {
            set
            {
                idParti = value;
                lblPartida.Text = idParti;

            }
        }
        public string TipoProyecto
        {
            set
            {
                tipoProyec = value;
                lblTipoPRoyecto.Text = tipoProyec;
            }
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            this.Proyectos();
        }


        private void Proyectos()
        {
            idPar = Convert.ToInt32(lblPartida.Text);
            int i = 0;
            int numPro = cone.ObtenerProyectos(idPar);
            int presuAc = Convert.ToInt32(txtPresupuesto.Text);
            int presuNu;
            if (lblTipoPRoyecto.Text == "web")
            {
                prgbProyectos.Visible = true;
                timer1.Enabled = true;
            }
            else if (lblTipoPRoyecto.Text == "app")
            {
                prgbProyectos2.Visible = true;
                tmProyec2.Enabled = true;
            }
            else if (lblTipoPRoyecto.Text == "juego")
            {
                prgbProyectos3.Visible = true;
                tmProyec3.Enabled = true;
            }
            else if (lblTipoPRoyecto.Text == "multi")
            {
                prgbProyectos4.Visible = true;
                tmProyec4.Enabled = true;
            }

        }
        //timers proyectos
        private void timer1_Tick(object sender, EventArgs e)
        {

            conteo++;
            lblConteo.Text = conteo.ToString();
            if (prgbProyectos.Value <= 99)
            {
                prgbProyectos.Value++;
            }
            else if (prgbProyectos.Value == 100)
            {

                prgbProyectos.Enabled = false;

            }
            if (conteo == 100)
            {
                this.seteoFinProyectos();
            }


        }
        private void tmProyec2_Tick(object sender, EventArgs e)
        {
            conteo++;
            lblConteo.Text = conteo.ToString();
            if (prgbProyectos2.Value <= 199)
            {
                prgbProyectos2.Value++;
            }
            else if (prgbProyectos2.Value == 200)
            {
                prgbProyectos2.Enabled = false;
            }
            if (conteo == 200)
            {
                this.seteoFinProyectos();
            }

        }
        private void tmProyec3_Tick(object sender, EventArgs e)
        {
            conteo++;
            lblConteo.Text = conteo.ToString();
            if (prgbProyectos3.Value <= 499)
            {
                prgbProyectos3.Value++;
            }
            else if (prgbProyectos3.Value == 500)
            {
                prgbProyectos3.Enabled = false;
            }
            if (conteo == 500)
            {
                this.seteoFinProyectos();
            }

        }
        private void tmProyec4_Tick(object sender, EventArgs e)
        {

            conteo++;
            lblConteo.Text = conteo.ToString();
            if (prgbProyectos.Value <= 999)
            {
                prgbProyectos.Value++;
            }
            else if (prgbProyectos.Value == 1000)
            {
                prgbProyectos.Enabled = false;
            }
            if (conteo == 1000)
            {
                this.seteoFinProyectos();
            }

        }
        private void seteoFinProyectos()
        {
            idPar = Convert.ToInt32(lblPartida.Text);

            int numPro = cone.ObtenerProyectos(idPar);
            int presuAc = Convert.ToInt32(txtPresupuesto.Text);
            int trLibres = Convert.ToInt32(cone.ObtenerTraLibres(idPar));
            int trLibNu;
            int presuNu;
            if (lblTipoPRoyecto.Text == "web")
            {
                MessageBox.Show("El cliente ha quedado encantado con el el proyecto que le hemos entregado! Te ha realizado la transferencia con el pago de 2.000€ ");
                presuNu = presuAc + 2000;
                txtPresupuesto.Text = presuNu.ToString();
                cone.ActualizarPresupuesto(Convert.ToDouble(presuNu), idPar);
                trLibNu = trLibres + 2;
                cone.ActualizarTrLibres(trLibNu, idPar);
                prgbProyectos.Visible = false;
            }
            else if (lblTipoPRoyecto.Text == "app")
            {

                MessageBox.Show("El cliente ha quedado encantado con el el proyecto que le hemos entregado! Te ha realizado la transferencia con el pago de 5.000€ ");
                presuNu = presuAc + 5000;
                txtPresupuesto.Text = presuNu.ToString();
                cone.ActualizarPresupuesto(Convert.ToDouble(presuNu), idPar);
                trLibNu = trLibres + 6;
                cone.ActualizarTrLibres(trLibNu, idPar);
                prgbProyectos2.Visible = false;
            }
            else if (lblTipoPRoyecto.Text == "juego")
            {
                MessageBox.Show("El cliente ha quedado encantado con el el proyecto que le hemos entregado! Te ha realizado la transferencia con el pago de 15.000€ ");
                presuNu = presuAc + 15000;
                txtPresupuesto.Text = presuNu.ToString();
                cone.ActualizarPresupuesto(Convert.ToDouble(presuNu), idPar);
                trLibNu = trLibres + 14;
                cone.ActualizarTrLibres(trLibNu, idPar);
                prgbProyectos3.Visible = false;
            }
            else if (lblTipoPRoyecto.Text == "multi")
            {
                MessageBox.Show("El cliente ha quedado encantado con el el proyecto que le hemos entregado! Te ha realizado la transferencia con el pago de 50.000€ ");
                presuNu = presuAc + 50000;
                txtPresupuesto.Text = presuNu.ToString();
                cone.ActualizarPresupuesto(Convert.ToDouble(presuNu), idPar);
                trLibNu = trLibres + 25;
                cone.ActualizarTrLibres(trLibNu, idPar);
                prgbProyectos4.Visible = false;
            }

        }


        private void btnProyecto_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Quieres aceptar un proyecto nuevo?", "Nuevo Proyecto", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                Form8 nuevoProyeco = new Form8();
                nuevoProyeco.IdPartida = lblPartida.Text;
                this.Hide();
                nuevoProyeco.Show();

                this.Close();
            }


        }
        //LLama al form de eleccion de incentivo
        private void btnIncentivar_Click(object sender, EventArgs e)
        {
            Form7 formMotivar = new Form7();
            formMotivar.IdPartida = lblPartida.Text;
            this.Hide();
            formMotivar.Show();
            this.Close();
        }

        //Para crear las oficinas o actualzar
        private void BtnOfiNueva_Click(object sender, EventArgs e)
        {

            int lvlOf1 = Convert.ToInt32(cone.ObtenerLvlOfi1(idPar));
            int lvlOf2 = Convert.ToInt32(cone.ObtenerLvlOfi2(idPar));
            int lvlOf3 = Convert.ToInt32(cone.ObtenerLvlOfi3(idPar));
            int lvlOf4 = Convert.ToInt32(cone.ObtenerLvlOfi4(idPar));
            double presuAct = cone.ObtenerPresupuesto(idPar);
            MessageBox.Show("presu:" + presuAct);
            double presuNu;

            if (lvlOf1 == 0)
            {
                DialogResult resultado = MessageBox.Show("Dejar el CoWorking y tener tu primera oficina de nivel 1 cuesta 500€", "Ampliar Oficina1", MessageBoxButtons.OKCancel);
                if (resultado == DialogResult.OK)
                {
                    if (presuAct >= 500)
                    {
                        lblLvlOf1.Text = "1";
                        pbOf1Lvl1.Visible = true;
                        cone.ActualizaLvlOf1(1, idPar);

                        presuNu = presuAct - 500;
                        MessageBox.Show("presuNu:" + presuNu);
                        txtPresupuesto.Text = presuNu.ToString();
                        cone.ActualizarPresupuesto(presuNu, idPar);
                        lblPresu.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("No tienes suficiente presupuesto para abrir una oficina, creo que  deberías continuar en el coworking y trabajar un poquito si no quieres acabar debajo de un puente....");
                    }

                }

            }
            else if (lvlOf1 == 1)
            {
                DialogResult resultado = MessageBox.Show("Para poder tener tu primera oficina de nivel 2 tendrás que pagar 1000€", "Ampliar Oficina1", MessageBoxButtons.OKCancel);
                if (resultado == DialogResult.OK)
                {
                    if (presuAct >= 1000)
                    {

                        lblLvlOf1.Text = "2";
                        pbOf1Lvl1.Visible = false;
                        pbOf1Lvl2.Visible = true;
                        cone.ActualizaLvlOf1(2, idPar);
                        presuNu = presuAct - 1000;
                        txtPresupuesto.Text = presuNu.ToString();
                        cone.ActualizarPresupuesto(presuNu, idPar);
                    }
                    else
                    {
                        MessageBox.Show("No tienes suficiente presupuesto para abrir una oficina nueva! Vas un poquito deprisa no??? Frenaaa!");
                    }

                }
            }
            else if (lvlOf1 == 2)
            {
                DialogResult resultado = MessageBox.Show("Tienes 1500€ para ampliar tu oficina a nivel 3??", "Ampliar Oficina1", MessageBoxButtons.OKCancel);
                if (resultado == DialogResult.OK)
                {
                    if (presuAct >= 1500)
                    {
                        lblLvlOf1.Text = "3";
                        pbOf1Lvl2.Visible = false;
                        pbOf1Lvl3.Visible = true;
                        cone.ActualizaLvlOf1(3, idPar);
                        presuNu = presuAct - 1500;
                        txtPresupuesto.Text = presuNu.ToString();
                        cone.ActualizarPresupuesto(presuNu, idPar);
                    }
                    else
                    {
                        MessageBox.Show("No tienes suficiente presupuesto para abrir una oficina nueva! Vas un poquito deprisa no??? Frenaaa!");
                    }

                }
            }
            else if (lvlOf1 == 3)
            {
                DialogResult resultado = MessageBox.Show("Para tener tu primera oficina de nivel 4 pagarás 2500€", "Ampliar Oficina1", MessageBoxButtons.OKCancel);
                if (resultado == DialogResult.OK)
                {
                    if (presuAct >= 2500)
                    {
                        lblLvlOf1.Text = "4";
                        pbOf1Lvl3.Visible = false;
                        pbOf1Lvl4.Visible = true;
                        cone.ActualizaLvlOf1(4, idPar);
                        presuNu = presuAct - 2500;
                        txtPresupuesto.Text = presuNu.ToString();
                        cone.ActualizarPresupuesto(presuNu, idPar);
                    }
                    else
                    {
                        MessageBox.Show("No tienes suficiente presupuesto para abrir una oficina nueva! Vas un poquito deprisa no??? Frenaaa!");
                    }
                }
            }
            else if (lvlOf1 == 4)
            {
                if (lvlOf2 == 0)
                {
                    DialogResult resultado = MessageBox.Show("Uau!!! Tu seguna oficina! Esto ya es otro nivel, y te costará 3500€", "Ampliar Oficina2", MessageBoxButtons.OKCancel);
                    if (resultado == DialogResult.OK)
                    {
                        if (presuAct >= 3500)
                        {

                            lblLvlOf2.Text = "1";
                            pbOf2Lvl1.Visible = true;
                            cone.ActualizaLvlOf2(1, idPar);
                            presuNu = presuAct - 3500;
                            txtPresupuesto.Text = presuNu.ToString();
                            cone.ActualizarPresupuesto(presuNu, idPar);

                        }
                        else
                        {
                            MessageBox.Show("No tienes suficiente presupuesto para abrir una oficina nueva! Vas un poquito deprisa no??? Frenaaa!");
                        }
                    }
                }
                else if (lvlOf2 == 1)
                {
                    DialogResult resultado = MessageBox.Show("Bueno aquí tenemos un magnate... Para subir de nivel tu segunda oficina necesitas 4500€", "Ampliar Oficina2", MessageBoxButtons.OKCancel);
                    if (resultado == DialogResult.OK)
                    {
                        if (presuAct >= 4500)
                        {
                            lblLvlOf2.Text = "2";
                            pbOf2Lvl1.Visible = false;
                            pbOf2Lvl2.Visible = true;
                            cone.ActualizaLvlOf2(2, idPar);
                            presuNu = presuAct - 4500;
                            txtPresupuesto.Text = presuNu.ToString();
                            cone.ActualizarPresupuesto(presuNu, idPar);
                        }
                        else
                        {
                            MessageBox.Show("No tienes suficiente presupuesto para abrir una oficina nueva! Vas un poquito deprisa no??? Frenaaa!");
                        }
                        }
                }
               else if (lvlOf2 == 2)
                {
                    DialogResult resultado = MessageBox.Show("Tener tu segunda oficina de nivel 3 cuesta 5500€", "Ampliar Oficina2", MessageBoxButtons.OKCancel);
                    if (resultado == DialogResult.OK)
                    {
                        if (presuAct >= 5500)
                        {
                            lblLvlOf2.Text = "3";
                        pbOf2Lvl2.Visible = false;
                        pbOf2Lvl3.Visible = true;
                        cone.ActualizaLvlOf2(3, idPar);
                        presuNu = presuAct - 5500;
                        txtPresupuesto.Text = presuNu.ToString();
                        cone.ActualizarPresupuesto(presuNu, idPar);
                        }
                        else
                        {
                            MessageBox.Show("No tienes suficiente presupuesto para abrir una oficina nueva! Vas un poquito deprisa no??? Frenaaa!");
                        }
                    }
                }
                else if (lvlOf2 == 3)
                {
                    DialogResult resultado = MessageBox.Show("Vaya! Tener tu segunda oficina de nivel 4 cuesta 6500€", "Ampliar Oficina2", MessageBoxButtons.OKCancel);
                    if (resultado == DialogResult.OK)
                    {

                        if (presuAct >= 6500)
                        {
                            lblLvlOf2.Text = "4";
                        pbOf2Lvl3.Visible = false;
                        pbOf2Lvl4.Visible = true;
                        cone.ActualizaLvlOf2(4, idPar);
                        presuNu = presuAct - 6500;
                        txtPresupuesto.Text = presuNu.ToString();
                        cone.ActualizarPresupuesto(presuNu, idPar);
                        }
                        else
                        {
                            MessageBox.Show("No tienes suficiente presupuesto para abrir una oficina nueva! Vas un poquito deprisa no??? Frenaaa!");
                        }
                    }
                }
                else if (lvlOf2 == 4)
                {
                    if (lvlOf3 == 0)
                    {
                        DialogResult resultado = MessageBox.Show("Pero bueno! Si parece que no tienes freno! Ya tu tercera oficina de nivel 1!! Pues cuesta 7500€", "Ampliar Oficina3", MessageBoxButtons.OKCancel);
                        if (resultado == DialogResult.OK)
                        {

                            if (presuAct >= 7500)
                            {
                                lblLvlOf3.Text = "1";
                            pbOf3Lvl1.Visible = true;
                            cone.ActualizaLvlOf3(1, idPar);
                            presuNu = presuAct - 7500;
                            txtPresupuesto.Text = presuNu.ToString();
                            cone.ActualizarPresupuesto(presuNu, idPar);
                        }
                        else
                        {
                            MessageBox.Show("No tienes suficiente presupuesto para abrir una oficina nueva! Vas un poquito deprisa no??? Frenaaa!");
                        }
                    }

                    }
                   else if (lvlOf3 == 1)
                    {
                        DialogResult resultado = MessageBox.Show("Tener tu tercera oficina de nivel 2 cuesta 8500€", "Ampliar Oficina3", MessageBoxButtons.OKCancel);
                        if (resultado == DialogResult.OK)
                        {
                            if (presuAct >=8500)
                            {
                                lblLvlOf3.Text = "2";
                            pbOf3Lvl1.Visible = false;
                            pbOf3Lvl2.Visible = true;
                            cone.ActualizaLvlOf3(2, idPar);
                            presuNu = presuAct - 8500;
                            txtPresupuesto.Text = presuNu.ToString();
                            cone.ActualizarPresupuesto(presuNu, idPar);
                            }
                            else
                            {
                                MessageBox.Show("No tienes suficiente presupuesto para abrir una oficina nueva! Vas un poquito deprisa no??? Frenaaa!");
                            }
                        }
                    }
                   else if (lvlOf3 == 2)
                    {
                        DialogResult resultado = MessageBox.Show("Tener tu tercera oficina de nivel 3 cuesta 9500€", "Ampliar Oficina3", MessageBoxButtons.OKCancel);
                        if (resultado == DialogResult.OK)
                        {
                            if (presuAct >= 9500)
                            {
                                lblLvlOf3.Text = "3";
                            pbOf3Lvl2.Visible = false;
                            pbOf3Lvl3.Visible = true;
                            cone.ActualizaLvlOf3(3, idPar);
                            presuNu = presuAct - 9500;
                            txtPresupuesto.Text = presuNu.ToString();
                            cone.ActualizarPresupuesto(presuNu, idPar);
                        }
                        else
                        {
                            MessageBox.Show("No tienes suficiente presupuesto para abrir una oficina nueva! Vas un poquito deprisa no??? Frenaaa!");
                        }
                    }
                    }
                    if (lvlOf3 == 3)
                    {
                        DialogResult resultado = MessageBox.Show("Tener tu tercera oficina de nivel 4 cuesta 10500€", "Ampliar Oficina3", MessageBoxButtons.OKCancel);
                        if (resultado == DialogResult.OK)
                        {
                            if (presuAct >= 10500)
                            {
                                lblLvlOf3.Text = "4";
                            pbOf3Lvl3.Visible = false;
                            pbOf3Lvl4.Visible = true;
                            cone.ActualizaLvlOf3(4, idPar);
                            presuNu = presuAct - 10500;
                            txtPresupuesto.Text = presuNu.ToString();
                            cone.ActualizarPresupuesto(presuNu, idPar);
                            }
                            else
                            {
                                MessageBox.Show("No tienes suficiente presupuesto para abrir una oficina nueva! Vas un poquito deprisa no??? Frenaaa!");
                            }
                        }
                    }
                   else if (lvlOf3 == 4)
                    {
                        if (lvlOf4 == 0)
                        {
                            DialogResult resultado = MessageBox.Show("Tener tu cuarta oficina de nivel 4 cuesta 12000€", "Ampliar Oficina4", MessageBoxButtons.OKCancel);
                            if (resultado == DialogResult.OK)
                            {
                                if (presuAct >= 12000)
                                {
                                    lblLvlOf4.Text = "1";
                                pbOf4Lvl1.Visible = true;
                                cone.ActualizaLvlOf4(1, idPar);
                                presuNu = presuAct - 12000;
                                txtPresupuesto.Text = presuNu.ToString();
                                cone.ActualizarPresupuesto(presuNu, idPar);
                            }
                            else
                            {
                                MessageBox.Show("No tienes suficiente presupuesto para abrir una oficina nueva! Vas un poquito deprisa no??? Frenaaa!");
                            }
                        }

                        }
                        if (lvlOf4 == 1)
                        {
                            DialogResult resultado = MessageBox.Show("Tener tu cuarta oficina de nivel 2 cuesta 14000€", "Ampliar Oficina4", MessageBoxButtons.OKCancel);
                            if (resultado == DialogResult.OK)
                            {
                                if (presuAct >= 14000)
                                {
                                    lblLvlOf4.Text = "2";
                                pbOf4Lvl1.Visible = false;
                                pbOf4Lvl2.Visible = true;
                                cone.ActualizaLvlOf4(2, idPar);
                                presuNu = presuAct - 14000;
                                txtPresupuesto.Text = presuNu.ToString();
                                cone.ActualizarPresupuesto(presuNu, idPar);
                                }
                                else
                                {
                                    MessageBox.Show("No tienes suficiente presupuesto para abrir una oficina nueva! Vas un poquito deprisa no??? Frenaaa!");
                                }
                            }
                        }
                        if (lvlOf4 == 2)
                        {
                            DialogResult resultado = MessageBox.Show("Tener tu cuarta oficina de nivel 3 cuesta 16000€", "Ampliar Oficina4", MessageBoxButtons.OKCancel);
                            if (resultado == DialogResult.OK)
                            {
                                if (presuAct >= 16000)
                                {
                                    lblLvlOf4.Text = "3";
                                pbOf4Lvl2.Visible = false;
                                pbOf4Lvl3.Visible = true;
                                cone.ActualizaLvlOf4(3, idPar);
                                presuNu = presuAct - 16000;
                                txtPresupuesto.Text = presuNu.ToString();
                                cone.ActualizarPresupuesto(presuNu, idPar);
                                }
                                else
                                {
                                    MessageBox.Show("No tienes suficiente presupuesto para abrir una oficina nueva! Vas un poquito deprisa no??? Frenaaa!");
                                }
                            }
                        }
                        if (lvlOf4 == 3)
                        {
                            DialogResult resultado = MessageBox.Show("Tener tu cuarta oficina de nivel 4 cuesta 20000€", "Ampliar Oficina4", MessageBoxButtons.OKCancel);
                            if (resultado == DialogResult.OK)
                            {
                                if (presuAct >= 20000)
                                {
                                    lblLvlOf4.Text = "4";
                                pbOf4Lvl3.Visible = false;
                                pbOf4Lvl4.Visible = true;
                                cone.ActualizaLvlOf4(4, idPar);
                                presuNu = presuAct - 20000;
                                txtPresupuesto.Text = presuNu.ToString();
                                cone.ActualizarPresupuesto(presuNu, idPar);
                                }
                                else
                                {
                                    MessageBox.Show("No tienes suficiente presupuesto para abrir una oficina nueva! Vas un poquito deprisa no??? Frenaaa!");
                                }
                            }
                        }
                        if (lvlOf4 == 4)
                        {
                            MessageBox.Show("No hay más oficinas disponibles en la ciudad, para un poquito no???");
                        }
                    }
                }
            }

        }

        
    }


    }
