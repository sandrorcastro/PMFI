using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribItbiexAnexo
{
    public long ItbianexoId { get; set; }

    public long Itbiid { get; set; }

    public int? ObjetoId { get; set; }

    public long ItbidocId { get; set; }

    public string? Ipsolicitante { get; set; }

    public DateTime? DtAnexo { get; set; }

    public string? DsParecer { get; set; }

    public DateTime? DtParecer { get; set; }

    public string? FlParecer { get; set; }

    public string? Usuariologado { get; set; }

    public virtual TribItbiex Itbi { get; set; } = null!;

    public virtual TribItbidocumentoTipo Itbidoc { get; set; } = null!;

    public virtual TribObjeto? Objeto { get; set; }
}
