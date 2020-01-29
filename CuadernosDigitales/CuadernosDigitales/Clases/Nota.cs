using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CuadernosDigitales
{
    public class Nota
    {
        public string Categoria
        {
            get;
            set;
        }

        public System.Drawing.Color Color
        {
            get;
            set;
        }
        public int TamanoLetra
        {
            get;
            set;
        }

        public System.Drawing.Font Fuente
        {
            get;
            set;
        }

        public System.Drawing.Color ColorDeLetra
        {
            get;
            set;
        }

        public DateTime FechaDeCreacion
        {
            get;
            set;
        }

        public DateTime FechaDeModificacion
        {
            get;
            set;
        }

        public int Orden
        {
            get;
            set;
        }

        public bool Privacidad
        {
            get;
            set;
        }

        public string Titulo
        {
            get;
            set;
        
        }

        public string Contenido
        {
            get;
            set;
        }
        public int IndiceNota
        {
            get;
            set;
        }
    }
}