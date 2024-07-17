using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribBoletosDivida
    {
        public TribBoletosDivida()
        {
            TribDividasBaixaBoletos = new HashSet<TribDividasBaixaBoleto>();
        }

        public long BoleDivId { get; set; }
        /// <summary>
        /// Código de identificação da dívida.
        /// </summary>
        public long? ImoIddivida { get; set; }
        public long? ConIddivida { get; set; }
        public long? EmpIddivida { get; set; }
        /// <summary>
        /// Código de identificação do boleto bancário.
        /// </summary>
        public string BoleNossoNumero { get; set; } = null!;
        /// <summary>
        /// Valor do bloqueto bancário.
        /// </summary>
        public decimal? BoleValorPrinc { get; set; }
        /// <summary>
        /// Valor do desconto do boleto bancário.
        /// </summary>
        public decimal? BoleValorDesconto { get; set; }
        public decimal? BoleValorJuros { get; set; }
        public decimal? BoleValorMulta { get; set; }
        public decimal? BoleValorCorrecao { get; set; }
        public decimal? BoleValorOriginal { get; set; }
        public decimal? BoleValorBoletoDivida { get; set; }
        /// <summary>
        /// Valor pago da divida gerado pela trigger na entidade tribDividasBaixa.
        /// </summary>
        public decimal BoleValorPagoDivida { get; set; }
        public decimal? BoleValorApagar { get; set; }
        public decimal? BoleValorMultaDa { get; set; }

        public virtual TribBoleto BoleNossoNumeroNavigation { get; set; } = null!;
        public virtual TribDividasContribuinte? ConIddividaNavigation { get; set; }
        public virtual TribDividasEmpresa? EmpIddividaNavigation { get; set; }
        public virtual TribDividasImo? ImoIddividaNavigation { get; set; }
        public virtual ICollection<TribDividasBaixaBoleto> TribDividasBaixaBoletos { get; set; }
    }
}
