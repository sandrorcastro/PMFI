using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDB
{
    public partial class TbTmpLicitacoesOrigem
    {
        public int? IdFonteDados { get; set; }
        public short? IdEmpresa { get; set; }
        public DateTime? DtExecucao { get; set; }
        public int? NrLicitacao { get; set; }
        public short? NrAno { get; set; }
        public DateTime? DataAbertura { get; set; }
        public string? Justificativa { get; set; }
        public string? TipoEstagioLicitacao { get; set; }
        public string? TipoModalidade { get; set; }
        public decimal? ValorTotal { get; set; }
    }
}
