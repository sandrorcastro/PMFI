using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class Tbtribtipoempresa
{
    public short Idtipoempresa { get; set; }

    public string Dstipoempresa { get; set; } = null!;

    public string? Dslegislacao { get; set; }

    public string? Dsinformacao { get; set; }

    public bool? Flinscricaoobrigatorio { get; set; }

    public bool? Flzoneamentoobrigatorio { get; set; }

    public bool? Fldomiciliotributario { get; set; }

    public virtual ICollection<Tbtribtipoempresadocumento> Tbtribtipoempresadocumentos { get; set; } = new List<Tbtribtipoempresadocumento>();

    public virtual ICollection<TribAtivAtividadeDocumento> TribAtivAtividadeDocumentos { get; set; } = new List<TribAtivAtividadeDocumento>();

    public virtual ICollection<TribAtivAtividadePergunta> TribAtivAtividadePergunta { get; set; } = new List<TribAtivAtividadePergunta>();
}
