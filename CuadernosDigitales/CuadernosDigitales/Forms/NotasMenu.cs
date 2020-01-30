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
    public partial class NotasMenu : Form
    {
        private readonly string rutaPorDefecto = AppDomain.CurrentDomain.BaseDirectory;

        private Cuaderno cuadernoPadre;
        public static Nota notaNueva;
        public static Nota notaSeleccionada;
        private Panel panelSeleccionadaAux;
        private bool sePuedeEditarNota;
        private bool buscandoOcultas;

        public int IndiceNota
        {
            get;
            set;
        }
        public NotasMenu()
        {
            InitializeComponent();
        //    CargarNotasDeBaseDeDatos();

            cuadernoPadre = CuadernosMenu.CuadernoSeleccionado;
            nombreCuadernoLabel.Text = cuadernoPadre.Nombre;
            cargarNotas(cuadernoPadre.getListaDeNotas(),false);
            panelSeleccionadaAux = new Panel();
            sePuedeEditarNota = true;
        }
      
        private void NuevaNotaButton_Click(object sender, EventArgs e)
        {
            NuevaNota nuevaNota = new NuevaNota(this, true);
            AddOwnedForm(nuevaNota);
            nuevaNota.TopLevel = false;
            nuevaNota.Dock = DockStyle.Fill;
            this.Controls.Add(nuevaNota);
            this.Tag = nuevaNota;
            nuevaNota.BringToFront();

            Historial historial = new Historial(CuadernosInicio.UsuariosEstaticos[CuadernosInicio.IndiceUsuarioEstatico].Nombre, "Presionar el boton de Nueva Nota", $"El usuario {CuadernosInicio.UsuariosEstaticos[CuadernosInicio.IndiceUsuarioEstatico].Nombre} ingreso al formulario de Nueva Nota", "NuevaNota");
            historial.AgregarHistorialALaBaseDeDatos(historial);

            //ArchivoHistorial archivoManagerHistorial = new ArchivoHistorial();
            //CargarInformacionActividadUsuario(archivoManagerHistorial, "Presionar el boton de Nueva Nota", $"El usuario {CuadernosInicio.UsuariosEstaticos[CuadernosInicio.IndiceUsuarioEstatico].Nombre} ingreso al formulario de Nueva Nota", "NuevaNota", 0);
            //CrearHistorialVisitaFormulario(archivoManagerHistorial);

            nuevaNota.Show();

        }
        public  void NuevaNotaGuardada()
        {
            //ArchivoHistorial archivoManager = new ArchivoHistorial();
            //CargarInformacionActividadUsuario(archivoManager, "Presionar el boton de crear nueva nota", $"El usuario {CuadernosInicio.UsuariosEstaticos[CuadernosInicio.IndiceUsuarioEstatico].Nombre} creo una nueva nota", "Notas Menu", CuadernosMenu.CuadernoSeleccionado.getListaDeNotas().Count());
            //CrearHistorialCreacionNota(archivoManager);

            notaNueva = NuevaNota.nota;
            notaNueva.Orden = CuadernosMenu.CuadernoSeleccionado.getListaDeNotas().Count;
            notaNueva.IndiceNota = CuadernosMenu.CuadernoSeleccionado.getListaDeNotas().Count + 1;
            CuadernosMenu.CuadernoSeleccionado.agregarNota(notaNueva);
            if(!notaNueva.Privacidad) MostrarNotaEnPantalla(notaNueva);

            Historial historial = new Historial(CuadernosInicio.UsuariosEstaticos[CuadernosInicio.IndiceUsuarioEstatico].Nombre, "Presionar el boton de crear nueva nota", $"El usuario {CuadernosInicio.UsuariosEstaticos[CuadernosInicio.IndiceUsuarioEstatico].Nombre} creo una nueva nota", Convert.ToString(notaNueva.IndiceNota));
            historial.AgregarHistorialALaBaseDeDatos(historial);
        }
        public void NotaEditada()
        {
            int numeroNota = CuadernosMenu.CuadernoSeleccionado.BuscarNota(notaSeleccionada.Titulo);
            
            if (numeroNota!=-1)
            {
                foreach(Control item in notasContainer.Controls)
                {

                    if(item.Name == CuadernosMenu.CuadernoSeleccionado.ObtenerNombre(numeroNota)&&item is Panel)
                    {
                        ((Panel)item).BackColor = notaNueva.Color;
                        ((Panel)item).Name = notaNueva.Titulo;
                        foreach(Control c in ((Panel)item).Controls)
                        {
                            if(c is Label)
                            {
                                ((Label)c).Name = item.Name;
                                ((Label)c).Text = item.Name;
                            }
                        }
                    }
                }
                Historial historial = new Historial(CuadernosInicio.UsuariosEstaticos[CuadernosInicio.IndiceUsuarioEstatico].Nombre, "Edición de nota", $"El usuario {CuadernosInicio.UsuariosEstaticos[CuadernosInicio.IndiceUsuarioEstatico].Nombre} edito una nota", Convert.ToString(CuadernosMenu.CuadernoSeleccionado.ObtenerIndiceDeLaNotaEnBaseDeDatos(numeroNota)));
                historial.AgregarHistorialALaBaseDeDatos(historial);

                //ArchivoHistorial archivoManager = new ArchivoHistorial();
                //CargarInformacionActividadUsuario(archivoManager, "Edición de nota", $"El usuario {CuadernosInicio.UsuariosEstaticos[CuadernosInicio.IndiceUsuarioEstatico].Nombre} edito una nota", "Notas Menu", numeroNota);
                //CrearHistorialCreacionNota(archivoManager);

                CuadernosMenu.CuadernoSeleccionado.ModificarNota(numeroNota, notaNueva);
            }
        }

        private void MostrarNotaEnPantalla(Nota nota)
        {  
            Panel panel = new Panel();
            Label nombre = new Label();
            panel.BackColor = nota.Color;
            panel.Margin = new Padding(15);
            panel.Size = new Size(355, 45);
            panel.TabIndex = 9;
            panel.Name = nota.Titulo;
            nombre.AutoSize = true;
            nombre.Name = nota.Titulo;
            nombre.Text = nota.Titulo;
            nombre.Location = new Point(14, 12);
            nombre.Enabled = false;
            nombre.Font = new Font("NewsGoth BT", 12F, FontStyle.Bold);
            panel.Controls.Add(nombre);
            panel.MouseClick += new MouseEventHandler(this.NotaSeleccionada_MouseClick);
            notasContainer.Controls.Add(panel);
            
        }

        private void cargarNotas(List<Nota> notas, bool mostrarOcultas)
        {
            if (notas!=null)
            {
                foreach(Nota item in notas)
                {
                    if (!item.Privacidad)
                    {
                        MostrarNotaEnPantalla(item);
                    }else if(item.Privacidad && mostrarOcultas)
                    {
                        MostrarNotaEnPantalla(item);
                    }

                }
            }

        }

        private void NotaSeleccionada_MouseClick(object sender, MouseEventArgs e)
        {
            
            Panel notaSelect = sender as Panel;

            for (int i = 0; i < cuadernoPadre.getListaDeNotas().Count; i++)
            {
                Nota nota = (cuadernoPadre.getListaDeNotas())[i];
                if (notaSelect.Name == nota.Titulo)
                {
                    notaSeleccionada = new Nota();
                    notaSeleccionada = nota;
                    IndiceNota = i;
                }
            }
            foreach (Nota nota in cuadernoPadre.getListaDeNotas())
            {
                if (notaSelect.Name == nota.Titulo)
                {
                    notaSeleccionada = new Nota();
                    notaSeleccionada = nota;
                }
            }
            if(e.Button == MouseButtons.Right)
            {
                int numeroNota = CuadernosMenu.CuadernoSeleccionado.BuscarNota(notaSeleccionada.Titulo);
                foreach (Control item in notasContainer.Controls)
                {
                    if (item.Name == CuadernosMenu.CuadernoSeleccionado.ObtenerNombre(numeroNota) && item is Panel)
                    {
                        if(((Panel)item)!= panelSeleccionadaAux){
                            panelSeleccionadaAux.BorderStyle = BorderStyle.None;
                            panelSeleccionadaAux = ((Panel)item);
                        }
                        ((Panel)item).BorderStyle = BorderStyle.FixedSingle;
                    }
                }

                nuevaNotaButton.Visible = false;
                verOcultasButton.Visible = false;
                eliminarButton.Visible = true;
                cancelarButton.Visible = true;
                sePuedeEditarNota = false;
               
            }
            else if(e.Button == MouseButtons.Left && sePuedeEditarNota)
            {
                Historial historial = new Historial(CuadernosInicio.UsuariosEstaticos[CuadernosInicio.IndiceUsuarioEstatico].Nombre, "Presionar una nota", $"El usuario {CuadernosInicio.UsuariosEstaticos[CuadernosInicio.IndiceUsuarioEstatico].Nombre} ingreso al formulario de Nueva Nota para una posible edición de una nota.", "NuevaNota");
                historial.AgregarHistorialALaBaseDeDatos(historial);

                //ArchivoHistorial archivoManager = new ArchivoHistorial();
                //CargarInformacionActividadUsuario(archivoManager, "Presionar una nota", $"El usuario {CuadernosInicio.UsuariosEstaticos[CuadernosInicio.IndiceUsuarioEstatico].Nombre} ingreso al formulario de Nueva Nota para una posible edición de una nota.", "Nueva Nota", IndiceNota);
                //CrearHistorialVisitaFormulario(archivoManager);

                NuevaNota nuevaNota = new NuevaNota(this, false);
                AddOwnedForm(nuevaNota);
                nuevaNota.TopLevel = false;
                nuevaNota.Dock = DockStyle.Fill;
                this.Controls.Add(nuevaNota);
                this.Tag = nuevaNota;
                nuevaNota.BringToFront();
                nuevaNota.Show();
            }
        }

        private void RegresarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BuscaNotaButton_Click(object sender, EventArgs e)
        {
            ErrorProviderFiltro.SetError(FiltroComboBox, "");
            if (buscarCuadernoTextBox.Text.Length != 0 && FiltroComboBox.SelectedItem != null)
            {
                verOcultasButton.Visible = false;
                List<Nota> notasBusqueda = new List<Nota>();
                List<Nota> notasDondeBuscar = new List<Nota>();


                if (buscandoOcultas)
                {
                    notasDondeBuscar = cuadernoPadre.getNotasOcultas();
                }
                else
                {
                    notasDondeBuscar = cuadernoPadre.getListaDeNotas();
                }

                foreach (Nota nota in cuadernoPadre.getListaDeNotas())
                {
                    if (FiltroComboBox.SelectedItem.ToString() == "NOMBRE")
                    {
                        if (nota.Titulo.Contains(buscarCuadernoTextBox.Text))
                        {
                            if (nota.Titulo == buscarCuadernoTextBox.Text)
                            {
                                notasBusqueda.Insert(0, nota);
                            }
                            else
                            {
                                notasBusqueda.Add(nota);
                            }
                        }
                    }
                    else if (FiltroComboBox.SelectedItem.ToString() == "CATEGORIA")
                    {
                        if (nota.Categoria == buscarCuadernoTextBox.Text)
                        {
                            notasBusqueda.Add(nota);
                        }
                    }

                }
                if (notasBusqueda != null)
                {
                    notasContainer.Controls.Clear();
                    cargarNotas(notasBusqueda, buscandoOcultas);
                    nuevaNotaButton.Visible = false;
                    verNotasButton.Visible = false;
                    verNotasButton.Visible = true;
                }
                else
                {
                    MessageBox.Show("No hay resultados de su busqueda", "Informacion");
                }


            }
            else if (FiltroComboBox.SelectedItem == null)
            {

                ErrorProviderFiltro.SetError(FiltroComboBox, "Debe seleccionar un filtro");
            }
            else if (buscarCuadernoTextBox.Text.Length == 0)
            {

                ErrorProviderFiltro.SetError(FiltroComboBox, "Debe ingresar lo que desea buscar");
            }
            Historial historial = new Historial(CuadernosInicio.UsuariosEstaticos[CuadernosInicio.IndiceUsuarioEstatico].Nombre, "Se hizo una búsqueda", $"El usuario {CuadernosInicio.UsuariosEstaticos[CuadernosInicio.IndiceUsuarioEstatico].Nombre} hizo una búsqueda de una o varias notas.", null);
            historial.AgregarHistorialALaBaseDeDatos(historial);

            //ArchivoHistorial archivoManager = new ArchivoHistorial();
            //CargarInformacionActividadUsuario(archivoManager, "Se hizo una búsqueda", $"El usuario {CuadernosInicio.UsuariosEstaticos[CuadernosInicio.IndiceUsuarioEstatico].Nombre} hizo una búsqueda de una o varias notas.", "Notas Menu", 0);
            //CrearHistorialBusqueda(archivoManager);
        }

        private void VerNotasButton_Click(object sender, EventArgs e)
        {
            buscandoOcultas = false;
            notasContainer.Controls.Clear();
            verNotasButton.Visible = false;
            cancelarButton.Visible = false;
            nuevaNotaButton.Visible = true;
            verOcultasButton.Visible = true;
            buscarCuadernoTextBox.Text = "";
            cargarNotas(cuadernoPadre.getListaDeNotas(), false);
            sePuedeEditarNota = true;
        }

        private void VerOcultasButton_Click(object sender, EventArgs e)
        {
            Historial historial = new Historial(CuadernosInicio.UsuariosEstaticos[CuadernosInicio.IndiceUsuarioEstatico].Nombre, "Presionar el boton de Ver Notas Ocultas", $"El usuario {CuadernosInicio.UsuariosEstaticos[CuadernosInicio.IndiceUsuarioEstatico].Nombre} ingreso al formulario de Notas Ocultas", "NotasOcultas");
            historial.AgregarHistorialALaBaseDeDatos(historial);

            //ArchivoHistorial archivoManagerHistorial = new ArchivoHistorial();
            //CargarInformacionActividadUsuario(archivoManagerHistorial, "Presionar el boton de Ver Notas Ocultas", $"El usuario {CuadernosInicio.UsuariosEstaticos[CuadernosInicio.IndiceUsuarioEstatico].Nombre} ingreso al formulario de Notas Ocultas", "Notas Ocultas", 0);
            //CrearHistorialVisitaFormulario(archivoManagerHistorial);

            List<Nota> notasOcultas = new List<Nota>();
            buscandoOcultas = true;
            notasOcultas = cuadernoPadre.getNotasOcultas();

            if (notasOcultas != null)
            {
                NotasOcultas notasOcultasForm = new NotasOcultas();

                if (notasOcultasForm.ShowDialog() == DialogResult.OK)
                {
                    notasContainer.Controls.Clear();
                    nuevaNotaButton.Visible = false;
                    verOcultasButton.Visible = false;
                    verNotasButton.Visible = true;
                    cargarNotas(notasOcultas, true);
                }

            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            Historial historial = new Historial(CuadernosInicio.UsuariosEstaticos[CuadernosInicio.IndiceUsuarioEstatico].Nombre, "Se elimino una nota", $"El usuario {CuadernosInicio.UsuariosEstaticos[CuadernosInicio.IndiceUsuarioEstatico].Nombre} elimino una nota.", Convert.ToString(notaSeleccionada.IndiceNota));
            historial.AgregarHistorialALaBaseDeDatos(historial);

            //ArchivoHistorial archivoManager = new ArchivoHistorial();
            //CargarInformacionActividadUsuario(archivoManager, "Se elimino una nota", $"El usuario {CuadernosInicio.UsuariosEstaticos[CuadernosInicio.IndiceUsuarioEstatico].Nombre} elimino una nota.", "Notas Menu", IndiceNota);
            //CrearHistorialEliminarNota(archivoManager);

            cuadernoPadre.EliminarNota(notaSeleccionada);
            VerNotasButton_Click(sender, e);
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            VerNotasButton_Click(sender, e);
        }

        private void NotasMenu_Load(object sender, EventArgs e)
        {

            foreach (Categoria c in cuadernoPadre.getListaDeCategorias())
            {
                Label categoriaLabel = new Label();
                categoriaLabel.AutoSize = true;
                categoriaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                categoriaLabel.Location = new System.Drawing.Point(10, 10);
                categoriaLabel.Margin = new System.Windows.Forms.Padding(10);
                categoriaLabel.Name = "ejemploLabel";
                categoriaLabel.Size = new System.Drawing.Size(29, 20);
                categoriaLabel.TabIndex = 0;
                categoriaLabel.ForeColor = Color.White;
                categoriaLabel.BackColor = Color.Green;
                categoriaLabel.Text = "#"+c.Nombre;
                categoriasPanel.Controls.Add(categoriaLabel);
            }
            Historial historial = new Historial(CuadernosInicio.UsuariosEstaticos[CuadernosInicio.IndiceUsuarioEstatico].Nombre, "Presionar un cuaderno", $"El usuario {CuadernosInicio.UsuariosEstaticos[CuadernosInicio.IndiceUsuarioEstatico].Nombre} ingreso al formulario de Notas Menu", "NotasMenu");
            historial.AgregarHistorialALaBaseDeDatos(historial);

            //ArchivoHistorial archivoManager = new ArchivoHistorial();
            //CargarInformacionActividadUsuario(archivoManager, "Presionar un cuaderno", $"El usuario {CuadernosInicio.UsuariosEstaticos[CuadernosInicio.IndiceUsuarioEstatico].Nombre} ingreso al formulario de Notas Menu", "Notas Menu", 0);
            //CrearHistorialVisitaFormulario(archivoManager);
        }
        private void CrearHistorialCreacionNota(ArchivoHistorial archivoManager)
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
        private void CrearHistorialBusqueda(ArchivoHistorial archivoManager)
        {
            try
            {
                string nombreNuevoArchivo = archivoManager.CrearHistorialBusquedaObjeto(rutaPorDefecto);
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Se produjo el siguiente error: {exception}");
            }
        }
        private void CrearHistorialEliminarNota(ArchivoHistorial archivoManager)
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
        private void CargarNotasDeBaseDeDatos()
        {
            if (CuadernosMenu.CuadernoSeleccionado.getListaDeNotas().Count == 0)
            {
                Nota nota = new Nota();
                nota.Categoria = "Hola";
                nota.ColorDeLetra = Color.FromName("Black");
                nota.Color = Color.FromName("Red");
                Font font = new Font("sdfsdf", 11);

                nota.Fuente = font;
                nota.Contenido = "Hola que hace";
                nota.Titulo = "Nota de prueba";
                nota.FechaDeCreacion = DateTime.Now;
                // nota.FechaDeModificacion = null;
                nota.Privacidad = false;

                CuadernosMenu.CuadernoSeleccionado.agregarNota(nota);
            }
        }

    }
}
