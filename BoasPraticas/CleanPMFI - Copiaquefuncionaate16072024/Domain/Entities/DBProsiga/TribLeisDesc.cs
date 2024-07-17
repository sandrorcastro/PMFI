using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribLeisDesc
    {
        public TribLeisDesc()
        {
            TribLeisDescTributos = new HashSet<TribLeisDescTributo>();
            TribTaps = new HashSet<TribTap>();
        }

        public long LeiDescId { get; set; }
        public DateTime? LeiDescData { get; set; }
        public long? LeiDescNumero { get; set; }
        public DateTime? LeiDescDe { get; set; }
        public DateTime? LeiDescAte { get; set; }
        public DateTime? LeiDescDividasVencidasAte { get; set; }
        public decimal LeiDescJurosAoMes { get; set; }
        public int? TipoTribId { get; set; }
        public long? TextoId { get; set; }
        /// <summary>
        /// contem o tipo de vencimento deve ser utilizado na geração das dividas do TAP (&apos;NENHUM&apos;,&apos;TABELA VENCIMENTO&apos;,&apos;DATA TAP&apos;,&apos;ULTIMO DIA UTIL&apos;)
        /// </summary>
        public string? LeiDescTipoVencimento { get; set; }
        public DateTime LeiDescDividasVencidasDe { get; set; }
        public decimal? LeiDescValorMinMoeda { get; set; }
        public short? Idmoeda { get; set; }
        public string LeiDescTipoCalcJuros { get; set; } = null!;
        /// <summary>
        /// Tipo de Baixa que busca para parcelamento
        /// </summary>
        public int? TipoBxId { get; set; }
        public string? LeiDescPadrao { get; set; }
        public string? LeiDescPermiteEntrada { get; set; }
        public decimal? LeiDescPercentualEntrada { get; set; }
        public string? LeiDescVerificaRescisao { get; set; }
        public string? LeiDescCertPositivaNegativa { get; set; }
        public DateTime? LeiDescVencEspecifico { get; set; }
        public string? LeiDescIncluiDivSuspensa { get; set; }
        public string? LeiDescIdLeisBloqueio { get; set; }
        public string? LeiDescCadastroFiltro { get; set; }
        public string? LeiDescIncluiDivNaoParc { get; set; }
        public bool? LeiDescSimulacaoPortal { get; set; }
        public string? LeiDescNmAmigavel { get; set; }
        public long? TextoIdexterno { get; set; }
        public decimal? LeiDescPercAdiant1Refis { get; set; }
        public decimal? LeiDescPercAdiant2Refis { get; set; }
        public short? LeiDescOrdenacao { get; set; }
        public string? LeiDescModuloContador { get; set; }
        public string? LeiDescModuloContribuinte { get; set; }
        public string LeiVisModuloContribuinte { get; set; } = null!;
        public string LeiDispApenasPrimParcela { get; set; } = null!;
        public string? LeiImprimirVencimento { get; set; }

        public virtual TribTexto? Texto { get; set; }
        public virtual TribTipoBaixa? TipoBx { get; set; }
        public virtual TribTipoTributo? TipoTrib { get; set; }
        public virtual ICollection<TribLeisDescTributo> TribLeisDescTributos { get; set; }
        public virtual ICollection<TribTap> TribTaps { get; set; }
    }
}
