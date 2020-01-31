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

namespace CuadernosDigitales.Forms
{
    public partial class LoginRegistrarse : Form
    {
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
        public Boolean NombreUsuario
        {
            get;
            set;
        }
        public Boolean ContraseñaUsuario
        {
            get;
            set;
        }
        public Boolean RepetirContraseñaUsuario
        {
            get;
            set;
        }
        public LoginRegistrarse()
        {
            InitializeComponent();
            administrador = new AdministradorArchivos();
            Usuarios = new List<Usuario>();
            Usuario = new Usuario();

            NombreUsuario = false;
            ContraseñaUsuario = false;
            RepetirContraseñaUsuario = false;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void CloseAppButton_Click(object sender, EventArgs e)
        {
            this.Close();  
        }


        private void CabezaPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112,0xf012,0);
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonRegistrar_Click(object sender, EventArgs e)
        {
            if(NombreUsuario && ContraseñaUsuario && RepetirContraseñaUsuario && NombreUsuarioCorrecto())
            {
            //    Usuarios.Add(Usuario);
            //    administrador.GuardarUsuario(Usuario);
                Usuario.AgregarUsuarioALaBaseDeDatos(Usuario);
                Usuarios = Usuario.CargarUsuariosDeLaBaseDeDatos();

                MessageBox.Show("Se registro el nuevo usuario exitosamente");
                this.Close();
            }
            else
            {
                MessageBox.Show("Ingrese los datos correctamente");
            }
        }

        private void TextBoxUsuario_Leave(object sender, EventArgs e)
        {
            Boolean sinErrores = true;
            if (TextBoxUsuario.TextLength < 3 || TextBoxUsuario.TextLength > 45)
            {
                errorProviderLogin.SetError(TextBoxUsuario, "Ingrese el nombre del usuario o uno con el largo correcto");
                NombreUsuario = false;
            }
            else
            {
                for (int i = 0; i < Usuarios.Count; i++)
                {
                    if(Usuarios[i].Nombre == TextBoxUsuario.Text)
                    {
                        errorProviderLogin.SetError(TextBoxUsuario, "El nombre de usuario ya existe, escoja otro");
                        NombreUsuario = false;
                        sinErrores = false;
                    }
                }
                if (sinErrores)
                {
                    Usuario.Nombre = TextBoxUsuario.Text;
                    NombreUsuario = true;
                }
            }
        }

        private void TextBoxContraseña_Leave(object sender, EventArgs e)
        {
            if (TextBoxContraseña.TextLength < 3 || TextBoxContraseña.TextLength > 45)
            {
                errorProviderContraseña.SetError(TextBoxContraseña, "Ingrese la nueva contraseña del Usuario o una con el largo correcto");
                ContraseñaUsuario = false;
            }
            else
            {
                Usuario.Contraseña = TextBoxContraseña.Text;
                ContraseñaUsuario = true;
            }
        }

        private void TextBoxRepetirContraseña_Leave(object sender, EventArgs e)
        {
            if (TextBoxRepetirContraseña.TextLength < 3 || TextBoxRepetirContraseña.TextLength > 45)
            {
                errorProviderRepetirContraseña.SetError(TextBoxRepetirContraseña, "Repita la nueva contraseña del Usuario");
                RepetirContraseñaUsuario = false;
            }
            else
            {
                if(Usuario.Contraseña == TextBoxRepetirContraseña.Text)
                {
                    Usuario.Identificador = Usuarios.Count + 1;
                    RepetirContraseñaUsuario = true;
                }
                else
                {
                    errorProviderRepetirContraseña.SetError(TextBoxRepetirContraseña, "La nueva contraseña del Usuario es diferente al repetirla");
                    RepetirContraseñaUsuario = false;
                }
            }
        }
        private bool NombreUsuarioCorrecto()
        {
            if (TextBoxNombreRealUsuario.TextLength < 3 || TextBoxNombreRealUsuario.TextLength > 45)
            {
                ErrorProviderNombreRealUsuario.SetError(TextBoxNombreRealUsuario, "No ha ingresado nungun nombre real valido o uno con el largo correcto");
                return false;
            }
            else
            {
                Usuario.NombreReal = TextBoxNombreRealUsuario.Text;
                return true;
            }
        }
    }
}
