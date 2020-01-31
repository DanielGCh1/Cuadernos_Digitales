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
    public partial class NuevaNota : Form
    {
        private readonly string rutaPorDefecto = AppDomain.CurrentDomain.BaseDirectory;

        public Bitmap colorSeleccionado;
        public  static Nota nota;
        private NotasMenu notasMenu;
        private bool esNueva;
        private bool atras;

        public NuevaNota(NotasMenu notasMenu, bool esNueva)
        {
            InitializeComponent();
            this.notasMenu = notasMenu;
            this.esNueva = esNueva;
            nota = new Nota();
            if (!esNueva)
            {
                cargarNota();
            }

        }

        private void cargarNota()
        {
            tituloNotaTextBox.Text = NotasMenu.notaSeleccionada.Titulo;
            notaTextBox.Text = NotasMenu.notaSeleccionada.Contenido;
            categoriaTextBox.Text = NotasMenu.notaSeleccionada.Categoria ;
            colorSeleccionadoPanel.BackColor = NotasMenu.notaSeleccionada.Color ;
            notaTextBox.Font = NotasMenu.notaSeleccionada.Fuente;
            notaTextBox.ForeColor = NotasMenu.notaSeleccionada.ColorDeLetra;
            tituloNotaTextBox.ForeColor = NotasMenu.notaSeleccionada.ColorDeLetra;
            ocultarCheckBox.Checked = NotasMenu.notaSeleccionada.Privacidad;
            notaTextBox.BackColor = NotasMenu.notaSeleccionada.Color;
            tituloNotaTextBox.BackColor = NotasMenu.notaSeleccionada.Color;
            if (NotasMenu.notaSeleccionada.FechaDeModificacion == DateTime.MinValue)
            {
                fechaNotaLabel.Text = "Fecha de creación: "+Convert.ToString(NotasMenu.notaSeleccionada.FechaDeCreacion);
            }
            else
            {
                fechaNotaLabel.Text = "Fecha de modificación: " + Convert.ToString(NotasMenu.notaSeleccionada.FechaDeModificacion);
            }
            OcultarPropiedades();

        }
        private void MostrarPropiedades()
        {
            
            notaPanel.Location = new Point(220, 0);
            notaPanel.Width = 578;
            tituloNotaTextBox.Width = 552;
            notaTextBox.Width = 552;
            controlsPropiedadesPanel.Visible = true;
            
        }
        private void OcultarPropiedades()
        {

            notaPanel.Location = new Point(50, 0);
            notaPanel.Width = 750;
            tituloNotaTextBox.Width = 720;
            notaTextBox.Width = 720;
            controlsPropiedadesPanel.Visible = false;
        }
        private void PropiedadesButton_Click(object sender, EventArgs e)
        {
            if(notaPanel.Size.Width == 578) //si esta minimizado
            {
                OcultarPropiedades();
            }
            else //si esta maximizado
            {
               MostrarPropiedades();
                
            }
           
        }

        private void CloseNuevoCuadernoButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void GuardarNotaButton_Click(object sender, EventArgs e)
        {
            bool mensaje = false;
            bool informacionCompleta = false;
            if (String.IsNullOrEmpty(categoriaTextBox.Text) && String.IsNullOrEmpty(tituloNotaTextBox.Text))
            {
                MessageBox.Show("La Nota no tiene titulo, ni categoria", "Alerta", MessageBoxButtons.OK);
                mensaje = true;

            }
            else if(String.IsNullOrEmpty(categoriaTextBox.Text)&&!mensaje)
            {
                MessageBox.Show("La Nota no tiene una categoria", "Alerta",MessageBoxButtons.OK);
                MostrarPropiedades();
                errorProvider.SetError(categoriaTextBox, "Ingrese la categoria de la nota");

            }else if (String.IsNullOrEmpty(tituloNotaTextBox.Text)&&!mensaje)
            {
                MessageBox.Show("La Nota no tiene un titulo", "Alerta", MessageBoxButtons.OK);
                errorProvider.SetError(tituloNotaTextBox, "Ingrese un titulo");
            }else if (!String.IsNullOrEmpty(categoriaTextBox.Text) && !String.IsNullOrEmpty(tituloNotaTextBox.Text))
            {  
                nota.Categoria = categoriaTextBox.Text;
                nota.ColorDeLetra = fontDialog.Color;
                nota.Color = colorSeleccionadoPanel.BackColor;
                nota.Fuente = fontDialog.Font;
                nota.Contenido = notaTextBox.Text;
                nota.Titulo = tituloNotaTextBox.Text;
                nota.FechaDeCreacion = DateTime.Now;
               // nota.FechaDeModificacion = null;
                nota.Privacidad = ocultarCheckBox.Checked;
                informacionCompleta = true;

                Font font = new Font("sdfsdf",4);

                Console.WriteLine(fontDialog.Font);
                Console.WriteLine(fontDialog.Font.Name);
                Console.WriteLine(fontDialog.Font.Size);
                Console.WriteLine(fontDialog.Font.Unit);
                Console.WriteLine(fontDialog.Font.GdiCharSet);
                Console.WriteLine(fontDialog.Font.GdiVerticalFont);
            }
            if (!esNueva)
            {
                nota.FechaDeModificacion = DateTime.Now;
                NotasMenu.notaNueva = nota;

                MessageBox.Show(nota.Titulo);
            }
            if (informacionCompleta)
            {
                atras = false;
                this.Close();
            } 

        }

        private void LightGreen_Click(object sender, EventArgs e)
        {
            colorSeleccionadoPanel.BackColor = System.Drawing.Color.LightGreen;
           //colorSeleccionado = Properties.Resources.Green;
            notaTextBox.BackColor = Color.LightGreen;
            tituloNotaTextBox.BackColor = Color.LightGreen;
        }

        private void LightCoralButton_Click(object sender, EventArgs e)
        {
            colorSeleccionadoPanel.BackColor = System.Drawing.Color.LightCoral;
            //colorSeleccionado = Properties.Resources.Red;
            notaTextBox.BackColor = Color.LightCoral;
            tituloNotaTextBox.BackColor = Color.LightCoral;
        }

        private void TanButton_Click(object sender, EventArgs e)
        {
            colorSeleccionadoPanel.BackColor = System.Drawing.Color.Tan;
            //colorSeleccionado = Properties.Resources.Red;
            notaTextBox.BackColor = Color.Tan;
            tituloNotaTextBox.BackColor = Color.Tan;
        }

        private void YellowButton_Click(object sender, EventArgs e)
        {
            colorSeleccionadoPanel.BackColor = System.Drawing.Color.Yellow;
            // colorSeleccionado = Properties.Resources.Yellow;
            notaTextBox.BackColor = Color.Yellow;
            tituloNotaTextBox.BackColor = Color.Yellow;
        }

        private void CornflowerBlueButton_Click(object sender, EventArgs e)
        {
            colorSeleccionadoPanel.BackColor = System.Drawing.Color.CornflowerBlue;
            colorSeleccionado = Properties.Resources.Blue;
            notaTextBox.BackColor = Color.CornflowerBlue;
            tituloNotaTextBox.BackColor = Color.CornflowerBlue;
        }

        private void DeepSkyBlueButton_Click(object sender, EventArgs e)
        {
            colorSeleccionadoPanel.BackColor = System.Drawing.Color.DeepSkyBlue;
            //colorSeleccionado = Properties.Resources.DeepSkyBlue;
            notaTextBox.BackColor = Color.DeepSkyBlue;
            tituloNotaTextBox.BackColor = Color.DeepSkyBlue;
        }

        private void OrchidButton_Click(object sender, EventArgs e)
        {
            colorSeleccionadoPanel.BackColor = System.Drawing.Color.Orchid;
            //colorSeleccionado = "DeepPink";
            notaTextBox.BackColor = Color.Orchid;
            tituloNotaTextBox.BackColor = Color.Orchid;

        }

        private void PinkButton_Click(object sender, EventArgs e)
        {
            colorSeleccionadoPanel.BackColor = System.Drawing.Color.Pink;
            // colorSeleccionado = "Pink";
            notaTextBox.BackColor = Color.Pink;
            tituloNotaTextBox.BackColor = Color.Pink;
        }

        private void KhakiButton_Click(object sender, EventArgs e)
        {
            colorSeleccionadoPanel.BackColor = System.Drawing.Color.Khaki;
            colorSeleccionado = Properties.Resources.Purple;
            notaTextBox.BackColor = Color.Khaki;
            tituloNotaTextBox.BackColor = Color.Khaki;
        }

        private void WhiteButton_Click(object sender, EventArgs e)
        {
            colorSeleccionadoPanel.BackColor = System.Drawing.Color.White;
            notaTextBox.BackColor = Color.White;
            tituloNotaTextBox.BackColor = Color.White;

        }

        private void GrayButton_Click(object sender, EventArgs e)
        {
            colorSeleccionadoPanel.BackColor = System.Drawing.Color.Gray;
            notaTextBox.BackColor = Color.Gray;
            tituloNotaTextBox.BackColor = Color.Gray;
        }

        private void BlackButton_Click(object sender, EventArgs e)
        {
            colorSeleccionadoPanel.BackColor = System.Drawing.Color.Black;
            notaTextBox.BackColor = Color.Black;
            tituloNotaTextBox.BackColor = Color.Black;
        }

        private void TituloNotaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((int)e.KeyChar==(int)Keys.Enter)
            {
                notaTextBox.Select();
            }
        }

        private void CambiarFuenteButton_Click(object sender, EventArgs e)
        {
            fontDialog.ShowColor = true;
            fontDialog.Font = notaTextBox.Font;

            if(fontDialog.ShowDialog() == DialogResult.OK )
            {
                notaTextBox.Font = fontDialog.Font;
                notaTextBox.ForeColor = fontDialog.Color;
                tituloNotaTextBox.ForeColor = fontDialog.Color;
            }
        }

        private void NuevaNota_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!atras)
            {
                if (esNueva) notasMenu.NuevaNotaGuardada();
                if (!esNueva) notasMenu.NotaEditada();
            }
            
        }

        private void AtrarButton_Click(object sender, EventArgs e)
        {
            atras = true;
            this.Close();
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

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

        private void NuevaNota_Load(object sender, EventArgs e)
        {

        }
    }
}
