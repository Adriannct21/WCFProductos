using System.Runtime.Serialization;

namespace WCFProductos
{
    [DataContract]
    public class Producto
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Nombre { get; set; }

        [DataMember]
        public decimal Precio { get; set; }
    }
}