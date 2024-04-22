using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribEmpresasSimplesMov
    {
        public int IdsimplesMov { get; set; }
        public long? EmprCmc { get; set; }
        public DateTime? Data { get; set; }
        public string? Situacao { get; set; }
        public string? Motivo { get; set; }
        public string? Tipo { get; set; }

        public virtual TribEmpresa? EmprCmcNavigation { get; set; }
    }
}
