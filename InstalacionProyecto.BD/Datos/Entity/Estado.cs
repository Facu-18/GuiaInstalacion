using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto2026.BD.Datos.Entity
{
    public class Estado : EntityBase
    {
        public string Nombre { get; set; }
        public int IdPais { get; set; }
        public Pais Pais { get; set; }
    }
}
