using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class Fzparametro
{
    /// <summary>
    /// Código de Identificação do Parametro
    /// </summary>
    public string ParId { get; set; } = null!;

    /// <summary>
    /// Código de Identificação do Convenio
    /// </summary>
    public long? ParConvenioId { get; set; }

    public string? ParChefeDivisao { get; set; }

    public string? ParCargoChefeDivisao { get; set; }

    /// <summary>
    /// Nome do Diretor
    /// </summary>
    public string? ParDiretor { get; set; }

    /// <summary>
    /// Descrição do Cargo do Diretor.
    /// </summary>
    public string? ParCargoDiretor { get; set; }

    /// <summary>
    /// Código da Moeda. Utilizada em Transações Financeiras.
    /// </summary>
    public string? ParCodigoMoeda { get; set; }
}
