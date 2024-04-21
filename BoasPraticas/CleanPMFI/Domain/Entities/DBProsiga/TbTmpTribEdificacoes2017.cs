using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TbTmpTribEdificacoes2017
    {
        public long EdificacaoId { get; set; }
        public long? TerrenoId { get; set; }
        public string? EdifMatricula { get; set; }
        public int? EdifNumOficio { get; set; }
        public string? EdifAlvara { get; set; }
        public string? EdifCaracteristica { get; set; }
        public string? EdifNumeracao { get; set; }
        public long? DenoId { get; set; }
        public long? EdifEdificacaoEnglobamento { get; set; }
        public DateTime? EdifDtUltTransfPropriedade { get; set; }
        public DateTime? EdifDtInicioConstrucao { get; set; }
        public DateTime? EdifDtParalizacaoConstrucao { get; set; }
        public int? AgrupaId { get; set; }
        public int? AcabIntId { get; set; }
        public int? SituacaoId { get; set; }
        public int? PosicaoId { get; set; }
        public int? UsoId { get; set; }
        public int? UtilizId { get; set; }
        public int? PisoId { get; set; }
        public int? EletricaId { get; set; }
        public int? ForroId { get; set; }
        public int? CobertId { get; set; }
        public int? AcabExtId { get; set; }
        public int? CategId { get; set; }
        public int? EstrutId { get; set; }
        public int? TipoConId { get; set; }
        public int? OcupaId { get; set; }
        public int? EdifNumElevadores { get; set; }
        public int? EdifAnoConstrucao { get; set; }
        public int? EdifNumPavimento { get; set; }
        public int? EdifAndarConstrucao { get; set; }
        public decimal? EdifAreaConstruida { get; set; }
        public decimal? EdifAreaCoberta { get; set; }
        public string EdifContinuacaoTerreno { get; set; } = null!;
        public string? EdifEconomia { get; set; }
        public string InscricaoImobiliaria { get; set; } = null!;
        public string InscricaoImobiliariaGeo { get; set; } = null!;
        public decimal EdifFracaoIdealEdificacao { get; set; }
        public int? EdifPontosEdificacao { get; set; }
        public string? EdifComplemento { get; set; }
        public string? EdifNumAptoSalaLoja { get; set; }
        public string? EdifBloco { get; set; }
        public int? ParedeId { get; set; }
        public int? EsquadriasId { get; set; }
        public int? EstConservId { get; set; }
        public decimal? ValorVenalCalculo { get; set; }
        public long? NumeroCadastroCanadas { get; set; }
        public int? UnidadeLote { get; set; }
        public long? EdifJuntarAoCarne { get; set; }
        public decimal? ValorVenalEdificacao { get; set; }
        public string? EdifSituacao { get; set; }
        public int? InciId { get; set; }
        public string? UsuarioInclusao { get; set; }
        public DateTime? DataInclusao { get; set; }
        public int? LogradId { get; set; }
        public int? Idloteamento { get; set; }
        public string? EdifCep { get; set; }
        public long? ProcId { get; set; }
        public string? EdifMotivoAlteracao { get; set; }
        public DateTime? EdifDtMatricula { get; set; }
        public string? EdifCentroGrauLon { get; set; }
        public string? EdifCentroGrauLat { get; set; }
        public int? Idplanta { get; set; }
        public decimal? ValorVenalTerrenoParaEdificacao { get; set; }
        public string? EdifObs { get; set; }
    }
}
