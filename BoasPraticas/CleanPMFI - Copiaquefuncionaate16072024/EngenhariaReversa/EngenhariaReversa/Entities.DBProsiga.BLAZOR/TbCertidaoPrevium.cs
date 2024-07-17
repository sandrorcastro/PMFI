using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TbCertidaoPrevium
    {
        public long IdPrevia { get; set; }
        public int? LivroDaid { get; set; }
        public string? DsErro { get; set; }
        public DateTime? DtInclusao { get; set; }
        public string? DsLogin { get; set; }
        public DateTime? DtProcessamento { get; set; }
        public bool? FlGerarCertidao { get; set; }
        public bool? FlProcessado { get; set; }
        public string? NrAgrupar { get; set; }
        public string? TpAgrupar { get; set; }
        public byte? TpCadastro { get; set; }
        public string? Ordem { get; set; }
    }
}
