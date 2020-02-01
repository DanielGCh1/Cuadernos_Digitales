using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CuadernosDigitales.Forms;
using CuadernosDigitales.Clases;
using DBConnection.Connection;

namespace CuadernosDigitales.Forms
{
    public partial class LoginForm : Form
    {
        MyDBSQL myDBSQL;

        private readonly string rutaPorDefecto = AppDomain.CurrentDomain.BaseDirectory;
        private AdministradorArchivos administrador;
        public List<Usuario> Usuarios
        {
            get;
            set;
        }
        public Usuario Usuario
        {
            get;
            set;
        }
        public int IndiceUsuario
        {
            get;
            set;
        }

        public LoginForm()
        {
            InitializeComponent();
            administrador = new AdministradorArchivos();
            Usuarios = new List<Usuario>();
            Usuario = new Usuario();

            myDBSQL = new MyDBSQL();
            myDBSQL.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DBActual"].ConnectionString;
        }
        public LoginForm(Form form)
        {
            InitializeComponent();
            Usuarios = new List<Usuario>();
            Usuario = new Usuario();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void CloseAppButton_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea cerrar la aplicación?", "Confirmacion", MessageBoxButtons.YesNoCancel);
            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
           
        }


        private void CabezaPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112,0xf012,0);
        }

        private void ButtonIngresar_Click(object sender, EventArgs e)
        {
            Boolean sinErrorNombreUsuario = false;
            Boolean sinErrorContraseñaUsuario = false;
            for (int i = 0; i < Usuarios.Count; i++)
            {
                if (Usuarios[i].Nombre == Usuario.Nombre)
                {
                    sinErrorNombreUsuario = true;

                    if (Usuarios[i].Contraseña == Usuario.Contraseña)
                    {
                        sinErrorContraseñaUsuario = true;
                        IndiceUsuario = i;
                    }
                }
            }
            if (sinErrorNombreUsuario)
            {
                if (sinErrorContraseñaUsuario)
                {
                    DialogResult = DialogResult.OK;
                    this.Hide();
                }
                else
                {
                    errorProviderContraseña.SetError(TextBoxContraseña, "La contraseña del usuario esta incorrecta");
                }
            }
            else
            {
                errorProviderLogin.SetError(TextBoxUsuario, "No existe ningun usuario con ese nombre");
            }
        }

        private void LinkLabelRegistrarce_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginRegistrarse loginRegistrarse = new LoginRegistrarse();
            loginRegistrarse.Usuarios = Usuarios;
            loginRegistrarse.ShowDialog();
            Usuarios = loginRegistrarse.Usuarios;
        }

        private void TextBoxUsuario_Leave(object sender, EventArgs e)
        {
            if (TextBoxUsuario.TextLength < 3)
            {
                errorProviderLogin.SetError(TextBoxUsuario, "Ingrese el nombre del usuario");
            }
            else
            {
                Usuario.Nombre = TextBoxUsuario.Text;
            }
        }

        private void TextBoxContraseña_Leave(object sender, EventArgs e)
        {
            if (TextBoxContraseña.TextLength < 3)
            {
                errorProviderLogin.SetError(TextBoxUsuario, "Ingrese la contraseña del usuario");
            }
            else
            {
                Usuario.Contraseña = TextBoxContraseña.Text;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        /*    try
            {
                if (administrador.getUsuariosRegistrados().Count > 0)
                {
                    Usuarios = administrador.getUsuariosRegistrados();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Se produjo el siguiente error: {ex}");
            }*/
            CargarUsuariosDeLaBaseDeDatos();
        }

        private void CargarUsuariosDeLaBaseDeDatos()
        {
            try
            {
                if (Usuario.CargarUsuariosDeLaBaseDeDatos().Count > 0)
                {
                    Usuarios = Usuario.CargarUsuariosDeLaBaseDeDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se produjo el siguiente error: {ex}");
            }

        }

    }
}
