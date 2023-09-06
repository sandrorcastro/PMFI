using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class MoveisEquipamento
    {
        public MoveisEquipamento()
        {
            BaixaMoveisEquipamentos = new HashSet<BaixaMoveisEquipamento>();
            CombustivelSaida = new HashSet<CombustivelSaidum>();
            ItensManutencaoMovEquips = new HashSet<ItensManutencaoMovEquip>();
            LocacaoMoveisEquipamentos = new HashSet<LocacaoMoveisEquipamento>();
            ManutencaoMoveisEquipamentos = new HashSet<ManutencaoMoveisEquipamento>();
            MovimentacaoAcessoriosMovEquipMoeMovEquipIdAntNavigations = new HashSet<MovimentacaoAcessoriosMovEquip>();
            MovimentacaoAcessoriosMovEquipMoeMovEquipIdAtualNavigations = new HashSet<MovimentacaoAcessoriosMovEquip>();
            MovimentacaoMoveisEquipamentos = new HashSet<MovimentacaoMoveisEquipamento>();
            TbDeprecicaoValorizacaos = new HashSet<TbDeprecicaoValorizacao>();
            AcesMovEquips = new HashSet<AcessoriosMoveisEquipamento>();
        }

        public long MoeMovEquipId { get; set; }
        public string? MoeCnpjmembro { get; set; }
        public long? MoeIdPlaqueta { get; set; }
        public long? MoeIdFornecedor { get; set; }
        public int? MoeIdModoAquisicao { get; set; }
        public long? MoeIdServidor { get; set; }
        public int? MoeIdRecursoFinanc { get; set; }
        public long? MoeIdLocalFisico { get; set; }
        public int? MoeAnoEmpenho { get; set; }
        public long? MoeNumEmpenho { get; set; }
        public string? MoeNumNotaFiscal { get; set; }
        public DateTime? MoeDataAquisicao { get; set; }
        public DateTime? MoeDtGarantia { get; set; }
        public decimal? MoeValor { get; set; }
        public string? MoeSerie { get; set; }
        public string? MoeEstCons { get; set; }
        public string? MoeDescricao { get; set; }
        public string? MoeObservacao { get; set; }
        public byte[]? MoeImgBem { get; set; }
        public decimal? MoeVlrComponentes { get; set; }
        public decimal? MoeVlrManutencao { get; set; }
        public string? MoePlaquetaAnt { get; set; }
        public long? ItemId { get; set; }
        public string? MoePossivelAbastecer { get; set; }
        public int? MoeIdCombustivel { get; set; }
        public short? MoeNrAnoLic { get; set; }
        public short? MoeNrLicitacao { get; set; }
        public short? MoeIdModalidade { get; set; }
        public short? MoeIdContaContabil { get; set; }
        public short? MoeIdTipoBens { get; set; }
        public string? MoeCdTombamento { get; set; }
        public DateTime? MoeDataEmpenho { get; set; }
        public DateTime? MoeDataIncorporacao { get; set; }
        public int? Ok { get; set; }

        public virtual ICollection<BaixaMoveisEquipamento> BaixaMoveisEquipamentos { get; set; }
        public virtual ICollection<CombustivelSaidum> CombustivelSaida { get; set; }
        public virtual ICollection<ItensManutencaoMovEquip> ItensManutencaoMovEquips { get; set; }
        public virtual ICollection<LocacaoMoveisEquipamento> LocacaoMoveisEquipamentos { get; set; }
        public virtual ICollection<ManutencaoMoveisEquipamento> ManutencaoMoveisEquipamentos { get; set; }
        public virtual ICollection<MovimentacaoAcessoriosMovEquip> MovimentacaoAcessoriosMovEquipMoeMovEquipIdAntNavigations { get; set; }
        public virtual ICollection<MovimentacaoAcessoriosMovEquip> MovimentacaoAcessoriosMovEquipMoeMovEquipIdAtualNavigations { get; set; }
        public virtual ICollection<MovimentacaoMoveisEquipamento> MovimentacaoMoveisEquipamentos { get; set; }
        public virtual ICollection<TbDeprecicaoValorizacao> TbDeprecicaoValorizacaos { get; set; }

        public virtual ICollection<AcessoriosMoveisEquipamento> AcesMovEquips { get; set; }
    }
}
