﻿using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribEmpresasServicosVelha
{
    public long EmprCmc { get; set; }

    public string ServId { get; set; } = null!;

    public DateTime? ServEmprDataIni { get; set; }

    public DateTime? ServEmprDataFim { get; set; }

    public string? ServEmprMotivo { get; set; }

    /// <summary>
    /// Imune, Isento, Não Tributável ou Tributável
    /// </summary>
    public string? ServEmprTipoIncidencia { get; set; }
}
