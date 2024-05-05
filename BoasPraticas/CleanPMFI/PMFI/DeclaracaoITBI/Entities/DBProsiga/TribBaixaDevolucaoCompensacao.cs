using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribBaixaDevolucaoCompensacao
{
    public int BaDeCompId { get; set; }

    public long? BaDeId { get; set; }

    public long? ImoIddivida { get; set; }

    public long? DivEmpId { get; set; }

    public long? ConIddivida { get; set; }

    public decimal? CompTotalDivida { get; set; }

    public decimal? CompPrincipal { get; set; }

    public decimal? CompCorrMonetaria { get; set; }

    public decimal? CompJuros { get; set; }

    public decimal? CompMulta { get; set; }

    public decimal? CompMultaDa { get; set; }

    public decimal? CompDesconto { get; set; }

    public decimal? CompValor { get; set; }

    public long? BaiId { get; set; }

    public virtual TribBaixaDevolucao? BaDe { get; set; }
}
