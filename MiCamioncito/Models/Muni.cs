using System;
using System.Collections.Generic;

#nullable disable

namespace MiCamioncito.Models
{
    public partial class Muni
    {
        public int IdMunicipio { get; set; }
        public int IdDepartamento { get; set; }
        public string Nombre { get; set; }

        public virtual Departament IdDepartamentoNavigation { get; set; }
    }
}
