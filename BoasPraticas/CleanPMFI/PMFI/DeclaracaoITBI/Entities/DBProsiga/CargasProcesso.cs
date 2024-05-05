using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class CargasProcesso
{
    public long CargaId { get; set; }

    /// <summary>
    /// Data da carga do processo
    /// </summary>
    public DateTime? CargaData { get; set; }

    /// <summary>
    /// Identificação do processo
    /// </summary>
    public long? CargaProcId { get; set; }

    /// <summary>
    /// Identificação da divisão de origem
    /// </summary>
    public int? CargaDivisaoIdorigem { get; set; }

    /// <summary>
    /// Identificação da divisão destino
    /// </summary>
    public int? CargaDivisaoId { get; set; }

    public long? CargaServOrigem { get; set; }

    public long? CargaServDestino { get; set; }

    /// <summary>
    /// Texto com as providencias que devem ser tomadas
    /// </summary>
    public string? CargaDespacho { get; set; }

    public string? CargaPublicoDivisao { get; set; }

    public virtual Diviso? CargaDivisao { get; set; }

    public virtual Diviso? CargaDivisaoIdorigemNavigation { get; set; }

    public virtual Processo? CargaProc { get; set; }

    public virtual ICollection<Recebimento> Recebimentos { get; set; } = new List<Recebimento>();
}
