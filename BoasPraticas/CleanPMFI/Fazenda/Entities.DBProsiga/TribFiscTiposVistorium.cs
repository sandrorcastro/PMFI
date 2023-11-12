using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribFiscTiposVistorium
{
    public int TipoVistId { get; set; }

    public string? TipoVistNome { get; set; }

    public int? DivId { get; set; }

    public string? TipoVistNf { get; set; }

    public virtual Diviso? Div { get; set; }

    public virtual ICollection<TribFiscItensVistorium> TribFiscItensVistoria { get; set; } = new List<TribFiscItensVistorium>();

    public virtual ICollection<TribFiscVistoria> TribFiscVistoria { get; set; } = new List<TribFiscVistoria>();

    public virtual ICollection<TribFiscAtributo> IdAtributos { get; set; } = new List<TribFiscAtributo>();

    public virtual ICollection<TribFiscTipoFiscal> TipoFiscs { get; set; } = new List<TribFiscTipoFiscal>();
}
