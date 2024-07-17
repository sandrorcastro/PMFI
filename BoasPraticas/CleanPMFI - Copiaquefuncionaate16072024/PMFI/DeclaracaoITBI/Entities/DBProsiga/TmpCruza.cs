using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TmpCruza
{
    public int? EdificacaoId { get; set; }

    public string? InscricaoImobiliaria { get; set; }

    public string? ConCnpjcpf { get; set; }

    public string? ConNome { get; set; }

    public string? Proprietario { get; set; }

    public string? Responsavel { get; set; }

    public int? Relogios { get; set; }
}
