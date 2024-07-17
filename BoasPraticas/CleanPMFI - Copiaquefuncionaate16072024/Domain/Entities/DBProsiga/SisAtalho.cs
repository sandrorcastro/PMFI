using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class SisAtalho
    {
        public int Idatalho { get; set; }
        public string? UsuId { get; set; }
        public string? FormIdlocal { get; set; }
        public string? FormIdatalho { get; set; }
        public string? FormAcessKey { get; set; }

        public virtual Formulario? FormIdatalhoNavigation { get; set; }
        public virtual Formulario? FormIdlocalNavigation { get; set; }
        public virtual Usuario? Usu { get; set; }
    }
}
