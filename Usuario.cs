using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase6
{
    public class Usuario
    {
        protected int Id;
        protected string Nombre;
        protected string Apellido;
        protected string NombreUsuario;
        protected long Contraseña;
        protected string Mail;

        public Usuario() 
        {
            this.Id = 0;
            this.Nombre = string.Empty;
            this.Apellido = string.Empty;
            this.NombreUsuario = string.Empty;
            this.Mail = string.Empty;
            this.Contraseña = 0;
        }

        public Usuario(int id, string nombre, string apellido, string nombreUsuario, long contraseña, string mail)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.NombreUsuario = nombreUsuario;
            this.Contraseña = contraseña;
            this.Mail = mail;
        }
    }

    
    
}
