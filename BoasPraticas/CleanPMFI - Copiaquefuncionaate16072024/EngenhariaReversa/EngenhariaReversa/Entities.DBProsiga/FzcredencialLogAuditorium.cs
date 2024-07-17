using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    /// <summary>
    /// Registro dos Valores da tabela FZCredencial quando sofre uma operação de Alteração ou  Remoção.
    /// </summary>
    public partial class FzcredencialLogAuditorium
    {
        /// <summary>
        /// Código de Identificação do Log de Credencial para Auditoria
        /// </summary>
        public int CredencialLogId { get; set; }
        /// <summary>
        /// Codigo de Identificacao do Credenciamento (Condutor/Empresa)
        /// </summary>
        public long? CredencialId { get; set; }
        /// <summary>
        /// Código de Identificação do Condutor do Veiculo.
        /// </summary>
        public long? ConId { get; set; }
        /// <summary>
        /// Codigo de Identificação do Veiculo Credenciado
        /// </summary>
        public long? FzveiId { get; set; }
        /// <summary>
        /// Tipo do Veículo sendo credenciado.
        /// </summary>
        public int? FztipoVeicId { get; set; }
        /// <summary>
        /// Código de Identificação do Ponto ao qual pertence o Veículo na data do Credenciamento. Extraido de VeiculosporPonto.
        /// </summary>
        public long? CredPontoId { get; set; }
        /// <summary>
        /// Código de Identificação do Proprietario do Veiculo na data do Credenciamento. Extraido do Veiculo.
        /// </summary>
        public long? CredProprietarioId { get; set; }
        /// <summary>
        /// Codigo de Identificação do Tipo do Credenciamento.  FZTipoCredenciamento --&gt; Permissionario / Colaborador / Turnante.
        /// </summary>
        public int? CredenTipoId { get; set; }
        /// <summary>
        /// Tipo da Autorização, podendo ser:&apos;Provisória  ou Definitiva.
        /// </summary>
        public string? CredenTipoAutorizacao { get; set; }
        /// <summary>
        /// Situação da Credencial,  (Ativa / Inativa / Permuta).
        /// </summary>
        public string? CredenSituacao { get; set; }
        /// <summary>
        /// Data Emissao Credencial
        /// </summary>
        public DateTime? CredenDtEmissao { get; set; }
        /// <summary>
        /// Data de Vencimento da Credencial
        /// </summary>
        public DateTime? CredenDtVencto { get; set; }
        /// <summary>
        /// Informações Complementares sobre a credencial.
        /// </summary>
        public string? CredenObs { get; set; }
        /// <summary>
        /// Categoria da Carteira de Motorista do Condutor do Veículo, na data do credenciamento.
        /// </summary>
        public string? CredCnhcategoria { get; set; }
        /// <summary>
        /// Data de Emissão da Carteira de Motorista do Condutor do Veículo, na data do credenciamento.
        /// </summary>
        public DateTime? CredCnhdtEmissao { get; set; }
        /// <summary>
        /// Data de Vencimento da Carteira de Motorista do Condutor do Veículo, na data do credenciamento.
        /// </summary>
        public DateTime? CredCnhdtValidade { get; set; }
        /// <summary>
        /// Data do Curso de Motorista por Tipo de Veículo Especifico, na data do credenciamento.
        /// </summary>
        public DateTime? CredCursoData { get; set; }
        /// <summary>
        /// Validade do Curso de Motorista, na data do credenciamento.
        /// </summary>
        public DateTime? CredCursoValidade { get; set; }
        /// <summary>
        /// Numero do NIT do Condutor na data do Credenciamento.
        /// </summary>
        public string? CredNitnumero { get; set; }
        /// <summary>
        /// Data de Emissão do NIT na data do credenciamento.
        /// </summary>
        public DateTime? CredNitdtEmissao { get; set; }
        /// <summary>
        /// Data de Validade do NIT, na data do credenciamento.
        /// </summary>
        public DateTime? CredNitdtValidade { get; set; }
        /// <summary>
        /// Data da Emissão da Certidão de Antecedentes Criminais Federal, na data do credenciamento.
        /// </summary>
        public DateTime? CredCertAntecCriminaisFedData { get; set; }
        /// <summary>
        /// Data de Emissão da Certidão de Antecedentes Criminais Estadual, na data do credenciamento.
        /// </summary>
        public DateTime? CredCertAntecCriminaisEstData { get; set; }
        /// <summary>
        /// Numero da Apólice de Seguro na data do Credenciamento.
        /// </summary>
        public string? CredSeguroApolice { get; set; }
        /// <summary>
        /// Data de Emissão do Seguro do Veículo, na data do credenciamento.
        /// </summary>
        public DateTime? CredSeguroDtEmissao { get; set; }
        /// <summary>
        /// Data Validade Seguro  Veículo, na data do credenciamento.
        /// </summary>
        public DateTime? CredSeguroDtValidade { get; set; }
        /// <summary>
        /// Numero da Credencial
        /// </summary>
        public long? CredenNum { get; set; }
        /// <summary>
        /// Data de Pagto da Taxa de INSS para exercício de atividades na data do Credenciamento.
        /// </summary>
        public DateTime? TaxaInssdtPagto { get; set; }
        /// <summary>
        /// Código de  Identificacao da renovação do alvara no Tribuno. 
        /// </summary>
        public int? RenovaId { get; set; }
        /// <summary>
        /// Código de Identificação do Usuário que efetuou a Operação.
        /// </summary>
        public int? LogUsuarioId { get; set; }
        /// <summary>
        /// Nome do Usuario que efetuou a Operação.
        /// </summary>
        public string? LogUsuarioNome { get; set; }
        /// <summary>
        /// Operação efetuada na tabela, podendo ser Alteração, Remoção ou Inserção.
        /// </summary>
        public string? LogOperacao { get; set; }
        /// <summary>
        /// Nome da Maquina origem da Operação.
        /// </summary>
        public string? LogHost { get; set; }
        /// <summary>
        /// Data da Operação de Remoção ou Alteração
        /// </summary>
        public DateTime? LogDataOperacao { get; set; }
    }
}
