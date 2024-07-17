using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbLicRegimesExecuco
{
    public short IdRegimeExecucao { get; set; }

    public string? DsRegimeExecucao { get; set; }

    public string? FlPadraoTce { get; set; }

    public bool? FlAtivo { get; set; }

    public short? CdTc { get; set; }

    public string? TpObjeto { get; set; }

    public virtual ICollection<TbCntContrato> TbCntContratos { get; set; } = new List<TbCntContrato>();

    public virtual ICollection<TbLicClassificacoesObjeto> IdClassificacaoObjetos { get; set; } = new List<TbLicClassificacoesObjeto>();
}
