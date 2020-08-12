using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clientes
{
    class Empleado : Persona
    {
        public Empleado(string nombre, string apellido, string ci, string telefono) : base(nombre, apellido, ci, telefono)
        {

        }
    }
}
