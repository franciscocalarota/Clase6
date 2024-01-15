using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase6
{
    public class Venta : Producto
    {
        protected new int IdUsuario;

        public Venta(int Id, int IdUsuario, string Comentarios) 
            : base(Id,
                   IdUsuario,
                   Comentarios)
        {
            this.IdUsuario = IdUsuario;
        }
    }
}
