using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribFiscFiscai
    {
        public TribFiscFiscai()
        {
            TribFiscApreensos = new HashSet<TribFiscApreenso>();
            TribFiscAutoInfracos = new HashSet<TribFiscAutoInfraco>();
            TribFiscEmbargoes = new HashSet<TribFiscEmbargo>();
            TribFiscInterdicos = new HashSet<TribFiscInterdico>();
            TribFiscNotificacos = new HashSet<TribFiscNotificaco>();
            TribFiscOrdemServicoOcorrencia = new HashSet<TribFiscOrdemServicoOcorrencia>();
            TribFiscProcedimentos = new HashSet<TribFiscProcedimento>();
            TribFiscVistoria = new HashSet<TribFiscVistoria>();
        }

        public int FiscalId { get; set; }
        public string? FiscalNome { get; set; }
        public long? ServId { get; set; }
        public int? TipoFiscId { get; set; }
        public bool? FlExpedirOs { get; set; }
        public bool? FlSituacao { get; set; }

        public virtual Servidore? Serv { get; set; }
        public virtual TribFiscTipoFiscal? TipoFisc { get; set; }
        public virtual ICollection<TribFiscApreenso> TribFiscApreensos { get; set; }
        public virtual ICollection<TribFiscAutoInfraco> TribFiscAutoInfracos { get; set; }
        public virtual ICollection<TribFiscEmbargo> TribFiscEmbargoes { get; set; }
        public virtual ICollection<TribFiscInterdico> TribFiscInterdicos { get; set; }
        public virtual ICollection<TribFiscNotificaco> TribFiscNotificacos { get; set; }
        public virtual ICollection<TribFiscOrdemServicoOcorrencia> TribFiscOrdemServicoOcorrencia { get; set; }
        public virtual ICollection<TribFiscProcedimento> TribFiscProcedimentos { get; set; }
        public virtual ICollection<TribFiscVistoria> TribFiscVistoria { get; set; }
    }
}
