using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuadernosDigitales.Forms
{
    public partial class NuevoCuaderno : Form
    {
        private readonly string rutaPorDefecto = AppDomain.CurrentDomain.BaseDirectory;

        private int cantidadCategorias;
        public static Cuaderno cuaderno;
        public DialogResult cuadernoCreado;
        private TextBox[] categoriasTexBox;
        public static Bitmap colorSeleccionado;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public NuevoCuaderno()
        {
            InitializeComponent();
            cantidadCategorias = 1;
            categoriasTexBox = new TextBox[9];
            cuaderno = new Cuaderno();
            agregarTextBoxs();
            
            
        }
        public void agregarTextBoxs()
        {
            for(int i = 0; i < 9; i++)
            {
                categoriasTexBox[i] = new TextBox();
                categoriasTexBox[i].Font = new Font("NewsGoth BT", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                // categoriaTextBox.Location = new System.Drawing.Point(x, y);
                categoriasTexBox[i].Name = "categoriaTextBox";
                categoriasTexBox[i].Size = new Size(145, 27);
                categoriasTexBox[i].TabIndex = 0;
                categoriasTexBox[i].Visible = false;
                if (i == 0) categoriasTexBox[i].Visible = true;
                this.flowLayoutPanel1.Controls.Add(categoriasTexBox[i]);
            }
        }

        private void AgregarCategoriaButton_Click(object sender, EventArgs e)
        {
            if (cantidadCategorias < 9)
            {
                categoriasTexBox[cantidadCategorias].Visible = true;
                cantidadCategorias++;
            }
        }

        private void CloseNuevoCuadernoButton_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void CabezaPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void GreenButton_Click(object sender, EventArgs e)
        {
            colorSeleccionadoPanel.BackColor = System.Drawing.Color.Green;
            colorSeleccionado = Properties.Resources.Green;
        }

        private void RedButton_Click(object sender, EventArgs e)
        {
            colorSeleccionadoPanel.BackColor = System.Drawing.Color.Red;
            colorSeleccionado = Properties.Resources.Red;
        }

        private void OrangeButton_Click(object sender, EventArgs e)
        {
            colorSeleccionadoPanel.BackColor = System.Drawing.Color.Orange;
            colorSeleccionado = Properties.Resources.Orange;
        }

        private void YellowButton_Click(object sender, EventArgs e)
        {
            colorSeleccionadoPanel.BackColor = System.Drawing.Color.Yellow;
            colorSeleccionado = Properties.Resources.Yellow;
        }

        private void BlueButton_Click(object sender, EventArgs e)
        {
            colorSeleccionadoPanel.BackColor = System.Drawing.Color.Blue;
            colorSeleccionado = Properties.Resources.Blue;
        }

        private void DeepSkyBlueButton_Click(object sender, EventArgs e)
        {
            colorSeleccionadoPanel.BackColor = System.Drawing.Color.DeepPink;
            colorSeleccionado = Properties.Resources.DeepSkyBlue;
        }

        private void DeepPinkButton_Click(object sender, EventArgs e)
        {
            colorSeleccionadoPanel.BackColor = System.Drawing.Color.DeepPink;
            colorSeleccionado = Properties.Resources.DeepPink;

        }

        private void PinkButton_Click(object sender, EventArgs e)
        {
            colorSeleccionadoPanel.BackColor = System.Drawing.Color.Pink;
            colorSeleccionado = Properties.Resources.Pink;
        }

        private void PurpleButton_Click(object sender, EventArgs e)
        {
            colorSeleccionadoPanel.BackColor = System.Drawing.Color.Purple;
            colorSeleccionado = Properties.Resources.Purple;
        }

        private void WhiteButton_Click(object sender, EventArgs e)
        {
            colorSeleccionadoPanel.BackColor = System.Drawing.Color.White;
            colorSeleccionado = Properties.Resources.White;
        }

        private void GrayButton_Click(object sender, EventArgs e)
        {
            colorSeleccionadoPanel.BackColor = System.Drawing.Color.Gray;
            colorSeleccionado = Properties.Resources.Gray;
        }

        private void BlackButton_Click(object sender, EventArgs e)
        {
            colorSeleccionadoPanel.BackColor = System.Drawing.Color.Black;
            colorSeleccionado = Properties.Resources.Black;
        }

        private void CrearCuadernoButton_Click(object sender, EventArgs e)
        {
            cuaderno.Nombre = nombreCuadernoTextBox.Text;
            cuaderno.Color = colorSeleccionadoPanel.BackColor;
            cuaderno.Imagen = colorSeleccionado;

            Console.WriteLine(colorSeleccionadoPanel.BackColor.Name);
            Console.WriteLine();

            for (int i = 0; i < 9; i++)
            {
                if (categoriasTexBox[i].Text.Length != 0)
                {
                    Categoria categoria1 = new Categoria();
                    categoria1.Nombre = categoriasTexBox[i].Text;
                    cuaderno.agregarCategoria(categoria1);
                }
            }

            cuadernoCreado = DialogResult.Yes;
            this.Close();
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
        private void CrearHistorialCreacionCuaderno(ArchivoHistorial archivoManager)
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

        private void NuevoCuaderno_Load(object sender, EventArgs e)
        {
            Historial historial = new Historial(CuadernosInicio.UsuariosEstaticos[CuadernosInicio.IndiceUsuarioEstatico].Nombre, "Presionar el boton de Nuevo Cuaderno", $"El usuario {CuadernosInicio.UsuariosEstaticos[CuadernosInicio.IndiceUsuarioEstatico].Nombre} ingreso al formulario de Nuevo Cuaderno", "NuevoCuaderno");
            historial.AgregarHistorialALaBaseDeDatos(historial);

            //ArchivoHistorial archivoManager = new ArchivoHistorial();
            //CargarInformacionActividadUsuario(archivoManager, "Presionar el boton de Nuevo Cuaderno", $"El usuario {CuadernosInicio.UsuariosEstaticos[CuadernosInicio.IndiceUsuarioEstatico].Nombre} ingreso al formulario de Nuevo Cuaderno", "NuevoCuaderno", 0);
            //CrearHistorialVisitaFormulario(archivoManager);
        }
    }
}
