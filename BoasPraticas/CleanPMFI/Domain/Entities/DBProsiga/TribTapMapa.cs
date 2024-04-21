using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribTapMapa
    {
        public TribTapMapa()
        {
            TribTapMapaPagamentos = new HashSet<TribTapMapaPagamento>();
            TribTapRescisaoMapas = new HashSet<TribTapRescisaoMapa>();
        }

        public long TapMapaId { get; set; }
        public int? TipoTribId { get; set; }
        public decimal? TapVlOriginal { get; set; }
        public decimal? TapVlPrincipal { get; set; }
        public decimal? TapVlJuros { get; set; }
        public decimal? TapVlMulta { get; set; }
        public decimal? TapVlMultaDa { get; set; }
        public decimal? TapVlCorrecao { get; set; }
        public decimal? TapVlDesconto { get; set; }
        public decimal? TapVlJurosParc { get; set; }
        public decimal? TapVlAcrescimo { get; set; }
        public decimal? TapVlTotal { get; set; }
        public string? TapParcelaPaga { get; set; }
        public string? TapPagamentoParcial { get; set; }
        public long? ImoIddivida { get; set; }
        public long? ConIddivida { get; set; }
        public long? EmpIddivida { get; set; }
        public long? TapId { get; set; }
        public DateTime? DataBaixa { get; set; }
        public decimal? TapValorPagamentoParcial { get; set; }
        public decimal? JurosTap { get; set; }
        public decimal? MultaTap { get; set; }
        public decimal? CorrecaoTap { get; set; }
        public decimal? MultaDaTap { get; set; }
        public decimal? DescontoTap { get; set; }
        public decimal? TapVlBonificacao { get; set; }

        public virtual TribDividasContribuinte? ConIddividaNavigation { get; set; }
        public virtual TribDividasEmpresa? EmpIddividaNavigation { get; set; }
        public virtual TribDividasImo? ImoIddividaNavigation { get; set; }
        public virtual TribTap? Tap { get; set; }
        public virtual TribTipoTributo? TipoTrib { get; set; }
        public virtual ICollection<TribTapMapaPagamento> TribTapMapaPagamentos { get; set; }
        public virtual ICollection<TribTapRescisaoMapa> TribTapRescisaoMapas { get; set; }
    }
}
