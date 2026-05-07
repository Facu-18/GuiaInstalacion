using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto2026.BD.Datos.Entity
{
    public class PersonaDomicilio : EntityBase          
    {
        public int IdPersona { get; set; }
        public Persona Persona { get; set; }

        public int IdDomicilio { get; set; }
        public Domiclio Domicilio { get; set; }
    }
}
