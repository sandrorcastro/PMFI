using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribTransfDividasOrigem
    {
        public int TransfOriId { get; set; }
        public int TransfId { get; set; }
        /// <summary>
        /// Codigo da Divida Imobiliaria
        /// </summary>
        public long? ImoIddivida { get; set; }
        public long? DivEmpId { get; set; }
        public long? ConIddivida { get; set; }

        public virtual TribDividasContribuinte? ConIddividaNavigation { get; set; }
        public virtual TribDividasEmpresa? DivEmp { get; set; }
        public virtual TribDividasImo? ImoIddividaNavigation { get; set; }
        public virtual TribTransfDivida Transf { get; set; } = null!;
    }
}
