using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tarea___Pilares_POO.Clases
{
    public class ProductoFisico : Producto
    {
        public double peso { get; set; }

        public ProductoFisico(string nombre, double precio, string categoria, double peso)
            : base(nombre, precio, categoria)
        {
            this.peso = peso;
        }

        public void CalcularCostoEnvio()
        {
            double costoEnvio = this.peso * 15;
            System.Console.WriteLine($"Costo de envío para: {costoEnvio}");
        }
    }
}
