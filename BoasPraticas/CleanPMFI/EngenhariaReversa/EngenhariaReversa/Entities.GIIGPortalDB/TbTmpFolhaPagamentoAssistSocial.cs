using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDB
{
    public partial class TbTmpFolhaPagamentoAssistSocial
    {
        public int? IdFonteDados { get; set; }
        public short? IdEmpresa { get; set; }
        public DateTime? DtExecucao { get; set; }
        public string? Nome { get; set; }
        public long? Cpf { get; set; }
        public int? Matricula { get; set; }
        public string? Funcao { get; set; }
        public string? Lotacao { get; set; }
        public int? MesCompetencia { get; set; }
        public int? AnoCompetencia { get; set; }
        public decimal? Vencimentos { get; set; }
        public int? Mes { get; set; }
        public string? Fonte { get; set; }
        public string? BlocoPrograma { get; set; }
        public string? CdProvento { get; set; }
    }
}
