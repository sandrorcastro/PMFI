using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribEdificacoesAnexo
{
    public long AnexoId { get; set; }

    public long? EdificacaoId { get; set; }

    public int? ProtAltId { get; set; }

    public int? ObjetoId { get; set; }

    public string? NmAnexo { get; set; }

    public string? UsuarioInclusao { get; set; }

    public DateTime? DataInclusao { get; set; }

    public bool? FlExcluido { get; set; }
}
