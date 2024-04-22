using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribFiscTiposVistorium
    {
        public TribFiscTiposVistorium()
        {
            TribFiscItensVistoria = new HashSet<TribFiscItensVistorium>();
            TribFiscVistoria = new HashSet<TribFiscVistoria>();
            IdAtributos = new HashSet<TribFiscAtributo>();
            TipoFiscs = new HashSet<TribFiscTipoFiscal>();
        }

        public int TipoVistId { get; set; }
        public string? TipoVistNome { get; set; }
        public int? DivId { get; set; }
        public string? TipoVistNf { get; set; }

        public virtual Diviso? Div { get; set; }
        public virtual ICollection<TribFiscItensVistorium> TribFiscItensVistoria { get; set; }
        public virtual ICollection<TribFiscVistoria> TribFiscVistoria { get; set; }

        public virtual ICollection<TribFiscAtributo> IdAtributos { get; set; }
        public virtual ICollection<TribFiscTipoFiscal> TipoFiscs { get; set; }
    }
}
