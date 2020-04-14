using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoRPG
{
    class ClsConexion
    {
        SqlConnection cone;
        SqlCommand cmd;
        SqlDataReader dr;

        public ClsConexion()
        {
            try
            {
                cone = new SqlConnection("Data Source=sql5045.site4now.net;Initial Catalog=DB_A550AF_soniap;User ID=DB_A550AF_soniap_admin;Password=Xloki32234x");
                cone.Open();
                
            }
            catch (Exception e)
            {
                MessageBox.Show("No se puede conectar: " + e.ToString());
            }

        }

        public string InsertarJugador(string pnom, string ppass, string ppreg,string pmail,string pciu,int pedad )
        {
            string salida = "Se ha insertado correctamente";
            try
            {
                cmd = new SqlCommand("insert into Usuarios(Usuario,Pass,Pregunta,Mail,Ciudad,Edad)values('"+pnom+"','"+ppass+"','"+ppreg+"','"+pmail+"','"+pciu+"',"+pedad+")", cone);
                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                salida = "no se insertó" + e.ToString();
            }

            return salida;

        }
        public int ObtenerIdJugador(string pusu)
        {
            int salida =1;
            try
            {
                int id=0;
            cmd = new SqlCommand("select IdUsu from Usuarios where Usuario=" + "'" + pusu + "'", cone);
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                id = Convert.ToInt32(dr.GetValue(0));

            }
            MessageBox.Show(id.ToString());
                dr.Close();
                return id;
            }
            catch (Exception e)
            {
                MessageBox.Show("No se puede conectar: " + e.ToString());
            }
            return salida;
        }
        public void InsertarPartida(int pidUsu,int plevl,int ptrab,double ppres,int pfel,int plvlOf1, int plvlOf2, int plvlOf3, int plvlOf4,int pproyec,int ptraLib)
        {
            try
            {
                cmd = new SqlCommand("insert into Partidas(IdUsu,Lvl,Trabajadores,Presupuesto,felicidad,LvlOficina1,LvlOficina2,LvlOficina3,LvlOficina4, Proyectos, TrabajadoresLibres)values("+pidUsu +","+ plevl +", "+ ptrab + "," + ppres + "," + pfel + "," + plvlOf1 + "," + plvlOf2+ ", " + plvlOf3 + ", " + plvlOf4 + ", " + pproyec + ", " + ptraLib +")", cone);
                cmd.ExecuteNonQuery();
               

            }
            catch (Exception e)
            {
                MessageBox.Show( "no se insertó la partida" + e.ToString());
            }
        }
        public string ObtenerPass(string pmail)
        {
            string salida = "encontrada pass:";
            string error = "mal";
            try
            {
                
                cmd = new SqlCommand("select Pass from Usuarios where Mail=" + "'" + pmail + "'", cone);
                cmd.ExecuteNonQuery();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    salida = dr.GetValue(0).ToString();

                }
                
                dr.Close();
                return salida;
            }
            catch (Exception e)
            {
                return error;
            }
        }
        public string ObtenerRespuestaSecre(string pmail)
        {
            string salida = "encontrada mail:";
            string error = "mal";
            try
            {

                cmd = new SqlCommand("select Pregunta from Usuarios where Mail=" + "'" + pmail + "'", cone);
                cmd.ExecuteNonQuery();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    salida = dr.GetValue(0).ToString();

                }

                dr.Close();
                return salida;
            }
            catch (Exception e)
            {
                return error;
            }
        }
        public int ObtenerIdPartida(int pidju)
        {
            int par = 0;
            cmd = new SqlCommand("select IdPartida from Partidas where IdUsu=" + pidju, cone);
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                par = Convert.ToInt32(dr.GetValue(0));
                
            }
            dr.Close();
            return par;
        }
        public double ObtenerPresupuesto(int pidPar)
        {
            double presu = 0;
            cmd = new SqlCommand("select Presupuesto from Partidas where IdPartida=" + pidPar, cone);
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                presu = Convert.ToInt32(dr.GetValue(0));
               
            }
            dr.Close();
            return presu;
        }
        public int ObtenerMotivacion(int pidPar)
        {
            int feli = 0;
            cmd = new SqlCommand("select Felicidad from Partidas where IdPartida=" + pidPar, cone);
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                feli = Convert.ToInt32(dr.GetValue(0));
                
            }
            dr.Close();
            return feli;
        }
        public int ObtenerTrabajadores(int pidPar)
        {
            int traba = 0;
            cmd = new SqlCommand("select Trabajadores from Partidas where IdPartida=" + pidPar, cone);
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                traba = Convert.ToInt32(dr.GetValue(0));
                
            }
            dr.Close();
            return traba;
        }
        public int ObtenerLvlPartida(int pidPar)
        {
            int lvl = 0;
            cmd = new SqlCommand("select Lvl from Partidas where IdPartida=" + pidPar, cone);
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lvl = Convert.ToInt32(dr.GetValue(0));
               
            }
            dr.Close();
            return lvl;
        }
        public int ObtenerLvlOfi1(int pidPar)
        {
            int lvlOf1 = 0;
            cmd = new SqlCommand("select LvlOficina1 from Partidas where IdPartida=" + pidPar, cone);
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lvlOf1 = Convert.ToInt32(dr.GetValue(0));
                
            }
            dr.Close();
            return lvlOf1;
        }
        public int ObtenerLvlOfi2(int pidPar)
        {
            int lvlOf2 = 0;
            cmd = new SqlCommand("select LvlOficina2 from Partidas where IdPartida=" + pidPar, cone);
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lvlOf2 = Convert.ToInt32(dr.GetValue(0));
                
            }
            dr.Close();
            return lvlOf2;
        }
        public int ObtenerLvlOfi3(int pidPar)
        {
            int lvlOf3 = 0;
            cmd = new SqlCommand("select LvlOficina3 from Partidas where IdPartida=" + pidPar, cone);
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lvlOf3 = Convert.ToInt32(dr.GetValue(0));
                
            }
            dr.Close();
            return lvlOf3;
        }
        public int ObtenerLvlOfi4(int pidPar)
        {
            int lvlOf4 = 0;
            cmd = new SqlCommand("select LvlOficina4 from Partidas where IdPartida=" + pidPar, cone);
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lvlOf4 = Convert.ToInt32(dr.GetValue(0));
                
            }
            dr.Close();
            return lvlOf4;
        }
        public int ObtenerProyectos(int pidPar)
        {
            int proyec = 0;
            cmd = new SqlCommand("select Proyectos from Partidas where IdPartida=" + pidPar, cone);
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                proyec = Convert.ToInt32(dr.GetValue(0));

            }
            dr.Close();
            return proyec;
        }
        public int ObtenerTraLibres(int pidPar)
        {
            int lib = 0;
            cmd = new SqlCommand("select TrabajadoresLibres from Partidas where IdPartida=" + pidPar, cone);
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lib = Convert.ToInt32(dr.GetValue(0));

            }
            dr.Close();
            return lib;
        }
        public void ActualizarPresupuesto(double ppresu, int pidpar)
        {
            
            try
            {
                cmd = new SqlCommand("update Partidas set Presupuesto=" + ppresu + " where IdPartida= " + pidpar, cone);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
               MessageBox.Show( "no se actualzo el presu" + e.ToString());
            }

            
        }
        public void ActualizarMotivaciono(int pmotiv, int pidpar)
        {
           
            try
            {
                cmd = new SqlCommand("update Partidas set Felicidad=" + pmotiv + " where IdPartida= " + pidpar, cone);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("no se actualizado la moti" + e.ToString());
            }


        }
        public void ActualizaLvl(int plvl, int pidpar)
        {
            
            try
            {
                cmd = new SqlCommand("update Partidas set Lvl=" + plvl + " where IdPartida= " + pidpar, cone);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("no se actualizado la moti" + e.ToString());
            }


        }
        public void ActualizaLvlOf1(int plvlof1, int pidpar)
        {
           
            try
            {
                cmd = new SqlCommand("update Partidas set LvlOficina1=" + plvlof1 + " where IdPartida= " + pidpar, cone);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("no se actualizado la moti" + e.ToString());
            }


        }
        public void ActualizaLvlOf2(int plvlof2, int pidpar)
        {
          
            try
            {
                cmd = new SqlCommand("update Partidas set LvlOficina2=" + plvlof2 + " where IdPartida= " + pidpar, cone);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("no se actualizado la moti" + e.ToString());
            }


        }
        public void ActualizaLvlOf3(int plvlof3, int pidpar)
        {
           
            try
            {
                cmd = new SqlCommand("update Partidas set LvlOficina3=" + plvlof3 + " where IdPartida= " + pidpar, cone);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("no se actualizado la moti" + e.ToString());
            }


        }
        public void ActualizaLvlOf4(int plvlof4, int pidpar)
        {
           
            try
            {
                cmd = new SqlCommand("update Partidas set LvlOficina4=" + plvlof4 + " where IdPartida= " + pidpar, cone);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("no se actualizado la moti" + e.ToString());
            }


        }
        public void ActualizarProyectos(int pproyec, int pidpar)
        {
            
            try
            {
                cmd = new SqlCommand("update Partidas set Proyectos=" + pproyec + " where IdPartida= " + pidpar, cone);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("no se actualizado la moti" + e.ToString());
            }


        }
        public void ActualizarTrLibres(int ptrLi, int pidpar)
        {
         
            try
            {
                cmd = new SqlCommand("update Partidas set TrabajadoresLibres=" + ptrLi + " where IdPartida= " + pidpar, cone);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("no se actualizado LOS TR LIBRES" + e.ToString());
            }


        }

    } 
}
