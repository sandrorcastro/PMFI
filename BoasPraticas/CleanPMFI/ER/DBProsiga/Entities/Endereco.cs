﻿using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class Endereco
{
    public long? EnderecoId { get; set; }

    public string? Cep { get; set; }

    public string? TipoLogradouro { get; set; }

    public string? NmLogradouro { get; set; }

    public string? NumLogradouro { get; set; }

    public long? BairroId { get; set; }

    public string? Complemento { get; set; }
}
