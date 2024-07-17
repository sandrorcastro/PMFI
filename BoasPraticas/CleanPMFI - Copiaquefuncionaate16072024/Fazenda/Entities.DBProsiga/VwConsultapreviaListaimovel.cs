using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class VwConsultapreviaListaimovel
{
    public string InscricaoImobiliaria { get; set; } = null!;

    public int LogradId { get; set; }

    public string? LogradTipo { get; set; }

    public string? LogradNome { get; set; }

    public string? LoteamentoNome { get; set; }

    public string? LogradNumero { get; set; }

    public string? Complemento { get; set; }

    public string? Cep { get; set; }

    public string LogradDaQuadra { get; set; } = null!;

    public int? QuadraId { get; set; }
}
