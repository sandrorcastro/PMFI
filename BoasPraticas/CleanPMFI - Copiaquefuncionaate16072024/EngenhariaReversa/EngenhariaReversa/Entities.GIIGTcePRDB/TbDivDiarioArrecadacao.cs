using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGTcePRDB
{
    public partial class TbDivDiarioArrecadacao
    {
        public TbDivDiarioArrecadacao()
        {
            TbDivDiarioArrecadacaoEstornos = new HashSet<TbDivDiarioArrecadacaoEstorno>();
        }

        public int IdArrecadacao { get; set; }
        public int? IdLancamento { get; set; }
        public int? NrArrecadacao { get; set; }
        public short? NrAnoArrecadacao { get; set; }
        public string? CdReceita { get; set; }
        public short? NrAnoPlanoContas { get; set; }
        public short? IdTpOrigemReceita { get; set; }
        public string? TpDocContribuinte { get; set; }
        public string? NrDocContribuinte { get; set; }
        public short? IdTpArrecadacao { get; set; }
        public DateTime? DtArrecadacao { get; set; }
        public decimal? VlArrecadacao { get; set; }
        public string? DsLoginInclusao { get; set; }
        public int IdLctoComposicao { get; set; }

        public virtual TbDivLancamentoCredito? IdLancamentoNavigation { get; set; }
        public virtual TbGerTipoArrecadacao? IdTpArrecadacaoNavigation { get; set; }
        public virtual TbGerTipoOrigemReceitum? IdTpOrigemReceitaNavigation { get; set; }
        public virtual ICollection<TbDivDiarioArrecadacaoEstorno> TbDivDiarioArrecadacaoEstornos { get; set; }
    }
}
