using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribCertidaoDaempresa
{
    public int IdCertidaoDaempresa { get; set; }

    public long CertidaoDaid { get; set; }

    public long? EmprCmc { get; set; }

    public string? NrCnpjcpf { get; set; }

    public string? DsSituacao { get; set; }

    public string? NmRazaoSocial { get; set; }

    public string? NmFantasia { get; set; }

    public string? TpLograouro { get; set; }

    public string? NmLogradouro { get; set; }

    public string? NrPredial { get; set; }

    public string? NmLoteamento { get; set; }

    public string? NrCep { get; set; }

    public string? NmCidade { get; set; }

    public string? DsUf { get; set; }

    public string? DsComplemento { get; set; }

    public long? IdVersao { get; set; }
}
