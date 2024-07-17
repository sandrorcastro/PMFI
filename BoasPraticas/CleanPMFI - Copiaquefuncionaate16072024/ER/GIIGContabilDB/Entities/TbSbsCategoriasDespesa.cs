using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbSbsCategoriasDespesa
{
    public int IdCatDespesa { get; set; }

    public string? NmCatDespesa { get; set; }

    public virtual ICollection<TbSbsPlanoAplicacoesAditivo> TbSbsPlanoAplicacoesAditivos { get; set; } = new List<TbSbsPlanoAplicacoesAditivo>();

    public virtual ICollection<TbSbsPrestacaoConta> TbSbsPrestacaoConta { get; set; } = new List<TbSbsPrestacaoConta>();

    public virtual ICollection<TbSbsTipoDespesa> CdTipoDespesas { get; set; } = new List<TbSbsTipoDespesa>();
}
