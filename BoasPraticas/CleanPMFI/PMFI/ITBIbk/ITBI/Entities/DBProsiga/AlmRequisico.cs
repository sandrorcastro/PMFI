﻿using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class AlmRequisico
{
    public long RequisicaoId { get; set; }

    public DateTime? ReqData { get; set; }

    public long? ServidorId { get; set; }

    /// <summary>
    /// Divisão destino da requisicao.
    /// </summary>
    public long? DivId { get; set; }

    public long? AlmoxId { get; set; }

    public string? ReqComReserva { get; set; }

    public string? UsuId { get; set; }

    public string? ReqSituacaoEnvio { get; set; }

    public virtual ICollection<AlmRequisicoesIten> AlmRequisicoesItens { get; set; } = new List<AlmRequisicoesIten>();

    public virtual Almoxarifado? Almox { get; set; }
}
