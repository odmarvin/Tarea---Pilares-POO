using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tarea___Pilares_POO.Clases
{
    public class ProductoDigital : Producto
    {
        public string tipo { get; set; }

        public ProductoDigital(string nombre, double precio, string categoria, string tipo)
            : base(nombre, precio, categoria)
        {
            this.tipo = tipo;
        }

        public void Descargar()
        {
            System.Console.WriteLine($"Descargando {nombre} en formato {tipo}");
        }
    }
}
