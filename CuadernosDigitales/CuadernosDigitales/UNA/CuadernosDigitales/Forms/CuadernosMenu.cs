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

namespace CuadernosDigitales.Forms
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
        public Form FormCerrar
        {
            get;
            set;
        }
        public CuadernosInicio()
        {
            InitializeComponent();
            Usuarios = new List<Usuario>();
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
            if (listaOpcionePanel.Width == 188)
            {
                listaOpcionePanel.Width = 52;
            }
            else
            {
                listaOpcionePanel.Width = 188;
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
            etiquetaCambiarU.Visible = false;
            tituloLabel.Text = "INICIO";
            Inicio inicio = new Inicio();
            inicio.Usuarios = Usuarios;
            inicio.IndiceUsuario = IndiceUsuario;
            MostrarFormEnPanel(inicio);
        }

        private void HistorialButton_Click(object sender, EventArgs e)
        {
            etiquetaInicio.Visible = false;
            etiquetaHistorial.Visible = true;
            etiquetaCambiarU.Visible = false;
            tituloLabel.Text = "HISTORIAL";
        }

        private void CuadernosInicio_Load(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Usuarios = Usuarios;
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                Usuarios = loginForm.Usuarios;
                IndiceUsuario = loginForm.IndiceUsuario;
                LabelNombre.Text = Usuarios[IndiceUsuario].Nombre;

                ArchivoManager archivoManager = new ArchivoManager();
                CargarInformacionActividadUsuario(archivoManager, "Ingreso al sistema", $"El usuario {Usuarios[IndiceUsuario].Nombre} ingreso al sistema.", "Cuadernos Menu", 0);
                CrearHistorialVisitaFormulario(archivoManager);
            }
            else
            {
                this.Close();
            }
            etiquetaInicio.Visible = false;
            etiquetaHistorial.Visible = false;
            etiquetaCambiarU.Visible = false;
            
        }

        private void CabezaPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ButtonUsuarioEditar_Click(object sender, EventArgs e)
        {
            etiquetaInicio.Visible = false;
            etiquetaHistorial.Visible = false;
            etiquetaCambiarU.Visible = true;
            tituloLabel.Text = "EDITAR USUARIO";
            EditarUsuario editarUsuario = new EditarUsuario();
            editarUsuario.Usuarios = Usuarios;
            editarUsuario.IndiceUsuario = IndiceUsuario;
            MostrarFormEnPanel(editarUsuario);
        }

        private void ButtonCerrarSecion_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea cerrar la seción?", "Confirmacion", MessageBoxButtons.YesNoCancel);
            if (resultado == DialogResult.Yes)
            {
                CuadernosInicio cuadernosInicio = new CuadernosInicio();
                cuadernosInicio.Usuarios = Usuarios;
                ArchivoManager archivoManager = new ArchivoManager();
                CargarInformacionActividadUsuario(archivoManager, "Salir del sistema", $"El usuario {Usuarios[IndiceUsuario].Nombre} salio del sistema.", "Ventana", 0);
                CrearHistorialVisitaFormulario(archivoManager);
                this.Close();
                cuadernosInicio.Show();
            }            
        }

        private void CargarInformacionActividadUsuario(ArchivoManager archivoManager, String accion, String informacionAdicional, string formulario, int objeto)
        {
            archivoManager.Historial = new Historial(DateTime.Now, Usuarios[IndiceUsuario].Nombre ,accion, informacionAdicional, formulario, objeto) ;
        }
        private void CrearHistorialVisitaFormulario(ArchivoManager archivoManager)
        {
            try
            {
                string nombreNuevoArchivo = archivoManager.CrearHistorialVisitaFormulario(rutaPorDefecto);
            }
            catch (Exception exception)
            {

            }
        }
    }
}
