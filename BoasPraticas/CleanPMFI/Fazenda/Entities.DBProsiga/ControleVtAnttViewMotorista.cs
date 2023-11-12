using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class ControleVtAnttViewMotorista
{
    public string? AcessoOperadorCpf { get; set; }

    public string? RazaoSocial { get; set; }

    public string? ConCnpjcpf { get; set; }

    public DateTime? FzdtAdmissao { get; set; }

    public DateTime? FzdtDemissao { get; set; }

    public int FzmotoristaId { get; set; }

    public string? FzmotoristaNome { get; set; }

    public string? Fzcpf { get; set; }
}
