using System.Collections.Generic;

namespace WCFProductos
{
    public class DataProducto
    {
        public static List<Producto> ObtenerProductos()
        {
            return new List<Producto>
            {
                new Producto { Id = 1, Nombre = "Laptop", Precio = 2500.00m },
                new Producto { Id = 2, Nombre = "Mouse", Precio = 80.00m },
                new Producto { Id = 3, Nombre = "Teclado", Precio = 150.00m },
                new Producto { Id = 4, Nombre = "Monitor", Precio = 900.00m },
                new Producto { Id = 5, Nombre = "Audifonos", Precio = 200.00m }
            };
        }
    }
}