﻿using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class FzobjetosBackup
{
    public int ObjetoId { get; set; }

    public long? ObjOrigemId { get; set; }

    public string? ObjOrigemTipo { get; set; }

    public string? ObjNome { get; set; }

    public string? ObjLegenda { get; set; }

    public string? ObjTipoImagem { get; set; }

    public byte[]? ObjImagem { get; set; }

    public string? ObjObservacoes { get; set; }

    public DateTime? ObjDtGravacao { get; set; }

    public string? ObjUsuario { get; set; }

    public long? ObjOrigemIdAnterior { get; set; }
}
