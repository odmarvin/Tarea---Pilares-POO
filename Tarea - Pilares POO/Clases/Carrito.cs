using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea___Pilares_POO.Clases
{
    public class Carrito
    {
        private List<Producto> productos = new List<Producto>();
        private const double impuesto = 0.15;

        public void AgregarProducto(Producto producto)
        {
            productos.Add(producto);
        }

        public void EliminarProducto(Producto producto)
        {
            productos.Remove(producto);
        }

        public List<Producto> ListarProductos()
        {
            return productos;
        }

        public double CalcularTotalConImpuesto()
        {
            double subtotal = productos.Sum(p => p.precio);
            return subtotal + (subtotal * impuesto);
        }
    }
}
