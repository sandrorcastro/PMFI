using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribProcTestemunha
    {
        public long ProcId { get; set; }
        public long ConId { get; set; }
        public string? ProcTestPrincipal { get; set; }
        public string? ProcTestObs { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public string? UsuarioInclusao { get; set; }
        public string? UsuarioAlteracao { get; set; }

        public virtual TribProcProcesso Proc { get; set; } = null!;
    }
}
