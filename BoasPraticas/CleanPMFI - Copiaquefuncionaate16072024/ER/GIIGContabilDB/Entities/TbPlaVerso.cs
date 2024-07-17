using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbPlaVerso
{
    public int IdVersao { get; set; }

    public short? IdEscopo { get; set; }

    public short? NrVersao { get; set; }

    public int? IdLeiAto { get; set; }

    public int? NrLeiAto { get; set; }

    public short? NrAnoLeiAto { get; set; }

    public DateTime? DtPubLeiAto { get; set; }

    public string? DsStatus { get; set; }

    public string? DsListaOrgaosPermitidos { get; set; }

    public DateTime? DtFinalizacao { get; set; }

    public int? IdAtoAlteracao { get; set; }

    public string? DsLogImportacao { get; set; }

    public virtual TbPlaEscopo? IdEscopoNavigation { get; set; }

    public virtual ICollection<TbPlaAcoesMovimento> TbPlaAcoesMovimentos { get; set; } = new List<TbPlaAcoesMovimento>();

    public virtual ICollection<TbPlaIndicadore> TbPlaIndicadores { get; set; } = new List<TbPlaIndicadore>();

    public virtual ICollection<TbPlaIndicadoresMovimento> TbPlaIndicadoresMovimentos { get; set; } = new List<TbPlaIndicadoresMovimento>();

    public virtual ICollection<TbPlaProgramaIndicador> TbPlaProgramaIndicadorIdVersaoCancelamentoNavigations { get; set; } = new List<TbPlaProgramaIndicador>();

    public virtual ICollection<TbPlaProgramaIndicador> TbPlaProgramaIndicadorIdVersaoVinculoNavigations { get; set; } = new List<TbPlaProgramaIndicador>();

    public virtual ICollection<TbPlaPrograma> TbPlaProgramas { get; set; } = new List<TbPlaPrograma>();

    public virtual ICollection<TbPlaProgramasMovimento> TbPlaProgramasMovimentos { get; set; } = new List<TbPlaProgramasMovimento>();
}
