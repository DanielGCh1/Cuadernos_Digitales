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
    public class Categoria
    {
        MyDBSQL myDBSQL;
        public string Nombre
        {
            get;
            set;
        }
        public Categoria()
        {
            myDBSQL = new MyDBSQL();
            myDBSQL.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DBActual"].ConnectionString;
        }

        public int IndiceCategoria
        {
            get;
            set;
        }

        public Categoria CargarCategoriaDeLaBaseDeDatos(string nombre)
        {
            Categoria categoria = new Categoria();
            myDBSQL.OpenConnection();
            try
            {
                myDBSQL.BeginTransaction();
                DataTable dataTable = myDBSQL.QuerySQL(string.Format("Select * from categorias where `nombre_categoria` = '{0}'",
                nombre));

                foreach (DataRow dr in dataTable.Rows)
                {
                    categoria.IndiceCategoria = Convert.ToInt32(dr["idcategorias"]);
                    categoria.Nombre = dr["nombre_categoria"].ToString();
                }
                myDBSQL.CommitTransaction();
            }
            catch (Exception e)
            {
                MessageBox.Show($"Se produjo el siguiente error con nombre: {e}");
            }
            finally
            {
                myDBSQL.CloseConnection();
            }
            return categoria;
        }
        public Categoria CargarCategoriaDeLaBaseDeDatos(int indiceCategoria)
        {
            Categoria categoria = new Categoria();
            myDBSQL.OpenConnection();
            try
            {
                myDBSQL.BeginTransaction();
                DataTable dataTable = myDBSQL.QuerySQL(string.Format("Select * from categorias where `idcategorias` = '{0}'",
                indiceCategoria));

                foreach (DataRow dr in dataTable.Rows)
                {
                    categoria.IndiceCategoria = Convert.ToInt32(dr["idcategorias"]);
                    categoria.Nombre = dr["nombre_categoria"].ToString();
                }
                myDBSQL.CommitTransaction();
            }
            catch (Exception e)
            {
                MessageBox.Show($"Se produjo el siguiente error con nombre: {e}");
            }
            finally
            {
                myDBSQL.CloseConnection();
            }
            return categoria;
        }
        public void AgregarCategoriaALaBaseDeDatos(Categoria categoria)
        {
            if (!CategoriaExiste(categoria))
            {
                myDBSQL.OpenConnection();
                try
                {
                    myDBSQL.BeginTransaction();
                    myDBSQL.EjectSQL(string.Format("insert into categorias (`nombre_categoria`) values ('{0}')",
                    categoria.Nombre));
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
        public void EliminarCategoriaDeLaBaseDeDatos(Categoria categoria)
        {

            myDBSQL.OpenConnection();
            try
            {
                myDBSQL.BeginTransaction();
                myDBSQL.EjectSQL(string.Format("delete from categorias where `idcategorias` = '{0}'",
                categoria.IndiceCategoria));
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
        public bool CategoriaExiste(Categoria categoria)
        {
            if (CargarCategoriaDeLaBaseDeDatos(categoria.Nombre).Nombre == categoria.Nombre)
            {
                Console.WriteLine("Categoria si existe");
                return true;
            }
            else
            {
                Console.WriteLine("Categoria no existe");
                return false;
            }
        }
    }
}