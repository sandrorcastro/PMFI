using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribAmostraMercadoItbi
{
    public int IdamostraMercadoItbi { get; set; }

    public int? AmostraId { get; set; }

    public long? Itbiid { get; set; }

    public DateOnly? DataInclusao { get; set; }

    public string? UsuarioInclusao { get; set; }

    public virtual TribAmostraMercado? Amostra { get; set; }

    public virtual TribItbiex? Itbi { get; set; }
}
