using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class PesqServicosSec
{
    public int PesqServId { get; set; }

    public int? OrgId { get; set; }

    public string? PesqServDescricao { get; set; }

    public string? PesqServPrestTelefone { get; set; }

    public string? PesqServPrestPessoalmente { get; set; }

    public string? PesqServPrestInLocco { get; set; }

    public string? PesqServPrestWeb { get; set; }

    public string? PesqServPrestPassivelWeb { get; set; }

    public string? PesqServPrestCorreio { get; set; }

    public DateTime? PesqServDtCadastro { get; set; }
}
