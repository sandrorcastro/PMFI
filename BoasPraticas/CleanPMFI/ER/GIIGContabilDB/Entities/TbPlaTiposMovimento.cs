using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbPlaTiposMovimento
{
    public short IdTipoMovimento { get; set; }

    public string? DsTipoMovimento { get; set; }

    public virtual ICollection<TbPlaAcoesMetasMovimento> TbPlaAcoesMetasMovimentos { get; set; } = new List<TbPlaAcoesMetasMovimento>();

    public virtual ICollection<TbPlaAcoesMovimento> TbPlaAcoesMovimentos { get; set; } = new List<TbPlaAcoesMovimento>();

    public virtual ICollection<TbPlaIndicadoresMovimento> TbPlaIndicadoresMovimentos { get; set; } = new List<TbPlaIndicadoresMovimento>();

    public virtual ICollection<TbPlaProgramasMovimento> TbPlaProgramasMovimentos { get; set; } = new List<TbPlaProgramasMovimento>();
}
