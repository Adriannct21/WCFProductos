using System;

namespace TestCliente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServicioProductos.Service1Client cliente =
                new ServicioProductos.Service1Client();

            // Consumir ListarProductos()
            Console.WriteLine("=== LISTA DE PRODUCTOS ===");

            var productos = cliente.ListarProductos();

            foreach (var producto in productos)
            {
                Console.WriteLine(
                    "Id: " + producto.Id +
                    " | Nombre: " + producto.Nombre +
                    " | Precio: S/ " + producto.Precio
                );
            }

            //Consumir ObtenerProducto(id)
            Console.WriteLine();
            Console.WriteLine("=== BUSCAR PRODUCTO POR ID ===");
            Console.Write("Ingrese el ID del producto: ");

            int id = int.Parse(Console.ReadLine());

            var productoEncontrado = cliente.ObtenerProducto(id);

            if (productoEncontrado != null)
            {
                Console.WriteLine();
                Console.WriteLine("=== PRODUCTO ENCONTRADO ===");
                Console.WriteLine("Id: " + productoEncontrado.Id);
                Console.WriteLine("Nombre: " + productoEncontrado.Nombre);
                Console.WriteLine("Precio: S/ " + productoEncontrado.Precio);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Producto no encontrado.");
            }

            // Cerrar conexión
            cliente.Close();

            Console.WriteLine();
            Console.WriteLine("Presiona una tecla para finalizar...");
            Console.ReadKey();
        }
    }
}