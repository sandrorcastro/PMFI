using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribTipoBaixa
    {
        public TribTipoBaixa()
        {
            Fzbaixas = new HashSet<Fzbaixa>();
            Fzdivida = new HashSet<Fzdivida>();
            TribAlvFormulas = new HashSet<TribAlvFormula>();
            TribCmtipoConstrucaos = new HashSet<TribCmtipoConstrucao>();
            TribConfigLancHonorarios = new HashSet<TribConfigLancHonorario>();
            TribDepositoJudicials = new HashSet<TribDepositoJudicial>();
            TribDividasImos = new HashSet<TribDividasImo>();
            TribEdificacoesIsencaoTribs = new HashSet<TribEdificacoesIsencaoTrib>();
            TribIsencaoIncidencia = new HashSet<TribIsencaoIncidencium>();
            TribLeisDescs = new HashSet<TribLeisDesc>();
            TribSimuladosEmpresaDivs = new HashSet<TribSimuladosEmpresaDiv>();
            TribTapDestinos = new HashSet<TribTapDestino>();
            TribTipoBaixaTextos = new HashSet<TribTipoBaixaTexto>();
            TribTipoIsencaos = new HashSet<TribTipoIsencao>();
        }

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

        public virtual ICollection<Fzbaixa> Fzbaixas { get; set; }
        public virtual ICollection<Fzdivida> Fzdivida { get; set; }
        public virtual ICollection<TribAlvFormula> TribAlvFormulas { get; set; }
        public virtual ICollection<TribCmtipoConstrucao> TribCmtipoConstrucaos { get; set; }
        public virtual ICollection<TribConfigLancHonorario> TribConfigLancHonorarios { get; set; }
        public virtual ICollection<TribDepositoJudicial> TribDepositoJudicials { get; set; }
        public virtual ICollection<TribDividasImo> TribDividasImos { get; set; }
        public virtual ICollection<TribEdificacoesIsencaoTrib> TribEdificacoesIsencaoTribs { get; set; }
        public virtual ICollection<TribIsencaoIncidencium> TribIsencaoIncidencia { get; set; }
        public virtual ICollection<TribLeisDesc> TribLeisDescs { get; set; }
        public virtual ICollection<TribSimuladosEmpresaDiv> TribSimuladosEmpresaDivs { get; set; }
        public virtual ICollection<TribTapDestino> TribTapDestinos { get; set; }
        public virtual ICollection<TribTipoBaixaTexto> TribTipoBaixaTextos { get; set; }
        public virtual ICollection<TribTipoIsencao> TribTipoIsencaos { get; set; }
    }
}
