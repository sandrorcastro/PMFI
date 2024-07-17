using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribProcProcesso
{
    public long ProcId { get; set; }

    public int? ProcNumero { get; set; }

    public int? ProcAno { get; set; }

    public string? ProcVaraCivil { get; set; }

    public string? ProcObs { get; set; }

    public DateTime? ProcData { get; set; }

    public string? ProcMotivoExtincao { get; set; }

    public DateTime? ProcDataExtincao { get; set; }

    public string? ProcSentencaExtincao { get; set; }

    public int? ProcTipoProcId { get; set; }

    public string? ProcNumDistribuicao { get; set; }

    public string? ProcLiberaCalculoHonorario { get; set; }

    public string? ProcNumeroUnico { get; set; }

    public decimal? ProcPercHonorario { get; set; }

    public decimal? ProcValorCausa { get; set; }

    public DateTime? DataInclusao { get; set; }

    public DateTime? DataAlteracao { get; set; }

    public string? UsuarioInclusao { get; set; }

    public string? UsuarioAlteracao { get; set; }

    public int? ProcOrgJurisId { get; set; }

    public virtual TribProcOrgaoJurisdicional? ProcOrgJuris { get; set; }

    public virtual ICollection<TribProcAdvogado> TribProcAdvogados { get; set; } = new List<TribProcAdvogado>();

    public virtual ICollection<TribProcArrestoPenhora> TribProcArrestoPenhoras { get; set; } = new List<TribProcArrestoPenhora>();

    public virtual ICollection<TribProcAutor> TribProcAutors { get; set; } = new List<TribProcAutor>();

    public virtual ICollection<TribProcCdum> TribProcCda { get; set; } = new List<TribProcCdum>();

    public virtual ICollection<TribProcCitacao> TribProcCitacaos { get; set; } = new List<TribProcCitacao>();

    public virtual ICollection<TribProcEmbargo> TribProcEmbargoes { get; set; } = new List<TribProcEmbargo>();

    public virtual ICollection<TribProcExecutado> TribProcExecutados { get; set; } = new List<TribProcExecutado>();

    public virtual ICollection<TribProcInfoComplementar> TribProcInfoComplementars { get; set; } = new List<TribProcInfoComplementar>();

    public virtual ICollection<TribProcPeticao> TribProcPeticaos { get; set; } = new List<TribProcPeticao>();

    public virtual ICollection<TribProcProcurador> TribProcProcuradors { get; set; } = new List<TribProcProcurador>();

    public virtual ICollection<TribProcRecurso> TribProcRecursos { get; set; } = new List<TribProcRecurso>();

    public virtual ICollection<TribProcSuspensao> TribProcSuspensaos { get; set; } = new List<TribProcSuspensao>();

    public virtual ICollection<TribProcTestemunha> TribProcTestemunhas { get; set; } = new List<TribProcTestemunha>();
}
