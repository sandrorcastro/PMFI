using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribFiscFiscai
{
    public int FiscalId { get; set; }

    public string? FiscalNome { get; set; }

    public long? ServId { get; set; }

    public int? TipoFiscId { get; set; }

    public bool? FlExpedirOs { get; set; }

    public bool? FlSituacao { get; set; }

    public virtual Servidore? Serv { get; set; }

    public virtual TribFiscTipoFiscal? TipoFisc { get; set; }

    public virtual ICollection<TribFiscApreenso> TribFiscApreensos { get; set; } = new List<TribFiscApreenso>();

    public virtual ICollection<TribFiscAutoInfraco> TribFiscAutoInfracos { get; set; } = new List<TribFiscAutoInfraco>();

    public virtual ICollection<TribFiscEmbargo> TribFiscEmbargoes { get; set; } = new List<TribFiscEmbargo>();

    public virtual ICollection<TribFiscInterdico> TribFiscInterdicos { get; set; } = new List<TribFiscInterdico>();

    public virtual ICollection<TribFiscNotificaco> TribFiscNotificacos { get; set; } = new List<TribFiscNotificaco>();

    public virtual ICollection<TribFiscOrdemServicoOcorrencia> TribFiscOrdemServicoOcorrencia { get; set; } = new List<TribFiscOrdemServicoOcorrencia>();

    public virtual ICollection<TribFiscProcedimento> TribFiscProcedimentos { get; set; } = new List<TribFiscProcedimento>();

    public virtual ICollection<TribFiscVistoria> TribFiscVistoria { get; set; } = new List<TribFiscVistoria>();
}
