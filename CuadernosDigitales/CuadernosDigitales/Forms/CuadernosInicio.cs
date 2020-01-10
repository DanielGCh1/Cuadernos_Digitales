﻿using System;
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

namespace CuadernosDigitales
{
    public partial class CuadernosInicio : Form
    {
        private readonly string rutaPorDefecto = AppDomain.CurrentDomain.BaseDirectory;
        public List<Usuario> Usuarios
        {
            get;
            set;
        }
        public int IndiceUsuario
        {
            get;
            set;
        }
        public static List<Usuario> UsuariosEstaticos
        {
            get;
            set;
        }
        public static int IndiceUsuarioEstatico
        {
            get;
            set;
        }
        public CuadernosInicio()
        {
            InitializeComponent();
            Usuarios = new List<Usuario>();
            UsuariosEstaticos = new List<Usuario>();
        }

    

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

       private void MostrarFormEnPanel(Object form)
        {
            if (this.cuerpoPanel.Controls.Count > 0)
            {
                this.cuerpoPanel.Controls.RemoveAt(0);
            }

            Form formPanel = form as Form;
            formPanel.TopLevel = false;
            formPanel.Dock = DockStyle.Fill;
            this.cuerpoPanel.Controls.Add(formPanel);
            this.cuerpoPanel.Tag = formPanel;
            formPanel.Show();
        }

        private void AbrirForm<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = cuerpoPanel.Controls.OfType<MiForm>().FirstOrDefault(); //Busca en la coleccion
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.Dock = DockStyle.Fill;
                cuerpoPanel.Controls.Add(formulario);
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }

        private void CloseAppButton_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea cerrar la aplicación?", "Confirmacion", MessageBoxButtons.YesNoCancel);
            if (resultado == DialogResult.Yes)
            {
                ArchivoManager archivoManager = new ArchivoManager();
                CargarInformacionActividadUsuario(archivoManager, "Salir del sistema", $"El usuario {Usuarios[IndiceUsuario].Nombre} salio del sistema.", "Ventana", 0);
                CrearHistorialVisitaFormulario(archivoManager);
                Application.Exit();
            }

        }

        private void ComprimirButton_Click(object sender, EventArgs e)
        {
            if (listaOpcionePanel.Width == 52)
            {
                //cuerpoPanel.Location = new Point(189, 46);
                // cuerpoPanel.Width = 660;
                userPictureBox.Visible = true;
                listaOpcionePanel.Width = 188;
                listaOpcionePanel.BorderStyle = BorderStyle.FixedSingle;

            }
            else
            {
                //cuerpoPanel.Location = new Point(61, 46);
               // cuerpoPanel.Width = 796;
                listaOpcionePanel.Width = 52;
                userPictureBox.Visible = false;
                listaOpcionePanel.BorderStyle = BorderStyle.None;
            }

        }

        private void CabezaPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112,0xf012,0);
        }

       

        private void InicioButton_Click(object sender, EventArgs e)
        {
            etiquetaInicio.Visible = true;
            etiquetaHistorial.Visible = false;
            PanelEtiquetaEditarUsuario.Visible = false;
            tituloLabel.Text = "CUADERNOS";
            //        Cuadernos cuadernos = new Cuadernos();
            //        MostrarFormEnPanel(cuadernos);
            ArchivoManager archivoManager = new ArchivoManager();
            CargarInformacionActividadUsuario(archivoManager, "Presionar el boton de Cuadernos", $"El usuario {CuadernosInicio.UsuariosEstaticos[CuadernosInicio.IndiceUsuarioEstatico].Nombre} ingreso al formulario de Cuadernos", "Cuadernos", 0);
            CrearHistorialVisitaFormulario(archivoManager);
            AbrirForm<Cuadernos>();
        }
       
        private void InicioButtonAlternative_Click(object sender, EventArgs e)
        {
            etiquetaInicio.Visible = true;
            etiquetaHistorial.Visible = false;
            PanelEtiquetaEditarUsuario.Visible = false;
            tituloLabel.Text = "INICIO";
            MostrarFormEnPanel(new Cuadernos());
        }

        private void HistorialButton_Click(object sender, EventArgs e)
        {
            etiquetaInicio.Visible = false;
            etiquetaHistorial.Visible = true;
            PanelEtiquetaEditarUsuario.Visible = false;
            tituloLabel.Text = "HISTORIAL";
           // AbrirForm<NuevaNota>();
        }

        private void CerrarButton_Click(object sender, EventArgs e)
        {
            etiquetaInicio.Visible = false;
            etiquetaHistorial.Visible = false;
            PanelEtiquetaEditarUsuario.Visible = true;
            
        }

        private void CuadernosInicio_Load(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Usuarios = Usuarios;
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                Usuarios = loginForm.Usuarios;
                IndiceUsuario = loginForm.IndiceUsuario;
                UsuariosEstaticos = Usuarios;
                IndiceUsuarioEstatico = IndiceUsuario;
                usuarioLabel.Text = Usuarios[IndiceUsuario].Nombre;

                ArchivoManager archivoManager = new ArchivoManager();
                CargarInformacionActividadUsuario(archivoManager, "Ingreso al sistema", $"El usuario {Usuarios[IndiceUsuario].Nombre} ingreso al sistema.", "Cuadernos Menu", 0);
                CrearHistorialVisitaFormulario(archivoManager);
            }
            else
            {
                this.Close();
            }
            etiquetaInicio.Visible = true;
            etiquetaHistorial.Visible = false;
            PanelEtiquetaEditarUsuario.Visible = false;
        }

        private void CabezaPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ListaOpcionePanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void CargarInformacionActividadUsuario(ArchivoManager archivoManager, String accion, String informacionAdicional, string formulario, int objeto)
        {
            archivoManager.Historial = new Historial(DateTime.Now, Usuarios[IndiceUsuario].Nombre, accion, informacionAdicional, formulario, objeto);
        }
        private void CrearHistorialVisitaFormulario(ArchivoManager archivoManager)
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

        private void ButtonCerrarSecion_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea cerrar la seción?", "Confirmacion", MessageBoxButtons.YesNoCancel);
            if (resultado == DialogResult.Yes)
            {
                CuadernosInicio cuadernosInicio = new CuadernosInicio();
                cuadernosInicio.Usuarios = UsuariosEstaticos;
                ArchivoManager archivoManager = new ArchivoManager();
                CargarInformacionActividadUsuario(archivoManager, "Salir del sistema", $"El usuario {Usuarios[IndiceUsuario].Nombre} salio del sistema.", "Ventana", 0);
                CrearHistorialVisitaFormulario(archivoManager);
                this.Close();
                cuadernosInicio.Show();
            }
        }

        private void ButtonEditarUsuario_Click(object sender, EventArgs e)
        {
            etiquetaInicio.Visible = false;
            etiquetaHistorial.Visible = false;
            PanelEtiquetaEditarUsuario.Visible = true;
            tituloLabel.Text = "EDITAR USUARIO";
            //        EditarUsuario editarUsuario = new EditarUsuario();
            //        MostrarFormEnPanel(editarUsuario);
            ArchivoManager archivoManager = new ArchivoManager();
            CargarInformacionActividadUsuario(archivoManager, "Presionar el boton de Editar Usuario", $"El usuario {CuadernosInicio.UsuariosEstaticos[CuadernosInicio.IndiceUsuarioEstatico].Nombre} ingreso al formulario de Editar usuario", "Editar Usuario", 0);
            CrearHistorialVisitaFormulario(archivoManager);
            AbrirForm<EditarUsuario>();
        }
    }
}
