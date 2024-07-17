using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbPlaAco
{
    public int IdAcao { get; set; }

    public short? IdEscopo { get; set; }

    public string CdAcao { get; set; } = null!;

    public int? IdVersaoCriacao { get; set; }

    public int? IdMovimento { get; set; }

    public string? TpComando { get; set; }

    public string? NmAcao { get; set; }

    public virtual ICollection<TbPlaAcao2012> TbPlaAcao2012s { get; set; } = new List<TbPlaAcao2012>();

    public virtual ICollection<TbPlaAcoesAvaliacoesAno> TbPlaAcoesAvaliacoesAnos { get; set; } = new List<TbPlaAcoesAvaliacoesAno>();

    public virtual ICollection<TbPlaAcoesCorrelacao> TbPlaAcoesCorrelacaoIdAcaoCorrelacaoNavigations { get; set; } = new List<TbPlaAcoesCorrelacao>();

    public virtual ICollection<TbPlaAcoesCorrelacao> TbPlaAcoesCorrelacaoIdAcaoNavigations { get; set; } = new List<TbPlaAcoesCorrelacao>();

    public virtual ICollection<TbPlaAcoesMeta> TbPlaAcoesMeta { get; set; } = new List<TbPlaAcoesMeta>();

    public virtual ICollection<TbPlaAcoesPrograma> TbPlaAcoesProgramas { get; set; } = new List<TbPlaAcoesPrograma>();

    public virtual ICollection<TbPlaAcoesSemCorrelacao> TbPlaAcoesSemCorrelacaos { get; set; } = new List<TbPlaAcoesSemCorrelacao>();

    public virtual ICollection<TbPlaProjetosAtividadesAco> TbPlaProjetosAtividadesAcos { get; set; } = new List<TbPlaProjetosAtividadesAco>();

    public virtual ICollection<TbLicLicitaco> IdLicitacaos { get; set; } = new List<TbLicLicitaco>();
}
