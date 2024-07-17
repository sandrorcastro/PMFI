using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribTiposBaseCalculo
{
    public int Tcid { get; set; }

    public string? Tcdescricao { get; set; }

    public virtual ICollection<TribAtivTributosEmpresa> TribAtivTributosEmpresas { get; set; } = new List<TribAtivTributosEmpresa>();

    public virtual ICollection<TribTipoPublicidade> TribTipoPublicidades { get; set; } = new List<TribTipoPublicidade>();

    public virtual ICollection<TribTipoTributosVenc> TribTipoTributosVencs { get; set; } = new List<TribTipoTributosVenc>();

    public virtual ICollection<TribTiposBaseCalculoTributo> TribTiposBaseCalculoTributos { get; set; } = new List<TribTiposBaseCalculoTributo>();
}
