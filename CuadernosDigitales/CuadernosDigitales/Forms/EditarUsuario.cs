using CuadernosDigitales.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuadernosDigitales.Forms
{
    public partial class EditarUsuario : Form
    {
        private readonly string rutaPorDefecto = AppDomain.CurrentDomain.BaseDirectory;

        private readonly string rutaUsuarios = AppDomain.CurrentDomain.BaseDirectory;

        private AdministradorArchivos administradorUsuarios;
        public Usuario Usuario
        {
            get;
            set;
        }
        public Boolean ContraseñaActualUsuario
        {
            get;
            set;
        }
        public Boolean NuevaContraseñaUsuario
        {
            get;
            set;
        }
        public Boolean RepetirNuevaContraseñaUsuario
        {
            get;
            set;
        }
        public EditarUsuario()
        {
            InitializeComponent();
            administradorUsuarios = new AdministradorArchivos();


            ContraseñaActualUsuario = false;
            NuevaContraseñaUsuario = false;
            RepetirNuevaContraseñaUsuario = false;

            Usuario = new Usuario();

            List<PictureBox> picturesBooks = new List<PictureBox>();
        }

        private void MostrarFormEnPanel(Object form)
        {
            if (this.Controls.Count > 0)
            {
                this.Controls.RemoveAt(0);
            }

            Form formPanel = form as Form;
            formPanel.TopLevel =  false;
            formPanel.Dock = DockStyle.Fill;
            this.Controls.Add(formPanel);
            this.Tag = formPanel;
            formPanel.Show();
        }

        private void TextBoxContraseña_Leave(object sender, EventArgs e)
        {
            if (TextBoxContraseña.TextLength < 3)
            {
                ErrorProviderContraseña.SetError(TextBoxContraseña, "Ingrese la contraseña actual del Usuario");
            }
            else
            {
                if (CuadernosInicio.UsuariosEstaticos[CuadernosInicio.IndiceUsuarioEstatico].Contraseña == TextBoxContraseña.Text)
                {
                    ContraseñaActualUsuario = true;
                }
                else
                {
                    ErrorProviderContraseña.SetError(TextBoxContraseña, "La contraseña del Usuario esta incorrecta");
                    ContraseñaActualUsuario = false;
                }
            }
        }

        private void TextBoxNuevaContraseña_Leave(object sender, EventArgs e)
        {
            if (TextBoxNuevaContraseña.TextLength < 3)
            {
                ErrorProviderNuevaContraseña.SetError(TextBoxNuevaContraseña, "Ingrese la nueva contraseña del Usuario");
                NuevaContraseñaUsuario = false;
            }
            else
            {
                Usuario.Contraseña = TextBoxNuevaContraseña.Text;
                NuevaContraseñaUsuario = true;

                if (Usuario.Contraseña == TextBoxRepetirNuevaContraseña.Text)
                {
                    RepetirNuevaContraseñaUsuario = true;
                }
                else
                {
                    RepetirNuevaContraseñaUsuario = false;
                }
            }
        }

        private void TextBoxRepetirNuevaContraseña_Leave(object sender, EventArgs e)
        {
            if (TextBoxRepetirNuevaContraseña.TextLength < 3)
            {
                ErrorProviderRepetirNuevaContraseña.SetError(TextBoxRepetirNuevaContraseña, "Repita la nueva contraseña del Usuario");
                RepetirNuevaContraseñaUsuario = false;
            }
            else
            {
                if (Usuario.Contraseña == TextBoxRepetirNuevaContraseña.Text)
                {
                    RepetirNuevaContraseñaUsuario = true;
                }
                else
                {
                    ErrorProviderRepetirNuevaContraseña.SetError(TextBoxRepetirNuevaContraseña, "La nueva contraseña del Usuario es diferente al repetirla");
                    RepetirNuevaContraseñaUsuario = false;
                }
            }
        }

        private void ButtonEditarContraseña_Click(object sender, EventArgs e)
        {
            if (ContraseñaActualUsuario && NuevaContraseñaUsuario && RepetirNuevaContraseñaUsuario)
            {
                CuadernosInicio.UsuariosEstaticos[CuadernosInicio.IndiceUsuarioEstatico].Contraseña = Usuario.Contraseña;

                Historial historial = new Historial(CuadernosInicio.UsuariosEstaticos[CuadernosInicio.IndiceUsuarioEstatico].Nombre, "Edición de usuario", $"El usuario {CuadernosInicio.UsuariosEstaticos[CuadernosInicio.IndiceUsuarioEstatico].Nombre} edito su contraseña", Convert.ToString(CuadernosInicio.UsuariosEstaticos[CuadernosInicio.IndiceUsuarioEstatico].Identificador));
                historial.AgregarHistorialALaBaseDeDatos(historial);

                //ArchivoHistorial archivoManager = new ArchivoHistorial();
                //CargarInformacionActividadUsuario(archivoManager, "Edición de usuario", $"El usuario {CuadernosInicio.UsuariosEstaticos[CuadernosInicio.IndiceUsuarioEstatico].Nombre} edito su contraseña", "Editar Usuario", CuadernosInicio.IndiceUsuarioEstatico);
                //CrearHistorialEdicionUsuario(archivoManager);

                DialogResult dialogResult = MessageBox.Show("Se edito la contraseña correctamente");
                LimpiarTextBoxYErroProvider();
                Usuario.EditarContrasennaDeUsuarioEnLaBaseDeDatos(CuadernosInicio.UsuariosEstaticos[CuadernosInicio.IndiceUsuarioEstatico]);
                administradorUsuarios.EditarUsuarios(CuadernosInicio.UsuariosEstaticos, rutaUsuarios);
            }
            else{
                DialogResult dialogResult = MessageBox.Show("Datos incorrectos");
            }
        }
        //private void CargarInformacionActividadUsuario(ArchivoHistorial archivoManager, String accion, String informacionAdicional, string formulario, int objeto)
        //{
        //    archivoManager.Historial = new Historial(DateTime.Now, CuadernosInicio.UsuariosEstaticos[CuadernosInicio.IndiceUsuarioEstatico].Nombre, accion, informacionAdicional, formulario, objeto);
        //}
        private void CrearHistorialVisitaFormulario(ArchivoHistorial archivoManager)
        {
            try
            {
                string nombreNuevoArchivo = archivoManager.CrearHistorialVisitaFormulario(rutaPorDefecto);
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Se produjo el siguiente error: {exception}");
            }
        }
        private void CrearHistorialEdicionUsuario(ArchivoHistorial archivoManager)
        {
            try
            {
                string nombreNuevoArchivo = archivoManager.CrearHistorialEdicionObjeto(rutaPorDefecto);
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Se produjo el siguiente error: {exception}");
            }
        }
        private void EditarUsuario_Load(object sender, EventArgs e)
        {

        }
        private void LimpiarTextBoxYErroProvider()
        {
            TextBoxContraseña.Text = "";
            TextBoxNuevaContraseña.Text = "";
            TextBoxRepetirNuevaContraseña.Text = "";

            ErrorProviderContraseña.SetError(TextBoxContraseña, "");
            ErrorProviderNuevaContraseña.SetError(TextBoxNuevaContraseña, "");
            ErrorProviderRepetirNuevaContraseña.SetError(TextBoxRepetirNuevaContraseña, "");
        }
    }
}
