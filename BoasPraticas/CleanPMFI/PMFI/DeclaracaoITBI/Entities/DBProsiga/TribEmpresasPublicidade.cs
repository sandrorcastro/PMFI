using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribEmpresasPublicidade
{
    public int Id { get; set; }

    public long EmprCmc { get; set; }

    public int? PublicTipoId { get; set; }

    /// <summary>
    /// Valor que será multiplicado pela Qtde de UF dos Tipos de Calculo e pela qtde de unidade de medida
    /// </summary>
    public decimal? PublicValorBaseCalculo { get; set; }

    /// <summary>
    /// Quantidade da unidade de medida
    /// </summary>
    public decimal? PublicQtdeUnidMed { get; set; }

    public int? NrVistoriaNumero { get; set; }

    public int? NrVistoriaAno { get; set; }

    public decimal? NrAreaAberta { get; set; }

    public decimal? NrAreaCoberta { get; set; }

    public int? PublicAno { get; set; }

    public virtual TribEmpresa EmprCmcNavigation { get; set; } = null!;

    public virtual TribTipoPublicidade? PublicTipo { get; set; }
}
