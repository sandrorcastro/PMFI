using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class Fzveiculo
    {
        public Fzveiculo()
        {
            FzacessoOperadorVeiculos = new HashSet<FzacessoOperadorVeiculo>();
            FzautoInfracos = new HashSet<FzautoInfraco>();
            FzcondutoresVeiculos = new HashSet<FzcondutoresVeiculo>();
            FzcredencialAncients = new HashSet<FzcredencialAncient>();
            Fzcredencials = new HashSet<Fzcredencial>();
            Fzdivida = new HashSet<Fzdivida>();
            FzveiculoPorPontos = new HashSet<FzveiculoPorPonto>();
            FzveiculosFotos = new HashSet<FzveiculosFoto>();
            FzveiculosMovs = new HashSet<FzveiculosMov>();
            FzvistoriaVeiculos = new HashSet<FzvistoriaVeiculo>();
        }

        /// <summary>
        /// Código de Identificação do Veiculo.
        /// </summary>
        public long FzveiId { get; set; }
        /// <summary>
        /// Código de Identificação do Tipo do Veículo. Classificação do Veículo segundo sua atividade comercial como Turismo, Taxi ou Outros.
        /// </summary>
        public int? FztipoVeicId { get; set; }
        /// <summary>
        /// Os números e letras que compõem a numeração do chassi possuem regras que foram implantadas na década de 80 (ISO 3779) e servem para todos os fabricantes de veículos instalados em qualquer lugar do mundo. No Brasil essa numeração passou a valer a partir de 1986/87 quando as motos começaram a ter dois números gravados iguais para dificultar fraudes. composto de 17 dígitos o VIN (vehicle identification number) é dividido em quatro partes que quando decifradas podem informar dados sobre o fabricante, o modelo e o ano de fabricação.
        /// </summary>
        public string? Chassi { get; set; }
        /// <summary>
        /// Indica se o Chassi foi Remarcado. Desgate, Ferrugem, Batida, Roubo ou Furto podem ocasionar danos no Veículo e se esses danos forem na marcação do chassi este pode exigir remarcação.
        /// </summary>
        public bool ChassiRemarcado { get; set; }
        /// <summary>
        /// Número sob o qual esta inscrito o Veículo no RENAVAM(Registro Nacional de Veículos Automotores).
        /// </summary>
        public string? FzcodRenavam { get; set; }
        /// <summary>
        /// Número da Placa do Veículo. Placas de identificação de veículos no Brasil são emitidas pelos Departamentos Estaduais de Trânsito (DETRAN) de cada unidade da Federação, seguindo uma sequência única para todo o país.
        /// </summary>
        public string? Placa { get; set; }
        /// <summary>
        /// Cor da placa do veículo. Foztrans utiliza Categorias de Veiculo: Particular, Aluguel ou Nenhuma  (Veículo ainda nao possui Placa). As cores da placa são as designadas para cada catgegoria sendo do Mercosul ou Antgeriores.
        /// </summary>
        public string? VeiCorPlaca { get; set; }
        /// <summary>
        /// Cor da placa do veículo, pode ser Branca, Vermelha e etc...
        /// </summary>
        public string? VeiCorPlacaLetraOriginal { get; set; }
        /// <summary>
        /// Código de Identificação da Especie do Veiculo.
        /// </summary>
        public int? VeiEspecie { get; set; }
        /// <summary>
        /// Código de Identificação da Marca do Veiculo.
        /// </summary>
        public int? VeiMarca { get; set; }
        /// <summary>
        /// Código de Identificação do Modelo do Veiculo.
        /// </summary>
        public int? VeiModelo { get; set; }
        /// <summary>
        /// Código de Identificação do Proprietario do Veiculo. 
        /// </summary>
        public long? PropId { get; set; }
        /// <summary>
        /// Código de Identificação da Empresa Arrendataria. Pessoa Juridica que por meio de contrato de arrendamento recebe um veiculo, pagando pelo seu uso.
        /// </summary>
        public long? EmprArrendatariaId { get; set; }
        /// <summary>
        /// Código de Identificação do Combustivel do Veículo.
        /// </summary>
        public int? VeiCombustivel { get; set; }
        /// <summary>
        /// Ano de Fabricação do Veículo.
        /// </summary>
        public int? AnoFabric { get; set; }
        /// <summary>
        /// Ano do Modelo do Veículo.
        /// </summary>
        public int? AnoModelo { get; set; }
        /// <summary>
        /// Cor Predominante do Veículo.
        /// </summary>
        public string? CorPredominante { get; set; }
        /// <summary>
        /// Cor Predominante do Veículo.
        /// </summary>
        public string? CorPredOriginal { get; set; }
        /// <summary>
        /// Capacidade do Veículo. Quantidade de Pessoas que o mesmo esta autorizado a transportar, cfe determinação do CONTRAN.
        /// </summary>
        public int? Capacidade { get; set; }
        /// <summary>
        /// Potencia do Veículo. Normalmente traduzida em CV(Cavalos Vapor).
        /// </summary>
        public int? Potencia { get; set; }
        /// <summary>
        /// Quantidade de portas do carro.
        /// </summary>
        public int? VeiNumPortas { get; set; }
        /// <summary>
        /// Uso Sistema
        /// </summary>
        public string? VeiSituacao { get; set; }
        /// <summary>
        /// Código de Identificação da Cidade de Emplacamento do Veículo.
        /// </summary>
        public int? CidadeId { get; set; }
        /// <summary>
        /// Nome do País no qual foi emplacado o Veículo.
        /// </summary>
        public string? PaisEmplacamento { get; set; }
        /// <summary>
        /// Nome do País no qual foi emplacado o Veículo.
        /// </summary>
        public string? PaisEmplacamentoCorrigido { get; set; }
        /// <summary>
        /// País de origem do veículo.
        /// </summary>
        public string? VeiPaisOrigem { get; set; }
        /// <summary>
        /// País de origem do veículo.
        /// </summary>
        public string? VeiPaisOrigemCorrigido { get; set; }
        /// <summary>
        /// Código de Identificação do Processo ao que se refere o Veículo.
        /// </summary>
        public long? VeiProcessoId { get; set; }
        public string? VeiObs { get; set; }
        /// <summary>
        /// Uso Sistema
        /// </summary>
        public string? AutiCorInfracao { get; set; }
        /// <summary>
        /// Código de Identificação da Classificação do Veículo. Classificação do Veículo segundo sua atividade comercial como Turismo, Taxi ou Outros.
        /// </summary>
        public int? FzclassifVeiId { get; set; }
        /// <summary>
        /// Data de Baixa(Desligamento) do veículo.
        /// </summary>
        public DateTime? VeiDataBaixa { get; set; }
        /// <summary>
        /// Data de inclusão do veículo.
        /// </summary>
        public DateTime? VeiDataInclusao { get; set; }
        /// <summary>
        /// Data da Ultima Atualização do Veículo.
        /// </summary>
        public DateTime? VeiDataUltAlt { get; set; }
        /// <summary>
        /// Código de Identificação da Ultima Vistoria do Veículo.
        /// </summary>
        public long? UltimaVistId { get; set; }
        /// <summary>
        /// Data da Liberação do Veículo para Vistoria
        /// </summary>
        public DateTime? VeiDtLibVistoria { get; set; }

        public virtual Contribuinte? EmprArrendataria { get; set; }
        public virtual Fzclassificacao? FzclassifVei { get; set; }
        public virtual FztipoVeiculo? FztipoVeic { get; set; }
        public virtual Contribuinte? Prop { get; set; }
        public virtual Combustivel? VeiCombustivelNavigation { get; set; }
        public virtual Especie? VeiEspecieNavigation { get; set; }
        public virtual Marca? VeiMarcaNavigation { get; set; }
        public virtual Modelo? VeiModeloNavigation { get; set; }
        public virtual ICollection<FzacessoOperadorVeiculo> FzacessoOperadorVeiculos { get; set; }
        public virtual ICollection<FzautoInfraco> FzautoInfracos { get; set; }
        public virtual ICollection<FzcondutoresVeiculo> FzcondutoresVeiculos { get; set; }
        public virtual ICollection<FzcredencialAncient> FzcredencialAncients { get; set; }
        public virtual ICollection<Fzcredencial> Fzcredencials { get; set; }
        public virtual ICollection<Fzdivida> Fzdivida { get; set; }
        public virtual ICollection<FzveiculoPorPonto> FzveiculoPorPontos { get; set; }
        public virtual ICollection<FzveiculosFoto> FzveiculosFotos { get; set; }
        public virtual ICollection<FzveiculosMov> FzveiculosMovs { get; set; }
        public virtual ICollection<FzvistoriaVeiculo> FzvistoriaVeiculos { get; set; }
    }
}
