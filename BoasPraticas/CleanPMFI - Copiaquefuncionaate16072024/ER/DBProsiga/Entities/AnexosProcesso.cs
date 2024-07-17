using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class AnexosProcesso
{
    public long AnexoId { get; set; }

    public long? AnexoProcId { get; set; }

    public int? AnexoDocId { get; set; }

    public string? AnexoNumero { get; set; }

    public DateTime? AnexoData { get; set; }

    public string? AnexoOriginal { get; set; }

    public string? AnexoComplemento { get; set; }

    public byte[]? AnexoImagem { get; set; }

    /// <summary>
    /// &apos;&apos;
    /// </summary>
    public string? AnexoPorUsuario { get; set; }

    /// <summary>
    /// Extensao do Arquivo anexado ao processo
    /// </summary>
    public string? AnexoExtensao { get; set; }

    /// <summary>
    /// Informa se o anexo vai ser publicado na Web
    /// </summary>
    public string AnexoPublicaInternet { get; set; } = null!;
}
