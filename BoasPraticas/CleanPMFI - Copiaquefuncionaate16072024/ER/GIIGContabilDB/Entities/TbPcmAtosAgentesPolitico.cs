using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbPcmAtosAgentesPolitico
{
    public int IdAto { get; set; }

    public string? TpAto { get; set; }

    public string? NrAto { get; set; }

    public DateTime? DtAto { get; set; }

    public DateTime? DtPublicacao { get; set; }

    public string? DsVeiculoPublic { get; set; }

    public string DsArquivoAnexo { get; set; } = null!;

    public virtual TbPcmHistoricoAtosAgentesPolitico? TbPcmHistoricoAtosAgentesPolitico { get; set; }
}
