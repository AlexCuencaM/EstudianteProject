using System.Collections.Generic;
using System.Linq;
namespace Estudiantes
{
    class PromedioAltoBajo : Promedio
    {
        public PromedioAltoBajo(Estudiante estudiante, List<double>lista):base(estudiante,lista)
        {            
        }
        public override double promedio()
        {
            Notas.Remove(notaMasBaja());
            return base.promedio();
        }

        public double notaMasBaja()
        {
            return Notas.Min();
        }
    }
}
