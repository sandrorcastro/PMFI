using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribLancImpostoImo
    {
        public TribLancImpostoImo()
        {
            TribLancImpostoImoComposicaos = new HashSet<TribLancImpostoImoComposicao>();
        }

        public int LanImpId { get; set; }
        public int LanImpImoAno { get; set; }
        public long EdificacaoId { get; set; }
        public string? InscricaoImobiliaria { get; set; }
        public string? InscricaoImobiliariaGeo { get; set; }
        public int? TipoTribId { get; set; }
        public string? TipoTribSiglaTributo { get; set; }
        public string? TipoTribNome { get; set; }
        public string? LanImpImoProprietario { get; set; }
        public string? EdifComplementoImo { get; set; }
        public decimal? TerrAreaTerreno { get; set; }
        public decimal? ValorVenalTerreno { get; set; }
        public decimal? EdifAreaConstruida { get; set; }
        public decimal? ValorVenalEdificacao { get; set; }
        /// <summary>
        /// Valor Venal para o Calculo do IPTU (ja considerado a fração do Terreno)
        /// </summary>
        public decimal? ValorVenalCalculo { get; set; }
        /// <summary>
        /// domínio: Predial / Territorial
        /// </summary>
        public string? EdifCaracteristica { get; set; }
        public int? EdifPontosEdificacao { get; set; }
        public string? LanImpImoCategoria { get; set; }
        public int? EdifAnoConstrucao { get; set; }
        public string? LanImpImoTipoConstrucao { get; set; }
        public string? LanImpImoEstrutura { get; set; }
        public string? LanImpImoOcupacao { get; set; }
        public string? LanImpImoUtilizacao { get; set; }
        public int? LanImpImoQtdeParcelas { get; set; }
        public decimal? LanImpImoValorParcela { get; set; }
        public DateTime? LanImpImoVencUnica1 { get; set; }
        public DateTime? LanImpImoVencUnica2 { get; set; }
        public DateTime? LanImpImoVencParc1 { get; set; }
        public decimal? LanImpImoValorUnica1 { get; set; }
        public decimal? LanImpImoValorUnica2 { get; set; }
        public int? TipoBxId { get; set; }
        public string? TipoBxNome { get; set; }
        public int? SimuId { get; set; }
        public short? RolTipoId { get; set; }
        public string? LanImpImoResponsavel { get; set; }

        public virtual ICollection<TribLancImpostoImoComposicao> TribLancImpostoImoComposicaos { get; set; }
    }
}
