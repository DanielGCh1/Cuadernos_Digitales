using DBConnection.Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuadernosDigitales.Clases
{

    class Cuadernos_Y_Categorias
    {
        MyDBSQL myDBSQL;

        public Cuadernos_Y_Categorias()
        {
            myDBSQL = new MyDBSQL();
            myDBSQL.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DBActual"].ConnectionString;
        }
        public int IndiceCuaderno
        {
            get;
            set;
        }
        public int IndiceCategoria
        {
            get;
            set;
        }
        public List<Categoria> CargarCategoriasDeCuadernosDeLaBaseDeDatos(int indiceCuaderno)
        {
            List<Categoria> categorias = new List<Categoria>();
            myDBSQL.OpenConnection();
            try
            {
                myDBSQL.BeginTransaction();
                DataTable dataTable = myDBSQL.QuerySQL(string.Format("Select * from cuadernos_y_categorias where `cuadernos_idcuadernos` = '{0}'",
                indiceCuaderno));

                foreach (DataRow dr in dataTable.Rows)
                {
                    Cuadernos_Y_Categorias cuadernos_Y_Categorias = new Cuadernos_Y_Categorias();
                    cuadernos_Y_Categorias.IndiceCuaderno = Convert.ToInt32(dr["cuadernos_idcuadernos"]);
                    cuadernos_Y_Categorias.IndiceCategoria = Convert.ToInt32(dr["categorias_idcategorias"]);

                    Categoria categoria = new Categoria();
                    categorias.Add(categoria.CargarCategoriaDeLaBaseDeDatos(cuadernos_Y_Categorias.IndiceCategoria));
                    _ = categorias.Count;
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
            return categorias;
        }
        public void AgregarRelacionYCategoriasDeCuadernoALaBaseDeDatos(int indiceCuaderno , List<Categoria> categorias)
        {
            List<Categoria> categoriasAgregadasABaseDeDatos = new List<Categoria>(); 

            myDBSQL.OpenConnection();
            try
            {
                for (int i = 0; i < categorias.Count; i++)
                {
                    categorias[i].AgregarCategoriaALaBaseDeDatos(categorias[i]);
                    categoriasAgregadasABaseDeDatos.Add(categorias[i].CargarCategoriaDeLaBaseDeDatos(categorias[i].Nombre));
                }
                for (int i = 0; i < categorias.Count; i++)
                {
                    myDBSQL.BeginTransaction();
                    myDBSQL.EjectSQL(string.Format("insert into cuadernos_y_categorias (`cuadernos_idcuadernos`,`categorias_idcategorias`) values ('{0}','{1}')",
                    indiceCuaderno, categoriasAgregadasABaseDeDatos[i].IndiceCategoria));
                    myDBSQL.CommitTransaction();
                }
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
        public void EliminarRelacionDeCategoriasYCuadernoDeLaBaseDeDatos(int indiceCuaderno)
        {

            myDBSQL.OpenConnection();
            try
            {
                myDBSQL.BeginTransaction();
                myDBSQL.EjectSQL(string.Format("delete from cuadernos_y_categorias where `cuadernos_idcuadernos` = '{0}'",
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
