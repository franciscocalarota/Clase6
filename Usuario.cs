using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase6
{
    public class Usuario
    {
        protected int _id;
        protected string _nombre;
        protected string _apellido;
        protected string _nombreUsuario;
        protected long _contrasena;
        protected string _mail;

    
        public Usuario(int id, string nombre, string apellido, string nombreUsuario, long contrasena, string mail)
        {
            this._id = id;
            this._nombre = nombre;
            this._apellido = apellido;
            this._nombreUsuario = nombreUsuario;
            this._contrasena = contrasena;
            this._mail = mail;
        }

        public int Id { get { return _id; } set { _id = value; } }  
        public string Nombre { get { return _nombre; } set { _nombre = value; } }
        public string Apellido { get { return _apellido; } set { _apellido = value; } }
        public string NombreUsuario { get { return _nombreUsuario; } set { _nombreUsuario = value; } }
        public long Contrasena { get { return _contrasena; } set { _contrasena = value; } }
        public string Mail { get { return _mail; } set { _mail = value; } }


    }

    
    
}
