using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class VwContribuintesIdSmsp
{
    public string? NomeContribuinte { get; set; }

    public string? NrCpfCnpj { get; set; }

    public string? RgProprietario { get; set; }

    public string? RgEmissor { get; set; }

    public string? RgEstado { get; set; }

    public string? NomeMae { get; set; }

    public DateTime? DataNascimento { get; set; }

    public string? Endereco { get; set; }

    public string? Nroresidencia { get; set; }

    public string? Complemento { get; set; }

    public string? Nomebairro { get; set; }

    public string? Cep { get; set; }

    public string? Cidade { get; set; }

    public string? Estado { get; set; }

    public string Inscricaoimobiliaria { get; set; } = null!;

    public string IndicacaoFiscal { get; set; } = null!;

    public int? Sexo { get; set; }

    public string? Fonecomercial { get; set; }

    public string? Foneresidencial { get; set; }

    public string? Celular { get; set; }

    public string Nomepai { get; set; } = null!;

    public string? Email { get; set; }
}
