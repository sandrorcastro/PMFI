﻿using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribBoleto
    {
        public TribBoleto()
        {
            TribBoletosDivida = new HashSet<TribBoletosDivida>();
            TribDividasBaixas = new HashSet<TribDividasBaixa>();
            TribNotificacaoDa = new HashSet<TribNotificacaoDum>();
            TribNotificacaoDivida = new HashSet<TribNotificacaoDivida>();
        }

        public string BoleNossoNumero { get; set; } = null!;
        public DateTime? BoleData { get; set; }
        /// <summary>
        /// Valor do bloqueto bancário.
        /// </summary>
        public decimal? BoleValorPrinc { get; set; }
        /// <summary>
        /// Valor do desconto do boleto bancário.
        /// </summary>
        public decimal BoleValorDesconto { get; set; }
        public decimal? BoleValorJuros { get; set; }
        public decimal? BoleValorMulta { get; set; }
        public decimal? BoleValorCorrecao { get; set; }
        public string? BoleLinhaDigitavel { get; set; }
        public DateTime? BoleVencimento { get; set; }
        public string? BoleCodBarra { get; set; }
        /// <summary>
        /// Código da moeda que foi gerado o boleto.
        /// </summary>
        public string? BoleMoeda { get; set; }
        /// <summary>
        /// Data da inclusão do registro.
        /// </summary>
        public DateTime? BoleDataInclusao { get; set; }
        /// <summary>
        /// Nome do usuário que incluiu o registro.
        /// </summary>
        public string? BoleUsuarioInclusao { get; set; }
        public int? ConvenioId { get; set; }
        public string? BoleOrigem { get; set; }
        /// <summary>
        /// Contém o valor do boleto, somado todos os campos.
        /// </summary>
        public decimal? BoleValorBoleto { get; set; }
        /// <summary>
        /// Valor da multa de dívida ativa.
        /// </summary>
        public decimal BoleValorMultaDa { get; set; }
        public long? ConId { get; set; }
        public long? LeiDescId { get; set; }
        public string? BoleIp { get; set; }

        public virtual ICollection<TribBoletosDivida> TribBoletosDivida { get; set; }
        public virtual ICollection<TribDividasBaixa> TribDividasBaixas { get; set; }
        public virtual ICollection<TribNotificacaoDum> TribNotificacaoDa { get; set; }
        public virtual ICollection<TribNotificacaoDivida> TribNotificacaoDivida { get; set; }
    }
}
