using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class Locacao
    {
        public Locacao()
        {
            LbnossoNumeros = new HashSet<LocBoleto>();
        }

        public long LocacaoId { get; set; }
        public int? LcTaxaId { get; set; }
        public DateTime? LcDtGeracao { get; set; }
        public DateTime? LcDataIni { get; set; }
        public DateTime? LcDataFim { get; set; }
        public string? LcHorarioIni { get; set; }
        public string? LcHorarioFim { get; set; }
        public DateTime? LcDtVencimento { get; set; }
        /// <summary>
        /// Qtde de horas, dias ou meses de locação
        /// </summary>
        public int? LcUnidadesLocacao { get; set; }
        public decimal? LcVlrEmUffi { get; set; }
        public decimal? LcValorLocacao { get; set; }
        public string? LcCategoria { get; set; }
        public int? LcTipoPagto { get; set; }
        public int? LcAtividade { get; set; }
        public string? LcSituacao { get; set; }
        public long? LcContribId { get; set; }
        public int? LcAutorizacao { get; set; }
        public string? LcTecAutorizacao { get; set; }
        public string? LcTecUltAlt { get; set; }
        public DateTime? LcDtUltAlt { get; set; }
        public string? LcNossoNumeroTribuno { get; set; }

        public virtual LocAtividade? LcAtividadeNavigation { get; set; }
        public virtual Contribuinte? LcContrib { get; set; }
        public virtual LocTaxa? LcTaxa { get; set; }
        public virtual LocTipoPagto? LcTipoPagtoNavigation { get; set; }

        public virtual ICollection<LocBoleto> LbnossoNumeros { get; set; }
    }
}
