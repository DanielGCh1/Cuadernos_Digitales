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
    public partial class CuadernosMenu : Form
    {
        private readonly string rutaPorDefecto = AppDomain.CurrentDomain.BaseDirectory;
        public int IndiceCuaderno
        {
            get;
            set;
        }

        public List <Cuaderno> cuadernos;
        public static Cuaderno CuadernoSeleccionado;
        private PictureBox picSelected;
        private PictureBox picSelectedAux;
        private bool sePuedenVerNotas;
        private bool buscando;

        public CuadernosMenu()
        {
            InitializeComponent();
            cuadernos = new List<Cuaderno>();
            picSelectedAux = new PictureBox();
            sePuedenVerNotas = true;
        }

        public void CuadernoPictureBox_Click(object sender, EventArgs e)
        {
            getPicYCuadernoSeleccionado(sender, e);
            if(picSelected!= picSelectedAux)
            {
                picSelectedAux.BorderStyle = BorderStyle.None;
            }
            picSelected.BorderStyle = BorderStyle.FixedSingle;
            picSelected.BackColor = Color.DeepSkyBlue;
            picSelectedAux = picSelected;
            nuevoCuadernoButton.Visible = false;
            eliminarButton.Visible = true;
            atrasButton.Visible = true;
            sePuedenVerNotas = false;
        }
        private void getPicYCuadernoSeleccionado(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            picSelected = new PictureBox();
            picSelected = pic;
            for (int i = 0; i < cuadernos.Count; i++)
            {
                Cuaderno cuaderno = cuadernos[i];
                if (pic.Name == cuaderno.Nombre)
                {
                    CuadernoSeleccionado = new Cuaderno();
                    CuadernoSeleccionado = cuaderno;
            //        IndiceCuaderno = i;
                }
            }
/*            foreach (Cuaderno cuaderno in cuadernos)
            {
                if (pic.Name == cuaderno.Nombre)
                {
                    CuadernoSeleccionado = new Cuaderno();
                    CuadernoSeleccionado = cuaderno;
                }
            }*/
        }
        public void CuadernoPicture_DoubleClick(object sender, EventArgs e)
        {
            if (sePuedenVerNotas)
            {
                getPicYCuadernoSeleccionado(sender, e);
                AbrirForm<NotasMenu>();
            }
            
 
        }

        private void AbrirForm<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = inicioPanel.Controls.OfType<MiForm>().FirstOrDefault(); //Busca en la coleccion
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.Dock = DockStyle.Fill;
                inicioPanel.Controls.Add(formulario);
                formulario.Show();
                formulario.BringToFront();

            }
            else
            {
                formulario.BringToFront();
            }
        }

        private void NuevoCuadernoButton_Click(object sender, EventArgs e)
        {

            NuevoCuaderno nuevoCuaderno = new NuevoCuaderno();

            nuevoCuaderno.ShowDialog();

            if (nuevoCuaderno.cuadernoCreado == DialogResult.Yes)
            {
                //ArchivoHistorial archivoManager = new ArchivoHistorial();
                //CargarInformacionActividadUsuario(archivoManager, "Presionar el boton de crear nuevo cuaderno", $"El usuario {CuadernosInicio.UsuariosEstaticos[CuadernosInicio.IndiceUsuarioEstatico].Nombre} creo un nuevo cuaderno", "Nuevo Cuaderno", cuadernos.Count);
                //CrearHistorialCreacionCuaderno(archivoManager);

                NuevoCuaderno.cuaderno.Orden = CuadernosInicio.UsuariosEstaticos[CuadernosInicio.IndiceUsuarioEstatico].cuadernos.Count;
                NuevoCuaderno.cuaderno.AgregarCuadernoALaBaseDeDatos(NuevoCuaderno.cuaderno);

                cuadernos = NuevoCuaderno.cuaderno.CargarCuadernosDeLaBaseDeDatos();
                CuadernosInicio.UsuariosEstaticos[CuadernosInicio.IndiceUsuarioEstatico].cuadernos = cuadernos;
                
                
                int indiceDelNuevoCuaderno = CuadernosInicio.UsuariosEstaticos[CuadernosInicio.IndiceUsuarioEstatico].cuadernos[CuadernosInicio.UsuariosEstaticos[CuadernosInicio.IndiceUsuarioEstatico].cuadernos.Count - 1].IndiceCuaderno;

                Cuadernos_Y_Categorias cuadernos_Y_Categorias = new Cuadernos_Y_Categorias();
                cuadernos_Y_Categorias.AgregarRelacionYCategoriasDeCuadernoALaBaseDeDatos(indiceDelNuevoCuaderno, NuevoCuaderno.cuaderno.Categorias);
                cuadernos = NuevoCuaderno.cuaderno.CargarCuadernosDeLaBaseDeDatos();

                Historial historial = new Historial(CuadernosInicio.UsuariosEstaticos[CuadernosInicio.IndiceUsuarioEstatico].Nombre, "Presionar el boton de crear nuevo cuaderno", $"El usuario {CuadernosInicio.UsuariosEstaticos[CuadernosInicio.IndiceUsuarioEstatico].Nombre} creo un nuevo cuaderno", Convert.ToString(indiceDelNuevoCuaderno));
                historial.AgregarHistorialALaBaseDeDatos(historial);

                MostrarCuadernoEnPantalla(CuadernosInicio.UsuariosEstaticos[CuadernosInicio.IndiceUsuarioEstatico].cuadernos[CuadernosInicio.UsuariosEstaticos[CuadernosInicio.IndiceUsuarioEstatico].cuadernos.Count - 1]);
            }
           
        }

        private void MostrarCuadernoEnPantalla(Cuaderno cuaderno)
        {
            UCCuadernoDigital cuadernoDigital = new UCCuadernoDigital(this);
            cuadernoDigital.nombreDeCuaderno = cuaderno.Nombre;
            cuadernoDigital.picture = ImagenSelecionada(cuaderno)/*cuaderno.Imagen Properties.Resources.Black*/;
            cuadernoDigital.namePicture = cuaderno.Nombre;
            cuadernosContainer.Controls.Add(cuadernoDigital);
        }

        private void AtrasButton_Click(object sender, EventArgs e)
        {
            if (buscando)
            {
                buscarTextBox.Text = "";
                nuevoCuadernoButton.Visible = true;
                eliminarButton.Visible = false;
                atrasButton.Visible = false;
                buscando = false;
                cuadernosContainer.Controls.Clear();
                CargarCuadernos(cuadernos);
            }
            else
            {
                picSelected.BorderStyle = BorderStyle.None;
                picSelected.BackColor = Color.White;
                nuevoCuadernoButton.Visible = true;
                eliminarButton.Visible = false;
                atrasButton.Visible = false;
                picSelected = null;
                sePuedenVerNotas = true;
            }
        }

        private void CargarCuadernos(List<Cuaderno> listCuadernos)
        {
            foreach(Cuaderno item in listCuadernos)
            {
                MostrarCuadernoEnPantalla(item);
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            DialogResult resultado =  MessageBox.Show("¿Esta seguro de querer eliminar el cuaderno: "+CuadernoSeleccionado.Nombre+"?", "Alerta",MessageBoxButtons.YesNoCancel);
            if(resultado == DialogResult.Yes)
            {
                Historial historial = new Historial(CuadernosInicio.UsuariosEstaticos[CuadernosInicio.IndiceUsuarioEstatico].Nombre, "Presionar el boton de Eliminar Cuaderno", $"El usuario {CuadernosInicio.UsuariosEstaticos[CuadernosInicio.IndiceUsuarioEstatico].Nombre} elimino un cuaderno.", Convert.ToString(CuadernoSeleccionado.IndiceCuaderno));
                historial.AgregarHistorialALaBaseDeDatos(historial);

                //ArchivoHistorial archivoManager = new ArchivoHistorial();
                //CargarInformacionActividadUsuario(archivoManager, "Presionar el boton de Eliminar Cuaderno", $"El usuario {CuadernosInicio.UsuariosEstaticos[CuadernosInicio.IndiceUsuarioEstatico].Nombre} elimino un cuaderno.", "Cuadernos", IndiceCuaderno);
                //CrearHistorialEliminarCuaderno(archivoManager);
                CuadernoSeleccionado.EliminarCuadernoDeLaBaseDeDatos(CuadernoSeleccionado);
                CuadernosInicio.UsuariosEstaticos[CuadernosInicio.IndiceUsuarioEstatico].cuadernos = CuadernoSeleccionado.CargarCuadernosDeLaBaseDeDatos();
                cuadernos = CuadernosInicio.UsuariosEstaticos[CuadernosInicio.IndiceUsuarioEstatico].cuadernos;
                cuadernosContainer.Controls.Clear();
                CargarCuadernos(cuadernos);
                AtrasButton_Click(sender, e);
            }
        }

        private void BuscaNotaButton_Click(object sender, EventArgs e)
        {
            ErrorProviderFiltro.SetError(FiltroComboBox, "");
            if (buscarTextBox.Text.Length != 0 && !(FiltroComboBox.SelectedItem == null))
            {
                buscando = true;
                List<Cuaderno> cuadernos1 = new List<Cuaderno>();
                foreach (Cuaderno c in cuadernos)
                {
                    if (c.Nombre.Contains(buscarTextBox.Text) && FiltroComboBox.SelectedItem.ToString() == "NOMBRE")
                    {
                        if (c.Nombre == buscarTextBox.Text)
                        {
                            cuadernos1.Insert(0, c);
                        }
                        else
                        {
                            cuadernos1.Add(c);
                        }
                    }
                    else if (FiltroComboBox.SelectedItem.ToString() == "CATEGORIA")
                    {
                        foreach (Categoria categoria in c.getListaDeCategorias())
                        {
                            if (categoria.Nombre == buscarTextBox.Text)
                            {
                                cuadernos1.Add(c);
                            }
                        }
                    }

                }

                if (cuadernos1.Count != 0)
                {
                    cuadernosContainer.Controls.Clear();
                    CargarCuadernos(cuadernos1);
                    nuevoCuadernoButton.Visible = false;
                    atrasButton.Visible = true;
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
            Historial historial = new Historial(CuadernosInicio.UsuariosEstaticos[CuadernosInicio.IndiceUsuarioEstatico].Nombre, "Se hizo una búsqueda", $"El usuario {CuadernosInicio.UsuariosEstaticos[CuadernosInicio.IndiceUsuarioEstatico].Nombre} hizo una búsqueda de uno o varios Cuadernos.", null);
            historial.AgregarHistorialALaBaseDeDatos(historial);

            //ArchivoHistorial archivoManager = new ArchivoHistorial();
            //CargarInformacionActividadUsuario(archivoManager, "Se hizo una búsqueda", $"El usuario {CuadernosInicio.UsuariosEstaticos[CuadernosInicio.IndiceUsuarioEstatico].Nombre} hizo una búsqueda de uno o varios Cuadernos.", "Cuadernos", 0);
            //CrearHistorialBusqueda(archivoManager);
        }

        private void BuscarTextBox_TextChanged(object sender, EventArgs e)
        {

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
        private void CrearHistorialEliminarCuaderno(ArchivoHistorial archivoManager)
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
        private void Cuadernos_Load(object sender, EventArgs e)
        {
            Cuaderno cuaderno = new Cuaderno();
            CuadernosInicio.UsuariosEstaticos[CuadernosInicio.IndiceUsuarioEstatico].cuadernos = cuaderno.CargarCuadernosDeLaBaseDeDatos();
            cuadernos = CuadernosInicio.UsuariosEstaticos[CuadernosInicio.IndiceUsuarioEstatico].cuadernos;
            CargarCuadernos(CuadernosInicio.UsuariosEstaticos[CuadernosInicio.IndiceUsuarioEstatico].cuadernos);
         //   CargarCuadernosDeBaseDeDatos();
        }
        private void CargarCuadernosDeBaseDeDatos()
        {
            Cuaderno cuaderno = new Cuaderno();
            cuaderno.Nombre = "Cuaderno de pruebra";
            cuaderno.Color = System.Drawing.Color.Black;
            cuaderno.Imagen = Properties.Resources.Black;
            
            Categoria categoria1 = new Categoria();
            categoria1.Nombre = "Hola";
            cuaderno.agregarCategoria(categoria1);

            cuaderno.Orden = CuadernosInicio.UsuariosEstaticos[CuadernosInicio.IndiceUsuarioEstatico].cuadernos.Count;
            cuadernos.Add(cuaderno);
            CuadernosInicio.UsuariosEstaticos[CuadernosInicio.IndiceUsuarioEstatico].AgregarCuaderno(cuaderno);

            Cuaderno cuadern = new Cuaderno();
            cuadern.Nombre = "Cuaderno de pruebra 2";
            cuadern.Color = System.Drawing.Color.Black;
            cuadern.Imagen = Properties.Resources.Black;

            Categoria categoria = new Categoria();
            categoria.Nombre = "Hola2";
            cuadern.agregarCategoria(categoria);

            cuadern.Orden = CuadernosInicio.UsuariosEstaticos[CuadernosInicio.IndiceUsuarioEstatico].cuadernos.Count;
            cuadernos.Add(cuadern);
            CuadernosInicio.UsuariosEstaticos[CuadernosInicio.IndiceUsuarioEstatico].AgregarCuaderno(cuadern);
            CargarCuadernos(cuadernos);
        }
        private Bitmap ImagenSelecionada(Cuaderno cuaderno)
        {
            Bitmap imagenSeleccionada;

            switch (cuaderno.Color.Name)
            {
                case "Green":
                    imagenSeleccionada =  Properties.Resources.Green;
                    break;
                case "Red":
                    imagenSeleccionada = Properties.Resources.Red;
                    break;
                case "Orange":
                    imagenSeleccionada = Properties.Resources.Orange;
                    break;
                case "Yellow":
                    imagenSeleccionada = Properties.Resources.Yellow;
                    break;
                case "Blue":
                    imagenSeleccionada = Properties.Resources.Blue;
                    break;
                case "DeepSkyBlue":
                    imagenSeleccionada = Properties.Resources.DeepSkyBlue;
                    break;
                case "DeepPink":
                    imagenSeleccionada = Properties.Resources.DeepPink;
                    break;
                case "Pink":
                    imagenSeleccionada = Properties.Resources.Pink;
                    break;
                case "Purple":
                    imagenSeleccionada = Properties.Resources.Purple;
                    break;
                case "White":
                    imagenSeleccionada = Properties.Resources.White;
                    break;
                case "Gray":
                    imagenSeleccionada = Properties.Resources.Gray;
                    break;
                case "Black":
                    imagenSeleccionada = Properties.Resources.Black;
                    break;
                default:
                    imagenSeleccionada = Properties.Resources.Black;
                    break;
            }
            return imagenSeleccionada;
        }
    }
}
