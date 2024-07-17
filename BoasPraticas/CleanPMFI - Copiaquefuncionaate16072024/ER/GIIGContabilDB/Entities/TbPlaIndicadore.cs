using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbPlaIndicadore
{
    public int IdIndicador { get; set; }

    public short? IdEscopo { get; set; }

    public string? CdIndicador { get; set; }

    public int? IdVersaoCriacao { get; set; }

    public int? IdMovimento { get; set; }

    public string? TpComando { get; set; }

    public virtual TbPlaEscopo? IdEscopoNavigation { get; set; }

    public virtual TbPlaVerso? IdVersaoCriacaoNavigation { get; set; }

    public virtual ICollection<TbPlaIndicadoresAvaliacoesAno> TbPlaIndicadoresAvaliacoesAnos { get; set; } = new List<TbPlaIndicadoresAvaliacoesAno>();

    public virtual ICollection<TbPlaIndicadoresMovimento> TbPlaIndicadoresMovimentos { get; set; } = new List<TbPlaIndicadoresMovimento>();

    public virtual ICollection<TbPlaIndicadoresObjetivoMilenioAvaliacao> TbPlaIndicadoresObjetivoMilenioAvaliacaos { get; set; } = new List<TbPlaIndicadoresObjetivoMilenioAvaliacao>();

    public virtual ICollection<TbPlaProgramaIndicador> TbPlaProgramaIndicadors { get; set; } = new List<TbPlaProgramaIndicador>();

    public virtual ICollection<TbPlaProgramasObjetivosMeta> TbPlaProgramasObjetivosMeta { get; set; } = new List<TbPlaProgramasObjetivosMeta>();
}
