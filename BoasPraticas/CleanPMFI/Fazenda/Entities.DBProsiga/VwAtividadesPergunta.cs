using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class VwAtividadesPergunta
{
    public string Atividade { get; set; } = null!;

    public string? AtividadeDenom { get; set; }

    public short PerguntaNumero { get; set; }

    public string Pergunta { get; set; } = null!;

    public int Ordem { get; set; }
}
