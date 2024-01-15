using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase6
{
    public class Producto
    {
        protected int Id;
        protected string Descripcion;
        protected double Costo;
        protected double PrecioVenta;
        protected int Stock;
        protected int IdUsuario;
        private int idProducto;
        private int idVenta;
        private string comentarios;

        public Producto (int id) 
        {
            this.Id = 0;
            this.Costo = 0;
            this.Stock = 0;
            this.PrecioVenta = 0;
            this.IdUsuario = 0;
            this.Descripcion = string.Empty;
        }

        public Producto(int idProducto, int stock, int idVenta)
        {
            this.idProducto = idProducto;
            Stock = stock;
            this.idVenta = idVenta;
        }

        public Producto(int id, int idUsuario, string comentarios) : this(id)
        {
            IdUsuario = idUsuario;
            this.comentarios = comentarios;
        }

        public Producto(int id, string descripcion, double costo, double precioVenta, int stock, int idUsuario)
        {
            this.Id = id;
            this.Descripcion = descripcion;
            this.Costo = costo;
            this.PrecioVenta = precioVenta;
            this.Stock = stock;
            this.IdUsuario = idUsuario;
        }
    }
}
