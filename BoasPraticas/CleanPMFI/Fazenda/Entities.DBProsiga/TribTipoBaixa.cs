using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribTipoBaixa
{
    public int TipoBxId { get; set; }

    public string? TipoBxNome { get; set; }

    /// <summary>
    /// Tipo de baixa de controle interno do sistema.
    /// </summary>
    public string TipoBxContrInterno { get; set; } = null!;

    /// <summary>
    /// Este campo permite efetuar uma baixa em parcela unica sem baixar as parcelas normais
    /// </summary>
    public string TipoBxBaixaParcelasNormais { get; set; } = null!;

    /// <summary>
    /// Marca se o tipo de baixa permite recalcular dividas de imóveis.
    /// </summary>
    public string TipoBxPermiteRecalculo { get; set; } = null!;

    /// <summary>
    /// Marca se o tipo de baixa é considerado como lançamento, para controlar casos de &quot;BAIXA POR RECÁLCULO&quot; por exemplo, que são baixas realizadas pelo sistema para um novo lançamento da dívida. Esta checagem esta na SP: TribDividasRelPorAnoPeriodoLanc_SP.
    /// </summary>
    public string TipoBxConsiderarLancamento { get; set; } = null!;

    /// <summary>
    /// Descreve onde e quando utilizar o tipo de baixa
    /// </summary>
    public string? TipoBxDescricao { get; set; }

    /// <summary>
    /// Tipo de baixa utilizado para filtros em relatórios e formulários do módulo dos contadores.
    /// </summary>
    public string TipoBxModuloContador { get; set; } = null!;

    public int? GrupoId { get; set; }

    public virtual ICollection<Fzbaixa> Fzbaixas { get; set; } = new List<Fzbaixa>();

    public virtual ICollection<Fzdivida> Fzdivida { get; set; } = new List<Fzdivida>();

    public virtual ICollection<TribAlvFormula> TribAlvFormulas { get; set; } = new List<TribAlvFormula>();

    public virtual ICollection<TribCmtipoConstrucao> TribCmtipoConstrucaos { get; set; } = new List<TribCmtipoConstrucao>();

    public virtual ICollection<TribConfigLancHonorario> TribConfigLancHonorarios { get; set; } = new List<TribConfigLancHonorario>();

    public virtual ICollection<TribDepositoJudicial> TribDepositoJudicials { get; set; } = new List<TribDepositoJudicial>();

    public virtual ICollection<TribDividasImo> TribDividasImos { get; set; } = new List<TribDividasImo>();

    public virtual ICollection<TribEdificacoesIsencaoTrib> TribEdificacoesIsencaoTribs { get; set; } = new List<TribEdificacoesIsencaoTrib>();

    public virtual ICollection<TribIsencaoIncidencium> TribIsencaoIncidencia { get; set; } = new List<TribIsencaoIncidencium>();

    public virtual ICollection<TribLeisDesc> TribLeisDescs { get; set; } = new List<TribLeisDesc>();

    public virtual ICollection<TribSimuladosEmpresaDiv> TribSimuladosEmpresaDivs { get; set; } = new List<TribSimuladosEmpresaDiv>();

    public virtual ICollection<TribTapDestino> TribTapDestinos { get; set; } = new List<TribTapDestino>();

    public virtual ICollection<TribTipoBaixaTexto> TribTipoBaixaTextos { get; set; } = new List<TribTipoBaixaTexto>();

    public virtual ICollection<TribTipoIsencao> TribTipoIsencaos { get; set; } = new List<TribTipoIsencao>();
}
