using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDB
{
    public partial class TbTmpReceitasCovid
    {
        public int? IdFonteDados { get; set; }
        public short? IdEmpresa { get; set; }
        public DateTime? DtExecucao { get; set; }
        public short? IdEmpresaReceita { get; set; }
        public int? IdMovReceita { get; set; }
        public string? DsContaContabil { get; set; }
        public DateTime? DtLancamento { get; set; }
        public string? DsHistoricoMovimento { get; set; }
        public string? DsRecurso { get; set; }
        public string? CdFonte { get; set; }
        public string? DsFonte { get; set; }
        public decimal? VlLancadoFonte { get; set; }
        public string? DsTipoOperacao { get; set; }
        public string? DsOrgaoRepassador { get; set; }
    }
}
