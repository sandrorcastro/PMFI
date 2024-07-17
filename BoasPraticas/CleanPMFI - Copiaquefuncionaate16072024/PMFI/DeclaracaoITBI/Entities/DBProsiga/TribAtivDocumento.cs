using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribAtivDocumento
{
    public short Iddocumento { get; set; }

    public string Dsdocumento { get; set; } = null!;

    public short SetorId { get; set; }

    /// <summary>
    /// Nome do documento que deverá ser apresentado ao Município.
    /// </summary>
    public string? Nmdocumento { get; set; }

    public int? Idautodeclaracao { get; set; }

    public bool? Flobrigatorio { get; set; }

    public virtual ICollection<Tbconsultapreviadocumento> Tbconsultapreviadocumentos { get; set; } = new List<Tbconsultapreviadocumento>();

    public virtual ICollection<Tbtribtipoempresadocumento> Tbtribtipoempresadocumentos { get; set; } = new List<Tbtribtipoempresadocumento>();

    public virtual ICollection<TribAtivAtividadeDocumento> TribAtivAtividadeDocumentos { get; set; } = new List<TribAtivAtividadeDocumento>();

    public virtual ICollection<TribAtivAtividadePergunta> TribAtivAtividadePergunta { get; set; } = new List<TribAtivAtividadePergunta>();

    public virtual ICollection<TribAtivDocumentosDispensado> TribAtivDocumentosDispensadoIddocumentoNavigations { get; set; } = new List<TribAtivDocumentosDispensado>();

    public virtual ICollection<TribAtivDocumentosDispensado> TribAtivDocumentosDispensadoIddocumentodispensadoNavigations { get; set; } = new List<TribAtivDocumentosDispensado>();
}
