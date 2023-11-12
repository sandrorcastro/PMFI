using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class Tbatendemapaagendamento
{
    public int Idmapa { get; set; }

    public int? Idservico { get; set; }

    public int? Iddiasemana { get; set; }

    public TimeSpan? Hrinicial { get; set; }

    public TimeSpan? Hrfinal { get; set; }

    public int? Nratendimentossimultaneo { get; set; }

    public bool? Ativo { get; set; }

    public int? Nrprocesso { get; set; }

    public int? Nrprocessoano { get; set; }

    public string? Dsmotivo { get; set; }
}
