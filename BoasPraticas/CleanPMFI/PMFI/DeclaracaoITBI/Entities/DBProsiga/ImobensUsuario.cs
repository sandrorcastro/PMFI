﻿using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class ImobensUsuario
{
    public int? UsuCodUsuario { get; set; }

    public string? UsuNomeUsuario { get; set; }

    public string? UsuSenha { get; set; }

    public string? UsuAcesso { get; set; }

    public DateTime? UsuDtCad { get; set; }
}
