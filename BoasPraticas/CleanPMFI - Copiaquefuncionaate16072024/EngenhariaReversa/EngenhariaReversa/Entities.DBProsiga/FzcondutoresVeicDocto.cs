using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class FzcondutoresVeicDocto
    {
        /// <summary>
        /// Código de Identificação do Condutor.
        /// </summary>
        public long ConId { get; set; }
        /// <summary>
        /// Número da CNH. A CNH atual contém fotografia e os números dos principais documentos do condutor, servindo como documento de identidade em todo o território nacional.
        /// </summary>
        public string Cnhnumero { get; set; } = null!;
        /// <summary>
        /// Categoria da Carteira de Habilitação. Documento oficial que no Brasil atesta a aptidão de um cidadão para conduzir veículos, sendo de porte obrigatório ao condutor do veículo.
        /// </summary>
        public string? Cnhcategoria { get; set; }
        /// <summary>
        /// Local do registro da CNH ou Cidade Brasileira onde a CNH foi emitida.
        /// </summary>
        public string? Cnhlocal { get; set; }
        /// <summary>
        /// Unidade federativa da CNH ou Estado Brasileiro onde a CNH foi emitida.
        /// </summary>
        public string? Cnhuf { get; set; }
        /// <summary>
        /// Data da Emissão da Carteira de Habilitação.
        /// </summary>
        public DateTime? CnhdtEmissao { get; set; }
        /// <summary>
        /// Data do Vencimento da Carteira de Habilitação.
        /// </summary>
        public DateTime? CnhdtVencto { get; set; }
        /// <summary>
        /// Identifica através de SIM ou NÃO, se o condutor trabalha profissionalmente como Motorista de Veículo.
        /// </summary>
        public string? ExerceAtivRemunerada { get; set; }
        /// <summary>
        /// Tipo Sanguineo e Fator Rhesus do Condutor.
        /// </summary>
        public string? TipoFatorSanguineo { get; set; }
        /// <summary>
        /// Data do Curso de Motorista, sendo que cada Tipo de Veículo/Atividade tem seu curso específico.
        /// </summary>
        public DateTime? CursoData { get; set; }
        /// <summary>
        /// Validade do Curso de Motorista.
        /// </summary>
        public DateTime? CursoValidade { get; set; }
        /// <summary>
        /// Define qual Tipo de Curso o Condutor deve fazer para exercer sua Atividade.  Está alinhado ao Tipo de Veículo que irá conduzir.
        /// </summary>
        public string? CursoTipo { get; set; }
        /// <summary>
        /// Data da Emissão da Certidão de Antecedentes Criminais Federal
        /// </summary>
        public DateTime? CertAntecCrimFedData { get; set; }
        /// <summary>
        /// Data da Emissão da Certidão de Antecedentes Criminais Estadual
        /// </summary>
        public DateTime? CertAntecCrimEstData { get; set; }
        /// <summary>
        /// Data de Pagto da Taxa de INSS para Exercício de Atividade.
        /// </summary>
        public DateTime? TaxaInssdtPagto { get; set; }
        /// <summary>
        /// Numero de Inscrição do Trabalhador no Regime Geral de Previdência Social. Confunde-se também com o PIS ou PASEP.
        /// </summary>
        public string? Nitnumero { get; set; }
        /// <summary>
        /// Data da Emissão do NIT.
        /// </summary>
        public DateTime? NitdtEmissao { get; set; }
        /// <summary>
        /// Data do Vencimento do NIT.
        /// </summary>
        public DateTime? NitdtVencto { get; set; }
        /// <summary>
        /// Relação das Pendencias do Condutor do Veiculo
        /// </summary>
        public string? CondutorPendencias { get; set; }
        /// <summary>
        /// Inofrmações Adicionais a respeito dos Documentos do Condutor
        /// </summary>
        public string? Observacao { get; set; }

        public virtual Contribuinte Con { get; set; } = null!;
    }
}
