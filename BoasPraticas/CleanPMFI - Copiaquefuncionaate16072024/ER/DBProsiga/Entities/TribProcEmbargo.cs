using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribProcEmbargo
{
    public long ProcEmbId { get; set; }

    public long? ProcId { get; set; }

    public DateTime? ProcEmbDataIntimacao { get; set; }

    public DateTime? ProcEmbPrazoInicio { get; set; }

    public DateTime? ProcEmbPrazoFim { get; set; }

    public DateTime? ProcEmbDataImpugnacao { get; set; }

    public DateTime? ProcEmbDataManifestacao { get; set; }

    public string? ProcEmbSentencaTipo { get; set; }

    public DateTime? ProcEmbSentencaData { get; set; }

    public string? ProcEmbObservacao { get; set; }

    public DateTime? DataInclusao { get; set; }

    public DateTime? DataAlteracao { get; set; }

    public string? UsuarioInclusao { get; set; }

    public string? UsuarioAlteracao { get; set; }

    public virtual TribProcProcesso? Proc { get; set; }

    public virtual ICollection<TribProcEmbargoTipo> TribProcEmbargoTipos { get; set; } = new List<TribProcEmbargoTipo>();
}
