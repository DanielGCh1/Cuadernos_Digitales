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
        public List<Nota> CargarNotasDeLaBaseDeDatos(int indiceCuaderno)
        {
            List<Nota> notas = new List<Nota>();

            myDBSQL.OpenConnection();
            try
            {
                myDBSQL.BeginTransaction();
                DataTable dataTable = myDBSQL.QuerySQL(string.Format("Select * from notas where cuadernos_idcuadernos = {0}",
                indiceCuaderno));

                foreach (DataRow dr in dataTable.Rows)
                {
                    Nota nota = new Nota();
                    nota.IndiceNota = Convert.ToInt32(dr["idNotas"].ToString());
                    nota.Titulo = dr["titulo"].ToString();
                    nota.Privacidad = Convert.ToBoolean(Convert.ToInt32(dr["privacidad"].ToString()));

                    Categoria categoria = new Categoria();
                    categoria = categoria.CargarCategoriaDeLaBaseDeDatos(Convert.ToInt32(dr["categorias_idcategorias"]));

                    nota.Categoria = categoria.Nombre;
                    nota.Color = Color.FromName(dr["color"].ToString());
                    nota.ColorDeLetra = Color.FromName(dr["color_de_letra"].ToString());
                    nota.Orden = Convert.ToInt32(dr["orden"].ToString());
                    nota.FechaDeCreacion = Convert.ToDateTime(dr["fecha_de_creacion"].ToString());
                    nota.FechaDeModificacion = Convert.ToDateTime(dr["fecha_de_modificacion"].ToString());
                    nota.Contenido = dr["contenido"].ToString();

                    Font font = new Font(dr["fuente_nombre"].ToString(), Convert.ToInt32(dr["fuente_tamanno"].ToString()));

                    nota.Fuente = font;
                    notas.Add(nota);

                    Console.WriteLine(nota.IndiceNota);
                    Console.WriteLine(nota.Titulo);
                    Console.WriteLine(nota.Privacidad);
                    Console.WriteLine(nota.Categoria);
                    Console.WriteLine(nota.Color.Name);
                    Console.WriteLine(nota.ColorDeLetra.Name);
                    Console.WriteLine(nota.Orden);
                    Console.WriteLine(nota.FechaDeCreacion.ToString());
                    Console.WriteLine(nota.FechaDeModificacion.ToString());
                    Console.WriteLine(nota.Contenido);
                    Console.WriteLine(nota.Fuente.Name);
                    Console.WriteLine(nota.Fuente.Size);
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
            return notas;
        }
        public void AgregarNotaALaBaseDeDatos(int indiceCuaderno, Nota nota, int indiceCategoria)
        {

            myDBSQL.OpenConnection();
            try
            {
                myDBSQL.BeginTransaction();
                myDBSQL.EjectSQL(string.Format("insert into notas (`cuadernos_idcuadernos`, `titulo`, `privacidad`,`categorias_idcategorias`,`color`,`fuente_nombre`,`color_de_letra`,`orden`,`fecha_de_creacion`,`fecha_de_modificacion`,`contenido`,`fuente_tamanno`) values ('{0}', '{1}', '{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}')",
                indiceCuaderno, nota.Titulo, Convert.ToInt32(nota.Privacidad) , indiceCategoria, nota.Color.Name, nota.Fuente.Name, nota.ColorDeLetra.Name, nota.Orden, Convert.ToString(nota.FechaDeCreacion), Convert.ToString(nota.FechaDeModificacion), nota.Contenido, Convert.ToInt32(nota.Fuente.Size)));
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
        public void EditarNotaEnLaBaseDeDatos(Nota nota)
        {

            myDBSQL.OpenConnection();
            try
            {
                myDBSQL.BeginTransaction();
                myDBSQL.EjectSQL(string.Format("Update notas Set `titulo` = '{0}', `privacidad` = '{1}',`color` = '{2}',`fuente_nombre` = '{3}',`color_de_letra` = '{4}',`orden` = '{5}',`fecha_de_creacion` = '{6}',`fecha_de_modificacion` = '{7}',`contenido` = '{8}',`fuente_tamanno` = '{9}' where `idNotas` = '{10}'",
                nota.Titulo, Convert.ToInt32(nota.Privacidad), nota.Color.Name, nota.Fuente.Name, nota.ColorDeLetra.Name, nota.Orden, Convert.ToString(nota.FechaDeCreacion), Convert.ToString(nota.FechaDeModificacion), nota.Contenido, Convert.ToInt32(nota.Fuente.Size), nota.IndiceNota));
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
        public void EliminarNotaDeLaBaseDeDatos(Nota nota)
        {

            myDBSQL.OpenConnection();
            try
            {
                myDBSQL.BeginTransaction();
                myDBSQL.EjectSQL(string.Format("delete from notas where `idNotas` = {0}",
                nota.IndiceNota));
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
        public void EliminarNotasDeLaBaseDeDatos(int indiceCuaderno)
        {

            myDBSQL.OpenConnection();
            try
            {
                myDBSQL.BeginTransaction();
                myDBSQL.EjectSQL(string.Format("delete from notas where `cuadernos_idcuadernos` = {0}",
                indiceCuaderno));
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