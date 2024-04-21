using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class Veiculo
    {
        public Veiculo()
        {
            Abastecimentos = new HashSet<Abastecimento>();
            Acessorios = new HashSet<Acessorio>();
            CombustivelSaida = new HashSet<CombustivelSaidum>();
            ItensManutencaos = new HashSet<ItensManutencao>();
            LocacaoFrota = new HashSet<LocacaoFrotum>();
            ManutencaoVeiculos = new HashSet<ManutencaoVeiculo>();
            MovVeiculos = new HashSet<MovVeiculo>();
            TbDeprecicaoValorizacaos = new HashSet<TbDeprecicaoValorizacao>();
            VeiculosBaixados = new HashSet<VeiculosBaixado>();
            VeiculosSeguros = new HashSet<VeiculosSeguro>();
            XFrotaOrdensServicos = new HashSet<XFrotaOrdensServico>();
            Combustivels = new HashSet<Combustivel>();
        }

        public long VeiculoId { get; set; }
        public string? VeiEmpenhoFilial { get; set; }
        public long? VeiPlaquetaId { get; set; }
        public string? VeiCodLocalVeic { get; set; }
        public int? VeiModoAquisicaoId { get; set; }
        public int? VeiRecursoFinId { get; set; }
        public long? VeiServRespId { get; set; }
        public long? VeiLocalFisicoId { get; set; }
        public long? VeicItemId { get; set; }
        public long? VeiEmpenhoFornecedorId { get; set; }
        public long? VeiEmpenhoNum { get; set; }
        public int? VeiEmpenhoAno { get; set; }
        public string? VeiNumNotaFiscal { get; set; }
        public DateTime? VeiDataAquisicao { get; set; }
        public DateTime? VeiVenctoGarantia { get; set; }
        public string? VeiPlacaPrefixo { get; set; }
        public string? VeiPlacaNumero { get; set; }
        public int? VeiNumPassageiros { get; set; }
        public string? VeiCorPredominante { get; set; }
        public int? VeiPortas { get; set; }
        public int? VeiPotencia { get; set; }
        public string? VeiPotenciaUn { get; set; }
        public int? VeiCilindrada { get; set; }
        public int? VeiAnoFabricacao { get; set; }
        public int? VeiAnoModelo { get; set; }
        public string? VeiNumChassi { get; set; }
        public string? VeiCodRenavam { get; set; }
        public decimal? VeiKmaquisicao { get; set; }
        public decimal? VeiValor { get; set; }
        public string? VeiEstadoConservacao { get; set; }
        public string? VeiDescricao { get; set; }
        public string? VeiObservacao { get; set; }
        public byte[]? VeiImgVeiculo { get; set; }
        public decimal? VeiKmAtual { get; set; }
        public decimal? VeiVlrComponentes { get; set; }
        public decimal? VeiVlrManutencao { get; set; }
        public short? VeiNrAnoLic { get; set; }
        public short? VeiNrLicitacao { get; set; }
        public short? VeiIdModalidade { get; set; }
        public short? VeiIdContaCantabil { get; set; }
        public short? VeiIdTipoBens { get; set; }
        public string? VeiCdTombamento { get; set; }

        public virtual Plaquetum? Vei { get; set; }
        public virtual VeiculosIten? VeicItem { get; set; }
        public virtual ICollection<Abastecimento> Abastecimentos { get; set; }
        public virtual ICollection<Acessorio> Acessorios { get; set; }
        public virtual ICollection<CombustivelSaidum> CombustivelSaida { get; set; }
        public virtual ICollection<ItensManutencao> ItensManutencaos { get; set; }
        public virtual ICollection<LocacaoFrotum> LocacaoFrota { get; set; }
        public virtual ICollection<ManutencaoVeiculo> ManutencaoVeiculos { get; set; }
        public virtual ICollection<MovVeiculo> MovVeiculos { get; set; }
        public virtual ICollection<TbDeprecicaoValorizacao> TbDeprecicaoValorizacaos { get; set; }
        public virtual ICollection<VeiculosBaixado> VeiculosBaixados { get; set; }
        public virtual ICollection<VeiculosSeguro> VeiculosSeguros { get; set; }
        public virtual ICollection<XFrotaOrdensServico> XFrotaOrdensServicos { get; set; }

        public virtual ICollection<Combustivel> Combustivels { get; set; }
    }
}
