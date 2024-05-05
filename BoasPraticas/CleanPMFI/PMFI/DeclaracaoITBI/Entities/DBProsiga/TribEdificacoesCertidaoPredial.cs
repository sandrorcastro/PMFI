using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribEdificacoesCertidaoPredial
{
    public long IdedifCertidaoPredial { get; set; }

    public long? EdificacaoId { get; set; }

    public int? EdifCertPredialNumero { get; set; }

    public short? EdifCertPredialAno { get; set; }

    public string? UsuarioInclusao { get; set; }

    public DateTime? DataInclusao { get; set; }

    public byte[]? Qrcode { get; set; }

    public virtual TribEdificaco? Edificacao { get; set; }
}
