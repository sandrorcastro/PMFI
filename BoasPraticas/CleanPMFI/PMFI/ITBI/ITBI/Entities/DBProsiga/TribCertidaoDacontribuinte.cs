using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribCertidaoDacontribuinte
{
    public int IdCertidaoDacontribuite { get; set; }

    public long CertidaoDaid { get; set; }

    public long? ConId { get; set; }

    public string? NmContribuinte { get; set; }

    public string? NrCnpjcpf { get; set; }

    public string? TpLogradouro { get; set; }

    public string? NmLogradouro { get; set; }

    public string? NrPredial { get; set; }

    public string? NmLoteamento { get; set; }

    public string? NrCep { get; set; }

    public string? NmCidade { get; set; }

    public string? DsUf { get; set; }

    public string? DsComplemento { get; set; }

    public string? TpContribuinte { get; set; }

    public long? IdVersao { get; set; }

    public string? NmFantasia { get; set; }
}
