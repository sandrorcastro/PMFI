using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class Permisso
    {
        public string PrmIdform { get; set; } = null!;
        public string PrmIdusuario { get; set; } = null!;
        public string? PrmInclusao { get; set; }
        public string? PrmAlteracao { get; set; }
        public string? PrmRemocao { get; set; }
        public string? PrmRelatorios { get; set; }
        public string? PrmConsultas { get; set; }

        public virtual Formulario PrmIdformNavigation { get; set; } = null!;
        public virtual Usuario PrmIdusuarioNavigation { get; set; } = null!;
    }
}
