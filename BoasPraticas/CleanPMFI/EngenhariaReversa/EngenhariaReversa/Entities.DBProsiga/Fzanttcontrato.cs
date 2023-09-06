using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    /// <summary>
    /// Cadastro e Manutenção de Contratos entre Motoristas de Transporte de Turismo e Empresas de Turismo.
    /// </summary>
    public partial class Fzanttcontrato
    {
        public Fzanttcontrato()
        {
            FzacessoOperadorMotorista = new HashSet<FzacessoOperadorMotoristum>();
        }

        /// <summary>
        /// Código de Identificação do Contrato. Vinculo nao empregaticio entre Empresa e Motorista. 
        /// </summary>
        public int FzcontratoId { get; set; }
        /// <summary>
        /// Código de Identificação da Empresa.
        /// </summary>
        public long FzempresaId { get; set; }
        /// <summary>
        /// Código de Identificação do Motorista.
        /// </summary>
        public int? FzmotoristaId { get; set; }
        /// <summary>
        /// Data de Admissão do Motorista na Empresa de Transportes.
        /// </summary>
        public DateTime? FzdtAdmissao { get; set; }
        /// <summary>
        /// Data de Demissão do Motorista na Empresa de Transportes.
        /// </summary>
        public DateTime? FzdtDemissao { get; set; }
        /// <summary>
        /// Data da Validade da Permissão do Motorista para atuação em circuito internacional.
        /// </summary>
        public DateTime? FzdtValidade { get; set; }

        public virtual Contribuinte Fzempresa { get; set; } = null!;
        public virtual Fzmotorista? Fzmotorista { get; set; }
        public virtual ICollection<FzacessoOperadorMotoristum> FzacessoOperadorMotorista { get; set; }
    }
}
