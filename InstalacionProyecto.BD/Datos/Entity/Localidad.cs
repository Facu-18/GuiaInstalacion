using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto2026.BD.Datos.Entity
{
    public class Localidad : EntityBase
    {
        public string Nombre { get; set; }
        public int IdEstado { get; set; }
        public Estado Estado { get; set; }
    }
}
