using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribProcCdum
    {
        public long ProcId { get; set; }
        public long CertidaoDaid { get; set; }
        public DateTime? ProcCertDataAjuiza { get; set; }
        public string? ProcCertObsAjuiza { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public string? UsuarioInclusao { get; set; }
        public string? UsuarioAlteracao { get; set; }

        public virtual TribProcProcesso Proc { get; set; } = null!;
    }
}
