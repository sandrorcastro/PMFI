using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class FzveiculosMov
    {
        /// <summary>
        /// Código de Identificação da Movimentação de Veiculos
        /// </summary>
        public long MovVeiId { get; set; }
        /// <summary>
        /// Código de Identificação do Veículo relacionado a este Movimento.
        /// </summary>
        public long? FzveiId { get; set; }
        /// <summary>
        /// Código de Identificação do Processo relacionado a este Movimento.
        /// </summary>
        public int? ProcessoId { get; set; }
        /// <summary>
        /// Código de Identificação do Proprietário do Veículo
        /// </summary>
        public long? PropId { get; set; }
        /// <summary>
        /// Código de Identificação do Ponto ao qual o Veículo pertence.
        /// </summary>
        public long? FzpontoId { get; set; }
        /// <summary>
        /// Tipo da Movimentação do Veículo
        /// </summary>
        public string? FztipoMovimento { get; set; }
        public int? MovTipoSeguroId { get; set; }
        /// <summary>
        /// Tipo do Seguro do Veiculo. Pode ser: Apólice ou Declaração.
        /// </summary>
        public string? MovVeiTipoSeguro { get; set; }
        /// <summary>
        /// Numero do Decreto de Permissão de funcionamento do veículo ou Número do Seguro do Veiculo.
        /// </summary>
        public string? MovVeiDocNum { get; set; }
        /// <summary>
        /// Data da Movimentação do Veículo.
        /// </summary>
        public DateTime? MovVeiData { get; set; }
        /// <summary>
        /// Data de Termino de Eventos como Cobertura de Seguros 
        /// </summary>
        public DateTime? MovVeiDataFim { get; set; }
        /// <summary>
        /// Outras informações a respeito da movimentação do Veículo.
        /// </summary>
        public string? FzmovVeiObs { get; set; }

        public virtual Fzveiculo? Fzvei { get; set; }
        public virtual Contribuinte? Prop { get; set; }
    }
}
