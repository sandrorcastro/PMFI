using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbAmmGeracaoArquivo
{
    public int IdGeracao { get; set; }

    public short? IdEmpresa { get; set; }

    public DateTime? DtGeracao { get; set; }

    public DateTime? DtInicial { get; set; }

    public DateTime? DtFinal { get; set; }

    public string? NmArquivo { get; set; }

    public string? DsPeriodo { get; set; }

    public string? DsLogin { get; set; }

    public string? NrEnderecoIp { get; set; }
}
