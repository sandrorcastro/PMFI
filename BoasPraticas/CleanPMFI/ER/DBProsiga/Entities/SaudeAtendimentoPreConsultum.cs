using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class SaudeAtendimentoPreConsultum
{
    public long PreConsId { get; set; }

    public long AtendId { get; set; }

    public int? CdFuncionario { get; set; }

    public int? CdOcupacaoSaude { get; set; }

    public string? PreConsDescricao { get; set; }

    public string? PreConsTemperatura { get; set; }

    public string? PreConsPa { get; set; }

    public string? PreConsPeso { get; set; }

    public string? PreConsEstatura { get; set; }

    public string? PreConsHora { get; set; }

    public string? UsuarioInclusao { get; set; }

    public DateTime? DataInclusao { get; set; }
}
