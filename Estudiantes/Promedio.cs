using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudiantes
{
    class Promedio
    {
        public List<double> Notas { get; set; }
        public Estudiante Estudiante { get; set; }        
        public Promedio(Estudiante estudiante, List<double> notas)        
        {
            Estudiante = estudiante;
            Notas = notas;        
        }                
        public virtual double promedio()
        {
            return Notas.Average();
        }        
        public string condicionEstudiante()
        {

            return Notas.Average() < 3 ?  "Reprobado": (Notas.Average() > 3 && Notas.Average() <= 7 ? "Recuperacion": "Aprobado");
        }

    }
}
