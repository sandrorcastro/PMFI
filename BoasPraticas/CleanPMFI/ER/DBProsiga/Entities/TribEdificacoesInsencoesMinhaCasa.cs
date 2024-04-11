using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribEdificacoesInsencoesMinhaCasa
{
    public long IdIsencao { get; set; }

    public DateTime? DtContrato { get; set; }

    public long? EdificacaoId { get; set; }

    public DateTime? DtInclusao { get; set; }

    public string? DsLogin { get; set; }

    public virtual TribEdificaco? Edificacao { get; set; }

    public virtual ICollection<TribDividasImo> ImoIddivida { get; set; } = new List<TribDividasImo>();

    public virtual ICollection<TribDividasImo> ImoIddividaNavigation { get; set; } = new List<TribDividasImo>();
}
