﻿using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class SisTarefaParametrosValore
{
    public int PaVaId { get; set; }

    public int JoAgId { get; set; }

    /// <summary>
    /// Identificação da Tarefa.
    /// </summary>
    public int TaPaId { get; set; }

    /// <summary>
    /// Valor atribuido ao parametro.
    /// </summary>
    public string? PaVaValor { get; set; }

    public virtual SisTarefaAgendum JoAg { get; set; } = null!;

    public virtual SisTarefaParametro TaPa { get; set; } = null!;
}
