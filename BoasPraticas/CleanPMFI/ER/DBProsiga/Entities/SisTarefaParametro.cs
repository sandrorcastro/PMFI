using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class SisTarefaParametro
{
    /// <summary>
    /// Identificação da Tarefa.
    /// </summary>
    public int TaPaId { get; set; }

    public int TiJoId { get; set; }

    /// <summary>
    /// Parâmetro do procedimento (strored procedure) que será executado pelo tipo de JOB.
    /// </summary>
    public string TaPaParametro { get; set; } = null!;

    /// <summary>
    /// Tipo do parâmetro do procedimento (strored procedure) que será executado pelo tipo de JOB. Pode ser: String, Inteiro, Money
    /// </summary>
    public string? TaPaTipoParametro { get; set; }

    /// <summary>
    /// Tamanho do paramentro ex. string 50, inteiro 4, money 8,2.
    /// </summary>
    public decimal? TaPaTamanhoParametro { get; set; }

    public string? TaPaDescrParametro { get; set; }

    /// <summary>
    /// Marca se o parâmetro é opcional.
    /// </summary>
    public string TaPaOpcional { get; set; } = null!;

    public string? TaPaVlrPadrao { get; set; }

    public int? TaPaOrdem { get; set; }

    public virtual ICollection<SisTarefaParametrosValore> SisTarefaParametrosValores { get; set; } = new List<SisTarefaParametrosValore>();

    public virtual SisTarefa TiJo { get; set; } = null!;
}
