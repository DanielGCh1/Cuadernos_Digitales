using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace CuadernosDigitales
{
    public class Cuaderno
    {
        private List<Nota> notas;
        private List<Categoria> categorias;

        public Cuaderno()
        {
            notas = new List<Nota>();
            categorias = new List<Categoria>();
        }

        public string Nombre
        {
            get;
            set;
        }

        public Color Color
        {
            get;
            set;
        }

        public int Orden
        {
            get;
            set;
        }
        public int IndiceCuaderno
        {
            get;
            set;
        }
        public Bitmap Imagen
        {
            get;
            set;
        }
        public void agregarCategoria(Categoria cat)
        {
            categorias.Add(cat);
        }

        public void agregarNota(Nota not)
        {
            notas.Add(not);
        }

        public List<Categoria> getListaDeCategorias()
        {
            return categorias;
        }
        public List<Nota> getListaDeNotas()
        {
            return notas;
        }

        public int BuscarNota(string name)
        {
            foreach(Nota nota in notas)
            {
                if(nota.Titulo == name)
                {
                    return notas.IndexOf(nota);
                }
            }

            return -1;
        }
        public Nota BuscarNota(string name, bool sinNumero)
        {
            foreach (Nota nota in notas)
            {
                if (nota.Titulo == name)
                {
                    return nota;
                }
            }

            return null;
        }
        public void EliminarNota(Nota nota)
        {
            notas.Remove(nota);
        }

        public void ModificarNota(int num, Nota nota)
        {
            notas[num] = nota;
        }
        public string ObtenerNombre(int num)
        {
            return notas[num].Titulo;
        }

        public List<Nota> getNotasOcultas()
        {
            List<Nota> notasOcultas = new List<Nota>();
            foreach (Nota nota in notas)
            {
                if (nota.Privacidad)
                {
                    notasOcultas.Add(nota);
                }
                
            }
            return notasOcultas;
        }
        public int ObtenerIndiceDeLaNotaEnBaseDeDatos(int posicionNota)
        {
            int indiceDeLaNotaEnBaseDeDatos = -1;

            foreach (Nota nota in notas)
            {
                if (nota.Orden == posicionNota)
                {
                    indiceDeLaNotaEnBaseDeDatos = nota.IndiceNota;
                }
            }

            return indiceDeLaNotaEnBaseDeDatos;
        }
    }
}