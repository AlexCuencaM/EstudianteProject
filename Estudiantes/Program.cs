using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clientes
{
    class Program
    {
        static Empleado e;
        static Cliente c;       
        static Compras promedio;
        static string input(string label)
        {
            Console.WriteLine($"Ingrese {label}: ");
            return Console.ReadLine();
        }
        static List<double> compras = new List<double>();
        static void textMenu()
        {
            Console.WriteLine("Menu Principal");
            Console.WriteLine("1.-Ingresar clientes");
            Console.WriteLine("2.-Ingresar Empleado");
            Console.WriteLine("3.-Ingresar Compra");                        
            Console.WriteLine("4.-Ver reporte");
            Console.WriteLine("5.-Salir");
            Console.WriteLine("Ingrese una Opcion: ");
        }

        static void ingresar(out Cliente c)
        {            
            //Como List es un objeto el parametro es por referencia :D
            Console.WriteLine("Ingrese los datos del Cliente:\n");
            c = new Cliente(input("nombre"),
                input("apellido"), input("CI"), input("telefono"));
            finalOpcion();
        }     
        static void ingresarEmpleado(out Empleado empleado)
        {
            Console.WriteLine("Ingrese los datos del Empleado:\n");
            empleado = new Empleado(input("nombre"),
                input("apellido"), input("CI"), input("telefono"));
            finalOpcion();
        }
        static void IngresarCompra(Cliente e)
        {                                                
            compras.Add(Double.Parse(input("Compra")));
            finalOpcion();
        }
        static void reporte(out Compras p)
        {
            p = new Compras(c,e, compras);
            Console.WriteLine(p);
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
                    ingresar(out c);
                    break;
                case 2:
                    ingresarEmpleado(out e);
                    break;
                case 3:                    
                    IngresarCompra(c);
                    break;
                case 4:
                    reporte(out promedio);
                    break;
                case 5:
                    break;
                default:
                    Console.WriteLine("Ingrese un numero valido");
                    break;
            }
        }        
        static void Main(string[] args)
        {
            menu();         
        }
    }
}
