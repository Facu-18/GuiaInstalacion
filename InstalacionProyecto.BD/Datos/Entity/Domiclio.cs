using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto2026.BD.Datos.Entity
{
    public class Domiclio : EntityBase
    {
        public string Calle { get; set; }
        public string Numero { get; set; }
        public int IdLocalida { get; set; }
        public Localidad Localidad { get; set; }
    }
}
