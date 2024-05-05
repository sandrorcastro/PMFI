using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribHonorariosCdum
{
    public int HonorarioCdaid { get; set; }

    public int? HonorarioDivId { get; set; }

    public long? CertidaoDaid { get; set; }

    public int? TipoBxId { get; set; }

    public DateTime? HonoCdadtVencimento { get; set; }

    public DateTime? HonoCdadtBaixa { get; set; }

    public decimal? HonoCdavlrDivida { get; set; }

    public decimal? HonoCdavlrBaixa { get; set; }

    public decimal? HonoCdavlrCalculo { get; set; }

    public long? LivroDaid { get; set; }

    public virtual TribCertidaoDum? CertidaoDa { get; set; }

    public virtual TribHonorariosDivida? HonorarioDiv { get; set; }
}
