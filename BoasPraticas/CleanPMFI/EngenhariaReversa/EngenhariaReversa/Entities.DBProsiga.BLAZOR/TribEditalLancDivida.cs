using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribEditalLancDivida
    {
        public string EdDiId { get; set; } = null!;
        public int? EdiId { get; set; }
        public long? ImoIddivida { get; set; }
        public long? DivEmpId { get; set; }
        public long? ConIddivida { get; set; }
        public string? UsuarioInclusao { get; set; }
        public DateTime? DataInclusao { get; set; }
        public string? Host { get; set; }

        public virtual TribDividasContribuinte? ConIddividaNavigation { get; set; }
        public virtual TribDividasEmpresa? DivEmp { get; set; }
        public virtual TribEditalLanc? Edi { get; set; }
        public virtual TribDividasImo? ImoIddividaNavigation { get; set; }
    }
}
