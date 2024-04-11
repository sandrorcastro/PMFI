using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class AgeNotAviso
{
    public int AvisId { get; set; }

    public string? AvisTitulo { get; set; }

    public string? AvisTexto { get; set; }

    public string? AvisLink { get; set; }

    public DateTime? AvisDataInicio { get; set; }

    public DateTime? AvisDataFinal { get; set; }

    public string? UsuarioInclusao { get; set; }

    public DateTime? DataInclusao { get; set; }
}
