using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbOrcDescentralizacoesCreditosDotaco
    {
        public int IdDescentralizacaoDotacao { get; set; }
        public int IdDescentralizacao { get; set; }
        public int IdDotacao { get; set; }
        public int? IdSubAcaoTarefa { get; set; }
        public string? CdOrgao { get; set; }
        public string? CdUnidade { get; set; }
        public decimal? VlOperacao { get; set; }
        public int? IdDotacaoDesc { get; set; }
        public int? IdSubAcaoTarefaDesc { get; set; }

        public virtual TbOrcDescentralizacoesCredito IdDescentralizacaoNavigation { get; set; } = null!;
        public virtual TbOrcDotaco IdDotacaoNavigation { get; set; } = null!;
    }
}
