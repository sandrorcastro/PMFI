using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbFinListaContaCorrenteOc
{
    public int IdLista { get; set; }

    public int? IdCctransf { get; set; }

    public string? NrCnpjcpf { get; set; }

    public string? DsTipoPessoa { get; set; }

    public string? NmCc { get; set; }

    public int? IdAgencia { get; set; }

    public string? NrCc { get; set; }

    public string? NrDv { get; set; }

    public string? DsTipoContaPessoa { get; set; }

    public DateTime? DtTransferencia { get; set; }

    public decimal? VlTranferencia { get; set; }

    public short? IdEmpresaExecutora { get; set; }

    public string? CdOrgao { get; set; }

    public string? CdUnidade { get; set; }
}
