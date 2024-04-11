using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribSaneparExport2009Atual
{
    public long? EdificacaoId { get; set; }

    public string? InscricaoImobiliaria { get; set; }

    public string? SaneMatricula { get; set; }

    public int? TipoBxId { get; set; }

    public string? Proprietario { get; set; }

    public string? Endereco { get; set; }

    public decimal? Valor { get; set; }
}
