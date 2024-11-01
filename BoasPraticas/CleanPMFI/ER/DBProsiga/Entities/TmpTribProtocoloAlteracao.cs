﻿using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TmpTribProtocoloAlteracao
{
    public int ProtAltId { get; set; }

    public long? EdificacaoId { get; set; }

    public long? EmprCmc { get; set; }

    public long? ConId { get; set; }

    public DateTime? Data { get; set; }

    public string? Protocolo { get; set; }

    public string? MotivoAlteracao { get; set; }

    public string? Usuario { get; set; }

    public DateTime? DataInclusao { get; set; }

    public string? ProtAltTabela { get; set; }

    public long? ProtAltIdtabela { get; set; }
}
