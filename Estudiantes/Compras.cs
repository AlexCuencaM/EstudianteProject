using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clientes
{
    class Compras
    {
        public List<double> Compra { get; set; }
        public Cliente Cliente { get; set; } 
        public Empleado Empleado { get; set; }
        public double Descuento { get; set; }
        public Compras(Cliente Cliente,Empleado empleado, List<double> Compra)        
        {
            this.Cliente = Cliente;
            this.Compra = Compra;
            this.Empleado = empleado;
            Descuento = condicionCliente();
        }              
        public virtual double promedio()
        {
            return Compra.Average();
        }        
        public double condicionCliente()
        {
            return Compra.Average() < 1000 ?  10: (Compra.Average() >= 1000 && Compra.Average() < 1500 ? 15: 20);
        }
        public override string ToString()
        {
            string result = "Compras:\n";
            foreach (var item in Compra)            
                result += $"{item}\n";            
            return $"Nombre del cliente:{Cliente.Nombre}\nNombre del empleado:{Empleado.Nombre}" +
                $"\n{result}\nPromedio de compras: {promedio()}\nDescuento: {Descuento}%";
        }

    }
}
