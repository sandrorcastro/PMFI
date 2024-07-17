using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribItbiedif
    {
        public TribItbiedif()
        {
            TribItbicompradores = new HashSet<TribItbicompradore>();
            TribItbivendedores = new HashSet<TribItbivendedore>();
        }

        public long ItbiedifId { get; set; }
        public long Itbiid { get; set; }
        public long EdificacaoId { get; set; }
        public long? ImoIddivida { get; set; }
        public decimal? ItbiedifPercTransacao { get; set; }
        public decimal? ItbiedifAreaConstr { get; set; }
        public decimal? ItbiedifVlrVenalIptu { get; set; }
        public decimal? ItbiedifVlrDeclarado { get; set; }
        public string? ItbiedifFinanciado { get; set; }
        public decimal? ItbiedifBaseCalcFin { get; set; }
        public decimal? ItbiedifAliqFinanc { get; set; }
        public decimal? ItbiedifVlrDevido { get; set; }
        public DateTime? ItbiedifDataVenc { get; set; }
        public int? ItbiedifAnoDiv { get; set; }
        public int? ItbiedifSubDivida { get; set; }
        public int? ItbiedifMesDivida { get; set; }
        public int? ItbiedifParc { get; set; }
        public int? TipoTribId { get; set; }
        public string? ItbiedifTipoConstrucao { get; set; }
        public string? ItbiedifObservacao { get; set; }
        public decimal? ItbiedifBaseCalcImovel { get; set; }
        public string? ItbisomaEconomias { get; set; }
        public string? Itbiendereco { get; set; }
        public string? ItbiinscIncra { get; set; }
        public decimal? ItbiareaTotalImo { get; set; }
        public long? ConIddivida { get; set; }
        public string? Matricula { get; set; }
        public decimal? ItbiedifPercTransmitir { get; set; }
        public DateTime? ItbiedifDtMinhaCasa { get; set; }
        public string? InscricaoImobiliaria { get; set; }
        public string? PStrEdifEnderecoCompleto { get; set; }
        public string? EdifMatricula { get; set; }
        public string? EdifCaracteristica { get; set; }
        public long? TerrenoId { get; set; }
        public int? Idloteamento { get; set; }
        public string? QuadraLoteamento { get; set; }
        public int? Loteamento { get; set; }
        public string? TerrReferenciaAnterior { get; set; }
        public string? InscricaoImobiliariaGeo { get; set; }
        public decimal? TerrAreaTerreno { get; set; }
        public string? LoteLoteamento { get; set; }
        public int? QuadraId { get; set; }
        public string? PStredifBairro { get; set; }
        public decimal? AreaAbertaCoberta { get; set; }
        public int? LogradId { get; set; }
        public long? DenoId { get; set; }
        public string? EdifNumeracao { get; set; }
        public string? EdifComplemento { get; set; }
        public int? EdifAndarConstrucao { get; set; }
        public decimal? EdifAreaConstruida { get; set; }
        public string? EdifBloco { get; set; }
        public string? EdifNumAptoSalaLoja { get; set; }
        public decimal? EdifAreaCoberta { get; set; }

        public virtual TribDividasContribuinte? ConIddividaNavigation { get; set; }
        public virtual TribEdificaco Edificacao { get; set; } = null!;
        public virtual TribDividasImo? ImoIddividaNavigation { get; set; }
        public virtual TribItbi Itbi { get; set; } = null!;
        public virtual TribTipoTributo? TipoTrib { get; set; }
        public virtual ICollection<TribItbicompradore> TribItbicompradores { get; set; }
        public virtual ICollection<TribItbivendedore> TribItbivendedores { get; set; }
    }
}
