using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase6
{
    public class ProductoVendido : Producto
    {
        protected int id;

        public ProductoVendido(int id, int IdProducto, int Stock, int IdVenta)  
            : base(IdProducto,
                   Stock,
                   IdVenta)
        {
            this.id = id;
        }
    }
}
