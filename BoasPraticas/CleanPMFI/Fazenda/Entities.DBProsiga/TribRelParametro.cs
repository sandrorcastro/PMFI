using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribRelParametro
{
    public long Id { get; set; }

    public long? EdificacaoId { get; set; }

    public string? InscricaoImobiliaria { get; set; }

    public string? Descricao { get; set; }

    public object? Valor { get; set; }

    public short? Ordem { get; set; }
}
