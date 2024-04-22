using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribRequerimentoDivDesmembradum
    {
        public long ReqDesmemId { get; set; }
        public long? ReqOrigemId { get; set; }
        public long? ImoIddivida { get; set; }
        /// <summary>
        /// Deve ser informado se é imposto ou taxa
        /// </summary>
        public string? ReqDesmemTipoTributo { get; set; }

        public virtual TribDividasImo? ImoIddividaNavigation { get; set; }
        public virtual TribRequerimentoDivOrigem? ReqOrigem { get; set; }
    }
}
