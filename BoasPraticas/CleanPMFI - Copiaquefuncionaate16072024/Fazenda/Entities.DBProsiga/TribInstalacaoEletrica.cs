using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribInstalacaoEletrica
{
    public int EletricaId { get; set; }

    public string? EletricaNome { get; set; }

    public decimal? EletricaFator { get; set; }

    public int? EletricaPontos { get; set; }

    public virtual ICollection<TribEdificaco> TribEdificacos { get; set; } = new List<TribEdificaco>();
}
