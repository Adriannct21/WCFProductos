using System.Collections.Generic;
using System.ServiceModel;

namespace WCFProductos
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        List<Producto> ListarProductos();

        [OperationContract]
        Producto ObtenerProducto(int id);
    }
}