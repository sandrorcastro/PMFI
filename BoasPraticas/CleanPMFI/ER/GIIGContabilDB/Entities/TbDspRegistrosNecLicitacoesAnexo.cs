using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbDspRegistrosNecLicitacoesAnexo
{
    public int IdAnexo { get; set; }

    public int? IdRegistro { get; set; }

    public short? IdEmpresa { get; set; }

    public short? NrAno { get; set; }

    public string? CdOrgao { get; set; }

    public string? CdUnidade { get; set; }

    public string? DsAnexo { get; set; }

    public byte[]? BnArquivo { get; set; }

    public string? NmArquivo { get; set; }

    public DateTime? DtAnexso { get; set; }

    public string? DsLogin { get; set; }

    public virtual TbDspRegistrosNecessidadeLicitaco? IdRegistroNavigation { get; set; }
}
