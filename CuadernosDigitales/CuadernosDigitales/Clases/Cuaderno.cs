using CuadernosDigitales.Clases;
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
    public class Cuaderno
    {
        MyDBSQL myDBSQL;

        private List<Nota> notas;
        private List<Categoria> categorias;

        public Cuaderno()
        {
            notas = new List<Nota>();
            categorias = new List<Categoria>();

            myDBSQL = new MyDBSQL();
            myDBSQL.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DBActual"].ConnectionString;
        }
        public List<Categoria> Categorias
        {
            get;
            set;
        }

        public string Nombre
        {
            get;
            set;
        }

        public Color Color
        {
            get;
            set;
        }

        public int Orden
        {
            get;
            set;
        }
        public int IndiceCuaderno
        {
            get;
            set;
        }
        public Bitmap Imagen
        {
            get;
            set;
        }
        public void agregarCategoria(Categoria cat)
        {
            categorias.Add(cat);
        }

        public void agregarNota(Nota not)
        {
            notas.Add(not);
        }

        public List<Categoria> getListaDeCategorias()
        {
            return categorias;
        }
        public List<Nota> getListaDeNotas()
        {
            return notas;
        }

        public int BuscarNota(string name)
        {
            foreach(Nota nota in notas)
            {
                if(nota.Titulo == name)
                {
                    return notas.IndexOf(nota);
                }
            }

            return -1;
        }
        public Nota BuscarNota(string name, bool sinNumero)
        {
            foreach (Nota nota in notas)
            {
                if (nota.Titulo == name)
                {
                    return nota;
                }
            }

            return null;
        }
        public void EliminarNota(Nota nota)
        {
            notas.Remove(nota);
        }

        public void ModificarNota(int num, Nota nota)
        {
            notas[num] = nota;
        }
        public string ObtenerNombre(int num)
        {
            return notas[num].Titulo;
        }

        public List<Nota> getNotasOcultas()
        {
            List<Nota> notasOcultas = new List<Nota>();
            foreach (Nota nota in notas)
            {
                if (nota.Privacidad)
                {
                    notasOcultas.Add(nota);
                }
                
            }
            return notasOcultas;
        }
        public int ObtenerIndiceDeLaNotaEnBaseDeDatos(int posicionNota)
        {
            int indiceDeLaNotaEnBaseDeDatos = -1;

            foreach (Nota nota in notas)
            {
                if (nota.Orden == posicionNota)
                {
                    indiceDeLaNotaEnBaseDeDatos = nota.IndiceNota;
                }
            }

            return indiceDeLaNotaEnBaseDeDatos;
        }
        public List<Cuaderno> CargarCuadernosDeLaBaseDeDatos()
        {
            List<Cuaderno> cuadernos = new List<Cuaderno>();

            myDBSQL.OpenConnection();
            try
            {
                myDBSQL.BeginTransaction();
                DataTable dataTable = myDBSQL.QuerySQL(string.Format("Select * from cuadernos where `usuarios_idusuarios` = '{0}'",
                CuadernosInicio.UsuariosEstaticos[CuadernosInicio.IndiceUsuarioEstatico].Identificador));

                foreach (DataRow dr in dataTable.Rows)
                {
                    Cuaderno cuaderno = new Cuaderno();
                    cuaderno.IndiceCuaderno = Convert.ToInt32(dr["idcuadernos"]);
                    cuaderno.Nombre = dr["nombre"].ToString();
                    cuaderno.Color = Color.FromName(dr["color"].ToString());
                    cuaderno.Orden = Convert.ToInt32(dr["orden"].ToString());

                    Cuadernos_Y_Categorias cuadernos_Y_Categorias = new Cuadernos_Y_Categorias();
                    cuaderno.Categorias = cuadernos_Y_Categorias.CargarCategoriasDeCuadernosDeLaBaseDeDatos(cuaderno.IndiceCuaderno);
                    cuadernos.Add(cuaderno);

                    Console.WriteLine(cuaderno.Categorias);
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

                Cuadernos_Y_Categorias cuadernos_Y_Categorias = new Cuadernos_Y_Categorias();
                cuadernos_Y_Categorias.EliminarRelacionDeCategoriasYCuadernoDeLaBaseDeDatos(cuaderno.IndiceCuaderno);

                myDBSQL.EjectSQL(string.Format("delete from cuadernos where `idcuadernos` = '{0}'",
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