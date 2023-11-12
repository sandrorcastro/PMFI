using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribEdificacoesImportacao
{
    public int EdificacaoId { get; set; }

    public string InscricaoImobiliaria { get; set; } = null!;

    public string NomeArquivo { get; set; } = null!;

    public DateTime Data { get; set; }

    public string Status { get; set; } = null!;

    public string Observacao { get; set; } = null!;
}
