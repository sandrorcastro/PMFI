using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbPlaObjetivosMilenio
{
    public short IdObjetivoMilenio { get; set; }

    public string? DsObjetivoMilenio { get; set; }

    public virtual ICollection<TbPlaIndicadoresObjetivoMilenioAvaliacao> TbPlaIndicadoresObjetivoMilenioAvaliacaos { get; set; } = new List<TbPlaIndicadoresObjetivoMilenioAvaliacao>();

    public virtual ICollection<TbPlaMacroObjetivo> TbPlaMacroObjetivos { get; set; } = new List<TbPlaMacroObjetivo>();

    public virtual ICollection<TbPlaObjetivosMilenioAvaliacao> TbPlaObjetivosMilenioAvaliacaos { get; set; } = new List<TbPlaObjetivosMilenioAvaliacao>();

    public virtual ICollection<TbPlaObjetivosMilenioMedidasEsperada> TbPlaObjetivosMilenioMedidasEsperada { get; set; } = new List<TbPlaObjetivosMilenioMedidasEsperada>();

    public virtual ICollection<TbPlaAcoesMovimento> IdMovimentos { get; set; } = new List<TbPlaAcoesMovimento>();
}
