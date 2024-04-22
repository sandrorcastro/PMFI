using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribProcPermissaoTipoProcesso
    {
        public string UsuId { get; set; } = null!;
        public int ProcTipoProcId { get; set; }
    }
}
