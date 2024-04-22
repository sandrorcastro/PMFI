using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    /// <summary>
    /// Tabela de Proprietarios de Veiculos. 
    /// </summary>
    public partial class FzcondutoresVeiculo
    {
        /// <summary>
        /// Código de Identificação do Proprietário do Veiculo. Condutores estarão somente na Credencial
        /// </summary>
        public long PropId { get; set; }
        /// <summary>
        /// Código de Identificação do Veiculo
        /// </summary>
        public long FzveiId { get; set; }
        /// <summary>
        /// Número de identificação do cartão, geralmente usado por taxistas.
        /// </summary>
        public string? CondNumCartao { get; set; }
        /// <summary>
        /// Tipo Sanguineo e Fator Rhesus do Condutor.
        /// </summary>
        public string? CondTipoFatorSanguineo { get; set; }
        /// <summary>
        /// Código de Identificação do Processo relacionado a inclusao do Condutor
        /// </summary>
        public int? ProcessoId { get; set; }

        public virtual Fzveiculo Fzvei { get; set; } = null!;
        public virtual Contribuinte Prop { get; set; } = null!;
    }
}
