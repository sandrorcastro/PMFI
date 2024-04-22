using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class VisaoAnexosProcesso
{
    public long ProcId { get; set; }

    public long AnexoId { get; set; }

    public int? AnexoDocId { get; set; }

    public string? DocNome { get; set; }

    public string? AnexoNumero { get; set; }

    public DateTime? AnexoData { get; set; }

    public string? AnexoOriginal { get; set; }

    public string? AnexoComplemento { get; set; }

    public string? AnexoPorUsuario { get; set; }

    public byte[]? AnexoImagem { get; set; }
}
