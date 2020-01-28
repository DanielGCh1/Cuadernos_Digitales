using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuadernosDigitales.Forms
{
    public partial class UCCuadernoDigital : UserControl
    {
        private CuadernosMenu inicio;
        public UCCuadernoDigital(CuadernosMenu inicio)
        {
            InitializeComponent();
            this.inicio = inicio;
        }
        public string nombreDeCuaderno
        {
            get
            {
                return nombreCuaderno.Text;
            }
            set
            {
                nombreCuaderno.Text = value;
            }
           
        }
        public Image picture
        {
            get
            {
                return CuadernoPictureBox.Image;
            }
            set
            {
                this.CuadernoPictureBox.Image = value;
            }
        }
        public String namePicture
        {
            get
            {
                return CuadernoPictureBox.Name;
            }
            set
            {
                this.CuadernoPictureBox.Name = value;
            }
        }

        private void CuadernoPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                inicio.CuadernoPicture_DoubleClick(sender, e);
            }
            else
            {
                inicio.CuadernoPictureBox_Click(sender, e);
            }
        }
    }
}
