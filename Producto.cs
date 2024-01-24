using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase6
{
    public class Producto
    {
        protected int _id;
        protected string _descripcion;
        protected double _costo;
        protected double _precioVenta;
        protected int _stock;
        protected int _idUsuario;
       

        public Producto(int id, string descripcion, double costo,
           double precioVenta, int stock, int idUsuario)
        {
            _id = id;
            _descripcion = descripcion;
            _costo = costo;
            _precioVenta = precioVenta;
            _stock = stock;
            _idUsuario = idUsuario;
        }

        public int Id { get => _id; set => _id = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public double Costo { get => _costo; set => _costo = value; }
        public double PrecioVenta { get => _precioVenta; set => _precioVenta = value; }
        public int Stock { get => _stock; set => _stock = value; }
        public int IdUsuario { get => _idUsuario; set => _idUsuario = value; }

        public string MostrarDatos(StringBuilder sb)
        {
            sb.AppendLine($"Producto: {this.Descripcion} \n");
            sb.AppendLine($"Stock: {this.Stock} \n");
            sb.AppendLine($"Precio de Venta: {this.PrecioVenta} \n");
            return sb.ToString();
        }
    }
}
