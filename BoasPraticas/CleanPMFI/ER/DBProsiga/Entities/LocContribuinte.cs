﻿using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class LocContribuinte
{
    public int ContribuinteId { get; set; }

    public string? ConCnpjcpf { get; set; }

    public string? ConNome { get; set; }

    public DateTime? ConDtNasc { get; set; }

    public string? ConSexo { get; set; }

    public string? ConRg { get; set; }

    public string? ConNacionalidade { get; set; }

    public string? ConEstadoCivil { get; set; }

    public string? ConProfissao { get; set; }

    public string? ConCep { get; set; }

    public string? ConTipoLograd { get; set; }

    public string? ConEndereco { get; set; }

    public string? ConNumero { get; set; }

    public string? ConComplemento { get; set; }

    public int? ConBairroId { get; set; }

    public string? ConBairro { get; set; }

    public int? ConCidadeId { get; set; }

    public string? ConCidade { get; set; }

    public string? ConUf { get; set; }

    public string? ConTelefones { get; set; }

    public string? ConEmail { get; set; }

    public string? ConRespRg { get; set; }

    public string? ConRespNome { get; set; }

    public string? ConTecUltAlt { get; set; }

    public DateTime? ConDtUltAlt { get; set; }
}
