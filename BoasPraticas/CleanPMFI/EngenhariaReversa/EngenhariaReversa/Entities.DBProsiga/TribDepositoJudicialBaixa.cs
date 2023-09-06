using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribDepositoJudicialBaixa
    {
        public long DepositoBaixaId { get; set; }
        public long DepositoId { get; set; }
        public long? ImoIddivida { get; set; }
        public long? ConIddivida { get; set; }
        public long? EmpIddivida { get; set; }

        public virtual TribDividasContribuinte? ConIddividaNavigation { get; set; }
        public virtual TribDepositoJudicial Deposito { get; set; } = null!;
        public virtual TribDividasEmpresa? EmpIddividaNavigation { get; set; }
        public virtual TribDividasImo? ImoIddividaNavigation { get; set; }
    }
}
