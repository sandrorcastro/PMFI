using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribAlvaraRenovacaoDivida
    {
        public long AlvaraId { get; set; }
        public long DivEmpId { get; set; }
        public string? UsuarioInclusao { get; set; }
        public DateTime? DataInclusao { get; set; }

        public virtual TribAlvaraEmpresa Alvara { get; set; } = null!;
        public virtual TribDividasEmpresa DivEmp { get; set; } = null!;
    }
}
