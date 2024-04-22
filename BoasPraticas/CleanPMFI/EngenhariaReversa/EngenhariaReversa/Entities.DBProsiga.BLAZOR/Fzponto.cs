using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class Fzponto
    {
        public Fzponto()
        {
            FzcredencialAncients = new HashSet<FzcredencialAncient>();
            Fzcredencials = new HashSet<Fzcredencial>();
            FzpontosMovs = new HashSet<FzpontosMov>();
            FztermoCredenciamentos = new HashSet<FztermoCredenciamento>();
            FzveiculoPorPontos = new HashSet<FzveiculoPorPonto>();
        }

        /// <summary>
        /// Código de Identificação do Ponto.
        /// </summary>
        public long FzpontoId { get; set; }
        /// <summary>
        /// Nome do Ponto.
        /// </summary>
        public string? FzpontoNome { get; set; }
        /// <summary>
        /// Código de Identificação da Empresa no Cadastro de Contribuintes.
        /// </summary>
        public int? FzconId { get; set; }
        /// <summary>
        /// Tipo do Ponto, podendo referenciar-se a  1-Escolar, 2-Turismo 3-Taxi, 4-Moto-Taxi, 5-Frete, 23-Aplicativos, 20-Moto-Frete ou Outros.
        /// </summary>
        public int? FztipoPontoId { get; set; }
        /// <summary>
        /// Número do Ponto, conforme especificação  no decreto de criação do ponto.
        /// </summary>
        public int? FzpontoNumDec { get; set; }
        /// <summary>
        /// Abreviatura do Ponto
        /// </summary>
        public string? FzabrevPonto { get; set; }
        /// <summary>
        /// Data de Inicio das Atividades da Empresa.
        /// </summary>
        public DateTime? FzpontoDtInicio { get; set; }
        /// <summary>
        /// Data de Encerramento das Atividades da Empresa.
        /// </summary>
        public DateTime? FzpontoDtEncerramento { get; set; }
        /// <summary>
        /// Número de Vagas do Ponto.
        /// </summary>
        public int? FznumVagas { get; set; }
        /// <summary>
        /// Endereço do Ponto.
        /// </summary>
        public string? Fzendereco { get; set; }
        /// <summary>
        /// Número do Telefone do Ponto.
        /// </summary>
        public string? Fzfone { get; set; }
        /// <summary>
        /// Código de Identificação do Loteamento no qual o ponto está localizado.
        /// </summary>
        public int? Idloteamento { get; set; }
        /// <summary>
        /// Nome do Responsável pelo Ponto.
        /// </summary>
        public string? Fzresponsavel { get; set; }
        /// <summary>
        /// Outras informações a respeito do Ponto.
        /// </summary>
        public string? Fzobs { get; set; }

        public virtual FztipoPonto? FztipoPonto { get; set; }
        public virtual Loteamento? IdloteamentoNavigation { get; set; }
        public virtual ICollection<FzcredencialAncient> FzcredencialAncients { get; set; }
        public virtual ICollection<Fzcredencial> Fzcredencials { get; set; }
        public virtual ICollection<FzpontosMov> FzpontosMovs { get; set; }
        public virtual ICollection<FztermoCredenciamento> FztermoCredenciamentos { get; set; }
        public virtual ICollection<FzveiculoPorPonto> FzveiculoPorPontos { get; set; }
    }
}
