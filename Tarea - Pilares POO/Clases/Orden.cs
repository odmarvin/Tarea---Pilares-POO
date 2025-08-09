using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea___Pilares_POO.Clases
{
    public class Orden
    {
        public Cliente cliente { get; set; }
        public Carrito carrito { get; set; }
        public bool confirmada { get; set; }

        public Orden(Cliente cliente, Carrito carrito)
        {
            this.cliente = cliente;
            this.carrito = carrito;
            this.confirmada = false;
        }

        public void MostrarResumen()
        {
            Console.WriteLine($"Cliente: {cliente.nombre}");
            Console.WriteLine("Productos en la orden:");
            foreach (var producto in carrito.ListarProductos())
            {
                Console.WriteLine($"-{producto.nombre}  Precio: Q{producto.precio}");
            }
            Console.WriteLine($"Total con impuesto: {carrito.CalcularTotalConImpuesto():C}");
        }

        public void Confirmar()
        {
            this.confirmada = true;
            Console.WriteLine("Orden confirmada. Gracias por su compra.");
        }

        public void Cancelar()
        {
            this.confirmada = false;
            Console.WriteLine("Orden cancelada.");
        }
    }
}
