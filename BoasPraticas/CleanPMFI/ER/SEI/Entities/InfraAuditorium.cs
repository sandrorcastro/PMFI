using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class InfraAuditorium
{
    public long IdInfraAuditoria { get; set; }

    public string Recurso { get; set; } = null!;

    public DateTime DthAcesso { get; set; }

    public string? Ip { get; set; }

    public int? IdUsuario { get; set; }

    public string? SiglaUsuario { get; set; }

    public string? NomeUsuario { get; set; }

    public int? IdOrgaoUsuario { get; set; }

    public string? SiglaOrgaoUsuario { get; set; }

    public int? IdUsuarioEmulador { get; set; }

    public string? SiglaUsuarioEmulador { get; set; }

    public string? NomeUsuarioEmulador { get; set; }

    public int? IdOrgaoUsuarioEmulador { get; set; }

    public string? SiglaOrgaoUsuarioEmulador { get; set; }

    public int? IdUnidade { get; set; }

    public string? SiglaUnidade { get; set; }

    public string? DescricaoUnidade { get; set; }

    public int? IdOrgaoUnidade { get; set; }

    public string? SiglaOrgaoUnidade { get; set; }

    public string? Servidor { get; set; }

    public string? UserAgent { get; set; }

    public string? Requisicao { get; set; }

    public string? Operacao { get; set; }
}
