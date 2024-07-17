using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class VisaoBoletimCadImobiliario
{
    public long ConId { get; set; }

    public string? ConNome { get; set; }

    public string? ConNomeFantasia { get; set; }

    public string? ConCnpjcpf { get; set; }

    public string? Proprietario { get; set; }

    public string? Responsavel { get; set; }

    public string? Locatario { get; set; }

    public string? ConCep { get; set; }

    public string? ConTipoLograd { get; set; }

    public string? ConEndereco { get; set; }

    public string? ConNumero { get; set; }

    public string? ConComplemento { get; set; }

    public string? BaiNome { get; set; }

    public string? CidNome { get; set; }

    public string? CidUf { get; set; }

    public int LogradIdparalelaTransv { get; set; }

    public string? LogradTipoParalelaTransv { get; set; }

    public string? LogradNomeParalelaTransv { get; set; }

    public string? DescLoteamentoParalelaTransv { get; set; }

    public string? DescRegiaoParalelaTransv { get; set; }

    public long EdificacaoId { get; set; }

    public string? EdifMatricula { get; set; }

    public int? EdifNumOficio { get; set; }

    public string InscricaoImobiliaria { get; set; } = null!;

    public string? TerrReferenciaAnterior { get; set; }

    public long? EdifEdificacaoEnglobamento { get; set; }

    public int? EdifAnoConstrucao { get; set; }

    public decimal? TestadasMetragem { get; set; }

    public string? TestadasPrincipal { get; set; }

    public int LogradIdterreno { get; set; }

    public string? LogradTipoTerreno { get; set; }

    public string? LogradNomeTerreno { get; set; }

    public decimal? TerrAreaTerreno { get; set; }

    public decimal? EdifAreaConstruida { get; set; }

    public decimal? EdifAreaCoberta { get; set; }

    public int? CategId { get; set; }

    public string? CategNome { get; set; }

    public string? EdifNumeracao { get; set; }

    public string? EdifCaracteristica { get; set; }

    public string? EdifAlvara { get; set; }

    public long? DenoId { get; set; }

    public string? DenoNome { get; set; }

    public byte[]? DenoImagem { get; set; }

    public int EdifPontosEdificacao { get; set; }

    public int? EdifNumElevadores { get; set; }

    public int? EdifNumPavimento { get; set; }

    public int? EdifAndarConstrucao { get; set; }

    public string InscricaoImobiliariaGeo { get; set; } = null!;

    public decimal EdifFracaoIdealEdificacao { get; set; }

    public string? EdifComplemento { get; set; }

    public string? EdifNumAptoSalaLoja { get; set; }

    public string? EdifBloco { get; set; }

    public long? EdifJuntarAoCarne { get; set; }

    public long TerrenoId { get; set; }

    public int TerrPontosTerreno { get; set; }

    public long DimenId { get; set; }

    public decimal? DimenMetragem { get; set; }

    public string? DimenDescr { get; set; }

    public decimal? ValorVenalCalculo { get; set; }

    public int? OcupaId { get; set; }

    public string? OcupaNome { get; set; }

    public decimal? OcupaFator { get; set; }

    public int OcupaPontos { get; set; }

    public int? PatrId { get; set; }

    public string? PatrNome { get; set; }

    public decimal? PatrFator { get; set; }

    public int PatrPontos { get; set; }

    public int? InciId { get; set; }

    public string? InciNome { get; set; }

    public decimal? InciFator { get; set; }

    public int InciPontos { get; set; }

    public int? TopoId { get; set; }

    public string? TopoNome { get; set; }

    public decimal? TopoFator { get; set; }

    public int TopoPontos { get; set; }

    public int? SituacaoId { get; set; }

    public string? SituacaoNome { get; set; }

    public decimal? SituacaoFator { get; set; }

    public int? SituacaoPontos { get; set; }

    public int? PedoId { get; set; }

    public string? PedoNome { get; set; }

    public decimal? PedoFator { get; set; }

    public int PedoPontos { get; set; }

    public int? LimTid { get; set; }

    public string? LimTnome { get; set; }

    public decimal? LimTfator { get; set; }

    public int LimTpontos { get; set; }

    public int? CalcaId { get; set; }

    public string? CalcaNome { get; set; }

    public decimal? CalcaFator { get; set; }

    public int CalcaPontos { get; set; }

    public int? EquipId { get; set; }

    public string? EquipNome { get; set; }

    public decimal? EquipFator { get; set; }

    public int? EquipPontos { get; set; }

    public int? EstrutId { get; set; }

    public string? EstrutNome { get; set; }

    public decimal? EstrutFator { get; set; }

    public int? EstrutPontos { get; set; }

    public int? CobertId { get; set; }

    public string? CobertNome { get; set; }

    public decimal? CobertFator { get; set; }

    public int? CobertPontos { get; set; }

    public int? AcabExtId { get; set; }

    public string? AcabExtNome { get; set; }

    public decimal? AcabExtFator { get; set; }

    public int? AcabExtPontos { get; set; }

    public int? UtilizId { get; set; }

    public string? UtilizNome { get; set; }

    public decimal? UtilizFator { get; set; }

    public int? UtilizPontos { get; set; }

    public int? EstConservId { get; set; }

    public string? EstConservNome { get; set; }

    public decimal? EstConservFator { get; set; }

    public int? EstConservPontos { get; set; }

    public int? TipoConId { get; set; }

    public string? TipoConNome { get; set; }

    public decimal? TipoConFator { get; set; }

    public int? TipoConPontos { get; set; }

    public int? EsquadriasId { get; set; }

    public string? EsquadriasNome { get; set; }

    public decimal? EsquadriasFator { get; set; }

    public int? EsquadriasPontos { get; set; }

    public int? AcabIntId { get; set; }

    public string? AcabIntNome { get; set; }

    public decimal? AcabIntFator { get; set; }

    public int? AcabIntPontos { get; set; }

    public int? AgrupaId { get; set; }

    public string? AgrupaNome { get; set; }

    public decimal? AgrupaFator { get; set; }

    public int? AgrupaPontos { get; set; }

    public int? PosicaoId { get; set; }

    public string? PosicaoNome { get; set; }

    public decimal? PosicaoFator { get; set; }

    public int? PosicaoPontos { get; set; }

    public int? UsoId { get; set; }

    public string? UsoNome { get; set; }

    public decimal? UsoFator { get; set; }

    public int? UsoPontos { get; set; }

    public int? PisoId { get; set; }

    public string? PisoNome { get; set; }

    public decimal? PisoFator { get; set; }

    public int? PisoPontos { get; set; }

    public int? EletricaId { get; set; }

    public string? EletricaNome { get; set; }

    public decimal? EletricaFator { get; set; }

    public int? EletricaPontos { get; set; }

    public int? ForroId { get; set; }

    public string? ForroNome { get; set; }

    public decimal? ForroFator { get; set; }

    public int? ForroPontos { get; set; }

    public int? ParedeId { get; set; }

    public string? ParedeNome { get; set; }

    public decimal? ParedeFator { get; set; }

    public int? ParedePontos { get; set; }

    public int? JuriId { get; set; }

    public string? JuriNome { get; set; }

    public decimal? JuriFator { get; set; }

    public int JuriPontos { get; set; }

    public int? LocQid { get; set; }

    public string? LocQnome { get; set; }

    public decimal? LocQfator { get; set; }

    public int LocQpontos { get; set; }

    public int? FundoId { get; set; }

    public string? FundoNome { get; set; }

    public decimal? FundoFator { get; set; }

    public int FundoPontos { get; set; }

    public int? VegeId { get; set; }

    public string? VegeNome { get; set; }

    public decimal? VegeFator { get; set; }

    public int VegePontos { get; set; }
}
