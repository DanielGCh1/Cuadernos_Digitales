using DBConnection.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CuadernosDigitales
{
    public class Historial
    {
        MyDBSQL myDBSQL;
        public Historial()
        {

        }

        public Historial(String usuario, String accion, String informacionAdicional, string objeto)
        {
            myDBSQL = new MyDBSQL();
            myDBSQL.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DBActual"].ConnectionString;

            FechaYHora = DateTime.Now;
            Usuario = usuario;
            Accion = accion;
            InformacionAdicional = informacionAdicional;
            Objeto = objeto;
            IndiceUsuario = CuadernosInicio.IndiceUsuarioEstatico + 1;
        }
        public DateTime FechaYHora
        {
            get;
            set;
        }

        public string Usuario
        {
            get;
            set;
        }

        public string Accion
        {
            get;
            set;
        }

        public string Objeto
        {
            get;
            set;
        }

        public string InformacionAdicional
        {
            get;
            set;
        }
        public int IndiceUsuario
        {
            get;
            set;
        }
        public void AgregarHistorialALaBaseDeDatos(Historial historial)
        {
            myDBSQL.OpenConnection();
            try
            {
                myDBSQL.BeginTransaction();
                if (ObjetoNoVacido(historial))
                {
                    myDBSQL.EjectSQL(string.Format("insert into historiales (`usuarios_idusuarios`, `fecha_y_hora`, `usuario`, `accion`, `informacion_adicional`, `objeto`) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')",
                    historial.IndiceUsuario, Convert.ToString(historial.FechaYHora), historial.Usuario, historial.Accion, historial.InformacionAdicional, historial.Objeto));
                }
                else
                {
                    myDBSQL.EjectSQL(string.Format("insert into historiales (`usuarios_idusuarios`, `fecha_y_hora`, `usuario`, `accion`, `informacion_adicional`, `objeto`) values ('{0}', '{1}', '{2}', '{3}', '{4}')",
                    historial.IndiceUsuario , Convert.ToString(historial.FechaYHora), historial.Usuario, historial.Accion, historial.InformacionAdicional));
                }
                myDBSQL.CommitTransaction();
            }
            catch (Exception e)
            {
                myDBSQL.RollBackTransaction();
                MessageBox.Show($"se produjo el siguiente error: {e}");
            }
            finally
            {
                myDBSQL.CloseConnection();
            }
        }
        private bool ObjetoNoVacido(Historial historial)
        {
            if(historial.Objeto != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}