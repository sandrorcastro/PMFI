using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    /// <summary>
    /// Cadastro e Manutenção de Motoristas de Empresas Permissionárias ou Autorizatárias. Cadastro devido a resolução 1971 de 25/047/2007 da Agencia Nacional de Transportes Terrestres, fundamentada nos termos do relatorio DFO 068 de24/04/2007. 
    /// </summary>
    public partial class Fzmotorista
    {
        public Fzmotorista()
        {
            Fzanttcontratos = new HashSet<Fzanttcontrato>();
        }

        /// <summary>
        /// Código de Identificação do Motorista
        /// </summary>
        public int FzmotoristaId { get; set; }
        /// <summary>
        /// Nome completo do Motorista. Campo Obrigatório.
        /// </summary>
        public string? FzmotoristaNome { get; set; }
        /// <summary>
        /// Número do Cadastro de Pessoa Física - CPF
        /// </summary>
        public string? Fzcpf { get; set; }
        /// <summary>
        /// Número do Registro Geral - RG
        /// </summary>
        public string? Fzrg { get; set; }
        /// <summary>
        /// Número da CNH (Carteira Nacional de Habilitação)
        /// </summary>
        public string? Fzcnhnumero { get; set; }
        /// <summary>
        /// Categoria da CNH
        /// </summary>
        public string? Fzcnhcategoria { get; set; }
        /// <summary>
        /// Data da Emissão da Carteira Nacional de Habilitação
        /// </summary>
        public DateTime? FzcnhdtEmissao { get; set; }
        /// <summary>
        /// Data de Vencimento da Carteira Nacional de Habilitação
        /// </summary>
        public DateTime? FzcnhdtVencto { get; set; }
        /// <summary>
        /// Tipo Sanguineo e Fator Rhesus do Condutor.
        /// </summary>
        public string? FztipoFatorSanguineo { get; set; }
        /// <summary>
        /// Certidão Negativa do registro de distribuição criminal estadual válida no momento do cadastramento e emitida por orgao competente da seção judiciaria do estado no qual o motorista é domiciliado e residente.
        /// </summary>
        public DateTime? FzdtCertCriminalEstadual { get; set; }
        /// <summary>
        /// Certidão Negativa do registro de distribuição criminal federal válida no momento do cadastramento e emitida por orgao competente da seção judiciaria do estado no qual o motorista é domiciliado e residente.
        /// </summary>
        public DateTime? FzdtCertCriminalFederal { get; set; }
        /// <summary>
        /// Endereço do motorista
        /// </summary>
        public string? Fzendereco { get; set; }
        /// <summary>
        /// Telefones do Motorista
        /// </summary>
        public string? Fzfone { get; set; }
        /// <summary>
        /// Nome da Mãe do Motorista
        /// </summary>
        public string? FznmMae { get; set; }
        /// <summary>
        /// Outras informações a respeito do Motorista
        /// </summary>
        public string? Fzobservacao { get; set; }
        public string? FztipoFoto { get; set; }
        public byte[]? Fzfoto { get; set; }

        public virtual ICollection<Fzanttcontrato> Fzanttcontratos { get; set; }
    }
}
