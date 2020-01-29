using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuadernosDigitales
{
    public class ArchivoHistorial
    {
         
        public Historial Historial { get; set; }

        public ArchivoHistorial()
        {
            Historial = new Historial();
        }
        public string CrearHistorialVisitaFormulario(string rutaBase) { 
            string path = $"{Historial.Usuario} {DateTime.Now.ToString()}.csv";
            path= path.Replace("/", "_");
            path= path.Replace(":", "_");
            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                //var line =  $"Fecha y hora: {Historial.FechaYHora}, Nombre de usuario: {Historial.Usuario}, Formulario al que ingreso el usuario: {Historial.Formulario}, Acción hecha por el usuario: {Historial.Accion}, Informacion adicional: {Historial.InformacionAdicional}";
                //streamWriter.WriteLine(line);
                streamWriter.Flush();  
                return path;
            }
        }
        public string CrearHistorialEdicionObjeto(string rutaBase)
        {
            string path = $"{Historial.Usuario} {DateTime.Now.ToString()}.csv";
            path = path.Replace("/", "_");
            path = path.Replace(":", "_");
            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                var line = $"Fecha y hora: {Historial.FechaYHora}, Nombre de usuario: {Historial.Usuario}, Indice del objeto modificado: {Historial.Objeto}, Acción hecha por el usuario: {Historial.Accion}, Informacion adicional: {Historial.InformacionAdicional}";
                streamWriter.WriteLine(line);
                streamWriter.Flush();
                return path;
            }
        }
        public string CrearHistorialBusquedaObjeto(string rutaBase)
        {
            string path = $"{Historial.Usuario} {DateTime.Now.ToString()}.csv";
            path = path.Replace("/", "_");
            path = path.Replace(":", "_");
            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                var line = $"Fecha y hora: {Historial.FechaYHora}, Nombre de usuario: {Historial.Usuario}, Acción echa por el usuario: {Historial.Accion}, Informacion adicional: {Historial.InformacionAdicional}";
                streamWriter.WriteLine(line);
                streamWriter.Flush();
                return path;
            }
        }
    }
}
