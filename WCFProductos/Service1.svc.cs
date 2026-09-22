using System.Collections.Generic;
using System.Linq;

namespace WCFProductos
{
    public class Service1 : IService1
    {
        public List<Producto> ListarProductos()
        {
            return DataProducto.ObtenerProductos();
        }

        public Producto ObtenerProducto(int id)
        {
            return DataProducto.ObtenerProductos()
                .FirstOrDefault(p => p.Id == id);
        }
    }
}