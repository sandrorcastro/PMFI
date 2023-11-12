using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TmpTribConsultaPrevium
{
    public int Idconsulta { get; set; }

    public string? Inscricaoimobiliaria { get; set; }

    public string? Atividade { get; set; }

    public int? Pergunta { get; set; }

    public string? Resposta { get; set; }
}
