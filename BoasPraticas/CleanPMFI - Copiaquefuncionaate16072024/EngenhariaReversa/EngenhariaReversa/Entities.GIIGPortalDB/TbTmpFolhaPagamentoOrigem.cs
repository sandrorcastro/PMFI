using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDB
{
    public partial class TbTmpFolhaPagamentoOrigem
    {
        public int? IdFonteDados { get; set; }
        public short? IdEmpresa { get; set; }
        public DateTime? DtExecucao { get; set; }
        public int? Ano { get; set; }
        public int? Mes { get; set; }
        public string? Secretaria { get; set; }
        public string? Lotacao { get; set; }
        public string? Cargo { get; set; }
        public decimal? Descontos { get; set; }
        public int? NumeroFuncionariosCargo { get; set; }
        public decimal? RemuneracaoBruta { get; set; }
        public decimal? RemuneracaoLiquida { get; set; }
    }
}
