using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Clase6
{
    public class ProductoVendido
    {
        private int ID;
        private int IDPRODUCTO;
        private int STOCK;
        private int IVENTA;



        private ProductoVendido(
            int id,
            int idproducto,
            int stock,
            int venta)
        {
            this.ID = id;
            this.IDPRODUCTO = idproducto;
            this.STOCK = stock;
            this.IVENTA = venta;
        }
        public int Id { get { return ID; } set { ID = value; } }
        public int idProducto { get { return IDPRODUCTO; } set { IDPRODUCTO = value; } }

        public int Stock { get { return STOCK; } set { STOCK = value; } }

        public int idVenta { get { return IVENTA; } set { IVENTA = value; } }
    }
}
