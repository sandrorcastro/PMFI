using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbOrcTiposAtoAlteracao
{
    public short IdTipoAtoAlteracao { get; set; }

    public string? NmTipoAtoAlteracao { get; set; }

    public string? DsSigla { get; set; }

    public string? DsTipoEmpresas { get; set; }

    public int? IdTexto1 { get; set; }

    public int? IdTexto2 { get; set; }

    public int? IdTexto3 { get; set; }

    public string? CdParamTc { get; set; }

    public bool? FlAtivo { get; set; }

    public virtual ICollection<TbOrcAtosAlteraco> TbOrcAtosAlteracos { get; set; } = new List<TbOrcAtosAlteraco>();
}
