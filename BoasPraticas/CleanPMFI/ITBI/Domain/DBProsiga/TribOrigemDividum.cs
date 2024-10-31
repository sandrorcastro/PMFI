using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribOrigemDividum
    {
        public int TribOrigemDivId { get; set; }
        public long? ConIddivida { get; set; }
        public long? DivEmpId { get; set; }
        public long? ImoIddivida { get; set; }
        public string? TribOrigemDivNum { get; set; }
        public short? TribOrigemDivAno { get; set; }
        public int TribTipoId { get; set; }
        public int? EdiId { get; set; }

        public virtual TribDividasContribuinte? ConIddividaNavigation { get; set; }
        public virtual TribDividasEmpresa? DivEmp { get; set; }
        public virtual TribEditalLanc? Edi { get; set; }
        public virtual TribDividasImo? ImoIddividaNavigation { get; set; }
        public virtual TribTipoOrigemDividum TribTipo { get; set; } = null!;
    }
}
