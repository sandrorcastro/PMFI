using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class WflowAnexo
{
    public long AnexoId { get; set; }

    public long? RemId { get; set; }

    public string? UsuId { get; set; }

    public DateTime? AnexoData { get; set; }

    public long? FluxoTramId { get; set; }

    public byte[]? AnexoObjeto { get; set; }

    public string? AnexoTipoObjeto { get; set; }

    public string? AnexoObjDescr { get; set; }

    public string? Extensao { get; set; }

    public virtual WflowRemessa? Rem { get; set; }

    public virtual Usuario? Usu { get; set; }
}
