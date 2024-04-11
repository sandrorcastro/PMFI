﻿using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TempTribEmpresasAtiv
{
    public long EmprCmc { get; set; }

    public string Atividade { get; set; } = null!;

    public string EmprAtivPrincipal { get; set; } = null!;

    public DateTime? EmprAtivDataInI { get; set; }

    public DateTime? EmprAtivDataFim { get; set; }
}
