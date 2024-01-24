﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Clase6
{
    public class Venta 
    {
        private int _id;
        private string _comentarios;
        private int _idUsuario;

        public Venta() 
        {}

        public Venta(int id, string comentarios, int idUsuario)
        {
            this._id = id;
            this._comentarios = comentarios;
            this._idUsuario = idUsuario;
        }

        public int Id { get { return _id; } set { _id = value; } }

        public string Comentarios { get { return _comentarios; } set { _comentarios = value; } }

        public int IdUsuario { get { return _idUsuario; } set { _idUsuario = value; } } 
    }
}
