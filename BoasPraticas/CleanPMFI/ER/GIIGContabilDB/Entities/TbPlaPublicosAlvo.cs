using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbPlaPublicosAlvo
{
    public int IdPublicoAlvo { get; set; }

    public string? DsPublicoAlvo { get; set; }

    public short? IdTipoPublicoAlvo { get; set; }

    public virtual ICollection<TbPlaIndicadoresMovimento> TbPlaIndicadoresMovimentos { get; set; } = new List<TbPlaIndicadoresMovimento>();

    public virtual ICollection<TbPlaProgramasObjetivosMeta> TbPlaProgramasObjetivosMeta { get; set; } = new List<TbPlaProgramasObjetivosMeta>();
}
