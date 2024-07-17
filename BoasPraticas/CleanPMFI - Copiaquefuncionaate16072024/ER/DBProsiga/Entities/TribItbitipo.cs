using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribItbitipo
{
    public long ItbitipoId { get; set; }

    public string ItbidsTipo { get; set; } = null!;

    public short Itbiordem { get; set; }

    /// <summary>
    /// (1) - Ativo, (0) - Inativo
    /// </summary>
    public bool Itbistatus { get; set; }

    public virtual ICollection<TribItbidocumentoTipo> TribItbidocumentoTipos { get; set; } = new List<TribItbidocumentoTipo>();
}
