using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribCmtipoConstrucao
{
    public int CmtipoConstId { get; set; }

    public string? CmtipoConstNome { get; set; }

    public int? TipoTribId { get; set; }

    public int? TipoBxId { get; set; }

    public int? TipoBxIdcancelamento { get; set; }

    public int? TipoTribIdobraConcluida { get; set; }

    public virtual TribTipoBaixa? TipoBx { get; set; }

    public virtual TribTipoTributo? TipoTrib { get; set; }

    public virtual ICollection<TribCmprocesso> TribCmprocessos { get; set; } = new List<TribCmprocesso>();
}
