using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class SaudeAtendimentoDadosClinico
    {
        public long ClinicId { get; set; }
        public long AtendId { get; set; }
        public string? CdCid { get; set; }
        public string? ClinicDisgnostico { get; set; }
        public string? ClinicHora { get; set; }
        public string? UsuarioInclusao { get; set; }
        public DateTime? DataInclusao { get; set; }

        public virtual SaudeAtendimento Atend { get; set; } = null!;
    }
}
