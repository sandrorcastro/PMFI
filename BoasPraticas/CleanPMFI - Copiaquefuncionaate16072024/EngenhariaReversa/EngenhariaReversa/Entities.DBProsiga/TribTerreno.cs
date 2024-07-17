using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribTerreno
    {
        public TribTerreno()
        {
            TribEdificacos = new HashSet<TribEdificaco>();
            TribTerrenoDimensaos = new HashSet<TribTerrenoDimensao>();
            TribTestadasTerrenos = new HashSet<TribTestadasTerreno>();
        }

        public long TerrenoId { get; set; }
        public int? QuadraId { get; set; }
        public string? TerrLote { get; set; }
        public int? JuriId { get; set; }
        public int? PedoId { get; set; }
        public int? LocQid { get; set; }
        public int? TopoId { get; set; }
        public int? FundoId { get; set; }
        public int? CalcaId { get; set; }
        public int? PatrId { get; set; }
        public int? VegeId { get; set; }
        public int? LimTid { get; set; }
        public int? InciId { get; set; }
        public decimal? TerrAreaTerreno { get; set; }
        public string? TerrReferenciaAnterior { get; set; }
        public int TerrPontosTerreno { get; set; }
        public string? QuadraLoteamento { get; set; }
        public string? LoteLoteamento { get; set; }
        public string? TipoCondominio { get; set; }
        public string? LoteCondominio { get; set; }
        public int? Loteamento { get; set; }
        public long? NumeroCadastroCanadas { get; set; }
        public decimal? AreaAbertaCoberta { get; set; }
        /// <summary>
        /// Valor Venal Terreno (trigger)
        /// </summary>
        public decimal? ValorVenalTerreno { get; set; }
        /// <summary>
        /// Observacoes sobre o terreno.
        /// </summary>
        public string? TerrObs { get; set; }
        public decimal? AreaUsoComum { get; set; }

        public virtual TribCalcadum? Calca { get; set; }
        public virtual TribFundoVale? Fundo { get; set; }
        public virtual TribIncidencium? Inci { get; set; }
        public virtual TribCondJuridica? Juri { get; set; }
        public virtual TribLimiteTestadum? LimT { get; set; }
        public virtual TribLocalizacaoQuadra? LocQ { get; set; }
        public virtual TribPatrimonio? Patr { get; set; }
        public virtual TribPedologium? Pedo { get; set; }
        public virtual TribQuadra? Quadra { get; set; }
        public virtual TribTopografium? Topo { get; set; }
        public virtual TribVegetacao? Vege { get; set; }
        public virtual ICollection<TribEdificaco> TribEdificacos { get; set; }
        public virtual ICollection<TribTerrenoDimensao> TribTerrenoDimensaos { get; set; }
        public virtual ICollection<TribTestadasTerreno> TribTestadasTerrenos { get; set; }
    }
}
