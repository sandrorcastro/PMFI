using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class WflowRemessa
{
    public long RemId { get; set; }

    public long? RequiId { get; set; }

    public string? UsuRemetenteId { get; set; }

    public DateTime? RemData { get; set; }

    public long? FluxoRemId { get; set; }

    public long? FluxoDestinoId { get; set; }

    public long? DespPadraoId { get; set; }

    public string? DespachoDescr { get; set; }

    public virtual WflowDespachoPadrao? DespPadrao { get; set; }

    public virtual WflowRequisicao? Requi { get; set; }

    public virtual ICollection<WflowAnexo> WflowAnexos { get; set; } = new List<WflowAnexo>();

    public virtual ICollection<WflowRececimento> Recs { get; set; } = new List<WflowRececimento>();
}
