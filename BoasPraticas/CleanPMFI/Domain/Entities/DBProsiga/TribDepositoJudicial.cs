using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribDepositoJudicial
    {
        public TribDepositoJudicial()
        {
            TribDepositoJudicialBaixas = new HashSet<TribDepositoJudicialBaixa>();
        }

        public long DepositoId { get; set; }
        public DateTime? DtBaixa { get; set; }
        public DateTime? DtDeposito { get; set; }
        public decimal? VlDeposito { get; set; }
        public int? CertidaoDanumero { get; set; }
        public int? CertidaoDaano { get; set; }
        public int? TipoBxId { get; set; }
        public int? ConvenioId { get; set; }
        public long? ImoIddivida { get; set; }
        public long? ConIddivida { get; set; }
        public long? EmpIddivida { get; set; }
        public string? Login { get; set; }
        public DateTime? DtInclusao { get; set; }

        public virtual TribDividasContribuinte? ConIddividaNavigation { get; set; }
        public virtual TribDividasEmpresa? EmpIddividaNavigation { get; set; }
        public virtual TribDividasImo? ImoIddividaNavigation { get; set; }
        public virtual TribTipoBaixa? TipoBx { get; set; }
        public virtual ICollection<TribDepositoJudicialBaixa> TribDepositoJudicialBaixas { get; set; }
    }
}
