using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbPlaAcoesMeta
{
    public int IdAcao { get; set; }

    public short NrAno { get; set; }

    public int? IdVersaoCriacao { get; set; }

    public int? IdMovimento { get; set; }

    public string? TpComando { get; set; }

    public virtual TbPlaAco IdAcaoNavigation { get; set; } = null!;

    public virtual ICollection<TbPlaAcoesMetasMovimento> TbPlaAcoesMetasMovimentos { get; set; } = new List<TbPlaAcoesMetasMovimento>();
}
