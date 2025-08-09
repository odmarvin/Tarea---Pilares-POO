// See https://aka.ms/new-console-template for more information
using Tarea___Pilares_POO.Clases;
class Program
{
    static void Main()
    {
 
        Producto producto1 = new ProductoFisico("Camiseta", 150.0, "Ropa", 0.2);
        Producto producto2 = new ProductoDigital("Curso Online", 250.0, "Educación", "Video");

        // Crear carrito y agregar productos
        Carrito carrito = new Carrito();
        carrito.AgregarProducto(producto1);
        carrito.AgregarProducto(producto2);

        // Crear cliente
        Cliente cliente = new Cliente("Marvin Oliva", "marvin@example.com");

        // Crear orden con cliente y carrito
        Orden orden = new Orden(cliente, carrito);

        // Mostrar resumen de la orden
        orden.MostrarResumen();

        // Confirmar la orden
        orden.Confirmar();

        // Intentar cancelar la orden
        orden.Cancelar();

        // Mostrar resumen final después de cancelar
        Console.WriteLine("Estado final de la orden:");
        Console.WriteLine($"Orden confirmada: {orden.confirmada}");
    }
}