using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudiantes
{
    class Program
    {
        static List<Estudiante> clase = new List<Estudiante>();
        static string input(string label)
        {
            Console.WriteLine($"Ingrese {label}: ");
            return Console.ReadLine();
        }
        static void textMenu()
        {
            Console.WriteLine("Menu Principal");
            Console.WriteLine("1.-Ingresar Estudiante");
            Console.WriteLine("2.-Eliminar Estudiante");
            Console.WriteLine("3.-Consultar Estudiante por CI");
            Console.WriteLine("4.-Consultar todo");
            Console.WriteLine("5.-Salir");
            Console.WriteLine("Ingrese una Opcion: ");
        }
        static void ingresar(List<Estudiante> clase)
        {            
            //Como List es un objeto el parametro es por referencia :D
            Console.WriteLine("Ingrese los datos del estudiante:\n");
            clase.Add(new Estudiante(input("nombre"),
                input("apellido"), input("CI"), input("telefono")));
            finalOpcion();
        }
        static void eliminar(List<Estudiante> clase)
        {
            Console.WriteLine("Eliminar Estudiante");
            //Removera todos los estudiantes con la cedula ingresada,
            //por lo que la cedula debe ser unica
            string ci = input("CI");            
            clase.RemoveAll(student => student.Ci.Equals(ci));
            finalOpcion();
        }        
        static void consultarTodo(List<Estudiante> clase)
        {
            Console.WriteLine("Consultar Estudiantes");
            foreach (var estudiante in clase)     
                Console.WriteLine(estudiante);
            finalOpcion();
        }
        static void consultarPorCi(List<Estudiante> clase)
        {
            Console.WriteLine("Consultar Estudiantes");
            string ci = input("CI");
            foreach (var estudiante in clase)
            {
                if (estudiante.Ci.Equals(ci))
                    Console.WriteLine(estudiante);
            }
            finalOpcion();
        }
        private static void finalOpcion()
        {
            Console.ReadKey();
            Console.Clear();
            menu();
        }

        static void menu()
        {            
            
            textMenu();
            int switch_on = Int32.Parse(Console.ReadLine());
            switch (switch_on)
            {                
                case 1:
                    ingresar(clase);
                    break;
                case 2:
                    eliminar(clase);
                    break;
                case 3:
                    consultarPorCi(clase);
                    break;
                case 4:
                    consultarTodo(clase);
                    break;
                case 5:                    
                    break;               
            }

        }
        static void Main(string[] args)
        {
            menu();
        }
    }
}
