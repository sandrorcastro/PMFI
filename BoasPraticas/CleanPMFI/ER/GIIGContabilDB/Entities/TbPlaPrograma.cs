using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbPlaPrograma
{
    public int IdPrograma { get; set; }

    public short? IdEscopo { get; set; }

    public string? CdPrograma { get; set; }

    public int? IdVersaoCriacao { get; set; }

    public int? IdMovimento { get; set; }

    public string? TpComando { get; set; }

    public decimal? VlLimite { get; set; }

    public int? IdMacroObjetivo { get; set; }

    public virtual TbPlaMacroObjetivo? IdMacroObjetivoNavigation { get; set; }

    public virtual TbPlaVerso? IdVersaoCriacaoNavigation { get; set; }

    public virtual ICollection<TbPlaAcoesPrograma> TbPlaAcoesProgramas { get; set; } = new List<TbPlaAcoesPrograma>();

    public virtual ICollection<TbPlaIndicadoresSimplificado> TbPlaIndicadoresSimplificados { get; set; } = new List<TbPlaIndicadoresSimplificado>();

    public virtual ICollection<TbPlaProgramaIndicador> TbPlaProgramaIndicadors { get; set; } = new List<TbPlaProgramaIndicador>();

    public virtual ICollection<TbPlaProgramasMovimentaco> TbPlaProgramasMovimentacos { get; set; } = new List<TbPlaProgramasMovimentaco>();

    public virtual ICollection<TbPlaProgramasMovimento> TbPlaProgramasMovimentos { get; set; } = new List<TbPlaProgramasMovimento>();

    public virtual ICollection<TbPlaProgramasObjetivo> TbPlaProgramasObjetivos { get; set; } = new List<TbPlaProgramasObjetivo>();

    public virtual ICollection<TbPlaProgramasPermissoesOrgao> TbPlaProgramasPermissoesOrgaos { get; set; } = new List<TbPlaProgramasPermissoesOrgao>();

    public virtual ICollection<TbPlaProgramasValore> TbPlaProgramasValores { get; set; } = new List<TbPlaProgramasValore>();
}
