using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TmpTribConsultaPrevium
{
    public int Idconsulta { get; set; }

    public string? Inscricaoimobiliaria { get; set; }

    public string? Atividade { get; set; }

    public int? Pergunta { get; set; }

    public string? Resposta { get; set; }
}
