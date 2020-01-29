using DBConnection.Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CuadernosDigitales
{
    public class Usuario
    {
        MyDBSQL myDBSQL;
        public Usuario()
        {
            cuadernos = new List<Cuaderno>();
            myDBSQL = new MyDBSQL();
            myDBSQL.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DBActual"].ConnectionString;
        }

        public string Nombre
        {
            get;
            set;
        }
        public string NombreReal
        {
            get;
            set;
        }

        public string Contraseña
        {
            get;
            set;
        }

        public int Identificador
        {
            get;
            set;
        }
        public List<Cuaderno> cuadernos
        {
            get;
            set;
        }
        public void AgregarCuaderno(Cuaderno cuaderno)
        {
            cuadernos.Add(cuaderno);
        }
        public List<Usuario> CargarUsuariosDeLaBaseDeDatos()
        {
            List<Usuario> usuarios = new List<Usuario>();

            myDBSQL.OpenConnection();
            try
            {
                myDBSQL.BeginTransaction();
                DataTable dataTable = myDBSQL.QuerySQL("Select * from usuarios");

                foreach (DataRow dr in dataTable.Rows)
                {
                    Usuario usuario = new Usuario();
                    usuario.Identificador = Convert.ToInt32(dr["idusuarios"].ToString());
                    usuario.Nombre = dr["nombre_usuario"].ToString();
                    usuario.NombreReal = dr["nombre_real"].ToString();
                    usuario.Contraseña = dr["contrasenna"].ToString();
                    usuarios.Add(usuario);
                    Console.WriteLine(usuario.Identificador);
                    Console.WriteLine(usuario.Nombre);
                    Console.WriteLine(usuario.NombreReal);
                    Console.WriteLine(usuario.Contraseña);
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
            return usuarios;
        }
        public void AgregarUsuarioALaBaseDeDatos(Usuario usuario)
        {

            myDBSQL.OpenConnection();
            try
            {
                myDBSQL.BeginTransaction();
                myDBSQL.EjectSQL(string.Format("insert into usuarios (`nombre_usuario`, `nombre_real`, `contrasenna`) values ('{0}', '{1}', '{2}')",
                usuario.Nombre, usuario.NombreReal, usuario.Contraseña));
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
        public void EditarContrasennaDeUsuarioEnLaBaseDeDatos(Usuario usuario)
        {

            myDBSQL.OpenConnection();
            try
            {
                myDBSQL.BeginTransaction();
                myDBSQL.EjectSQL(string.Format("Update usuarios Set `contrasenna` = '{0}' where `idusuarios` = '{1}'",
                usuario.Contraseña,usuario.Identificador));
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
    }
}