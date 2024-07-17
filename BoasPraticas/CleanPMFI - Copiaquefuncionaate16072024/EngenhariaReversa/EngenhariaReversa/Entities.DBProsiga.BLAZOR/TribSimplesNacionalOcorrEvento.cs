using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribSimplesNacionalOcorrEvento
    {
        public int OcorrId { get; set; }
        public DateTime OcorrData { get; set; }
        public byte? OcorrNatEvento { get; set; }
        public string? OcorrObs { get; set; }
        public string? OcorrNumProcJudicial { get; set; }
        public string? OcorrNumProcAdmin { get; set; }
        public int? OcorrCodUa { get; set; }
        public string? OcorrCodUf { get; set; }
        public short? OcorrCodMun { get; set; }
        public short SneventoId { get; set; }
        public long EmprCmc { get; set; }
        public string UsuarioInclusao { get; set; } = null!;
        public DateTime DataInclusao { get; set; }
        public string? OcorrValorAntigo { get; set; }

        public virtual TribEmpresa EmprCmcNavigation { get; set; } = null!;
        public virtual TribSimplesNacionalEvento Snevento { get; set; } = null!;
    }
}
