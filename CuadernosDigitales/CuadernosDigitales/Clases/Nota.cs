using DBConnection.Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CuadernosDigitales
{
    public class Nota
    {
        MyDBSQL myDBSQL;
        public Nota()
        {
            myDBSQL = new MyDBSQL();
            myDBSQL.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DBActual"].ConnectionString;
        }
        public string Categoria
        {
            get;
            set;
        }

        public System.Drawing.Color Color
        {
            get;
            set;
        }
        public int TamanoLetra
        {
            get;
            set;
        }

        public System.Drawing.Font Fuente
        {
            get;
            set;
        }

        public /*System.Drawing.Color*/ Color ColorDeLetra
        {
            get;
            set;
        }

        public DateTime FechaDeCreacion
        {
            get;
            set;
        }

        public DateTime FechaDeModificacion
        {
            get;
            set;
        }

        public int Orden
        {
            get;
            set;
        }

        public bool Privacidad
        {
            get;
            set;
        }

        public string Titulo
        {
            get;
            set;
        
        }

        public string Contenido
        {
            get;
            set;
        }
        public int IndiceNota
        {
            get;
            set;
        }
        public List<Cuaderno> CargarCuadernosDeLaBaseDeDatos()
        {
            List<Cuaderno> cuadernos = new List<Cuaderno>();

            myDBSQL.OpenConnection();
            try
            {
                myDBSQL.BeginTransaction();
                DataTable dataTable = myDBSQL.QuerySQL(string.Format("Select * from cuadernos where usuarios_idusuarios = {0}",
                CuadernosInicio.UsuariosEstaticos[CuadernosInicio.IndiceUsuarioEstatico].Identificador));

                foreach (DataRow dr in dataTable.Rows)
                {
                    Cuaderno cuaderno = new Cuaderno();
                    cuaderno.IndiceCuaderno = Convert.ToInt32(dr["idcuadernos"]);
                    cuaderno.Nombre = dr["nombre"].ToString();
                    cuaderno.Color = Color.FromName(dr["color"].ToString());
                    cuaderno.Orden = Convert.ToInt32(dr["orden"].ToString());
                    cuadernos.Add(cuaderno);

                    Console.WriteLine(cuaderno.IndiceCuaderno);
                    Console.WriteLine(cuaderno.Nombre);
                    Console.WriteLine(cuaderno.Color.Name);
                    Console.WriteLine(cuaderno.Orden);
                }
                myDBSQL.CommitTransaction();
            }
            catch (Exception e)
            {

                MessageBox.Show($"Se produjo el siguiente error: {e}");
            }
            finally
            {
                myDBSQL.CloseConnection();
            }
            return cuadernos;
        }
        public void AgregarCuadernoALaBaseDeDatos(Cuaderno cuaderno)
        {

            myDBSQL.OpenConnection();
            try
            {
                myDBSQL.BeginTransaction();
                myDBSQL.EjectSQL(string.Format("insert into cuadernos (`usuarios_idusuarios`, `nombre`, `color`,`orden`) values ('{0}', '{1}', '{2}','{3}')",
                CuadernosInicio.UsuariosEstaticos[CuadernosInicio.IndiceUsuarioEstatico].Identificador, cuaderno.Nombre, cuaderno.Color.Name, cuaderno.IndiceCuaderno));
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
        public void EditarCuadernoEnLaBaseDeDatos(Cuaderno cuaderno)
        {

            myDBSQL.OpenConnection();
            try
            {
                myDBSQL.BeginTransaction(); // Falta poner bien el update
                myDBSQL.EjectSQL(string.Format("insert into cuadernos (`usuarios_idusuarios`, `nombre`, `color`,`orden`) values ('{0}', '{1}', '{2}','{3}')",
                CuadernosInicio.UsuariosEstaticos[CuadernosInicio.IndiceUsuarioEstatico].Identificador, cuaderno.Nombre, cuaderno.Color.Name, cuaderno.IndiceCuaderno));
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
        public void EliminarCuadernoDeLaBaseDeDatos(Cuaderno cuaderno)
        {

            myDBSQL.OpenConnection();
            try
            {
                myDBSQL.BeginTransaction();
                myDBSQL.EjectSQL(string.Format("delete from cuadernos where idcuadernos = {0}",
                cuaderno.IndiceCuaderno));
                myDBSQL.CommitTransaction();
            }
            catch (Exception e)
            {
                myDBSQL.RollBackTransaction();
                MessageBox.Show($"Se produjo el siguiente error: {e}");
            }
            finally
            {
                myDBSQL.CloseConnection();
            }
        }
    }
}