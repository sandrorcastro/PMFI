using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribFiscItensVistorium
{
    public int ItemVistId { get; set; }

    public string? ItemVistNome { get; set; }

    public int TipoVistId { get; set; }

    public string? ItemVistGeraNotificacao { get; set; }

    public short? ItemVistPrazo { get; set; }

    public long? Textoid { get; set; }

    public string? ItemVistVistoria { get; set; }

    public string? ItemVistTipoInformacaoAdicional { get; set; }

    public long? TextoAutoId { get; set; }

    public string? ItemVistNotaFiscal { get; set; }

    public virtual TribFiscTiposVistorium TipoVist { get; set; } = null!;

    public virtual ICollection<TribFiscAutoInfracoesItensVistorium> TribFiscAutoInfracoesItensVistoria { get; set; } = new List<TribFiscAutoInfracoesItensVistorium>();

    public virtual ICollection<TribFiscItensVistoriaTributo> TribFiscItensVistoriaTributos { get; set; } = new List<TribFiscItensVistoriaTributo>();

    public virtual ICollection<TribFiscNotificaco> TribFiscNotificacos { get; set; } = new List<TribFiscNotificaco>();

    public virtual ICollection<TribFiscVistoriaItensVistoriado> TribFiscVistoriaItensVistoriados { get; set; } = new List<TribFiscVistoriaItensVistoriado>();

    public virtual ICollection<TribLegislacaoComponente> LeiComps { get; set; } = new List<TribLegislacaoComponente>();
}
