using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea___Pilares_POO.Clases
{
    public class Producto
    {
        public string nombre { get; set; }
        public double precio { get; set; }
        public string categoria { get; set; }

        public Producto(string nombre, double precio, string categoria)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.categoria = categoria;
        }
    }
}
