﻿using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribAtivAtividadeGrauRisco
{
    public string Atividade { get; set; } = null!;

    public short SetorId { get; set; }

    public int? Idrisco { get; set; }

    public virtual TribAtivAtividade AtividadeNavigation { get; set; } = null!;

    public virtual Tbtribgraurisco? IdriscoNavigation { get; set; }

    public virtual TribAtivSetorLicenciamento Setor { get; set; } = null!;
}
