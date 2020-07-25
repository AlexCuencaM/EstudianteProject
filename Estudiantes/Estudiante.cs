using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudiantes
{
    class Estudiante
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Ci { get; set; }
        public string Telefono { get; set; }

        public Estudiante(string nombre,string apellido, string ci, string telefono)
        {
            Nombre = nombre;
            Apellido = apellido;
            Ci = ci;
            Telefono = telefono;
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre}\nApellido: {Apellido}\nCI: {Ci}\nTeléfono: {Telefono}";
        }
    }
}
