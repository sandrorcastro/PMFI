using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class Seguro
    {
        public Seguro()
        {
            VeiculosSeguros = new HashSet<VeiculosSeguro>();
        }

        public long SeguroId { get; set; }
        public string? SegCnpjfilial { get; set; }
        public long? ConId { get; set; }
        public int? SegAnoApolice { get; set; }
        public string? SegApolice { get; set; }
        public string? SegObjeto { get; set; }
        public DateTime? SegDtInicio { get; set; }
        public DateTime? SegDtFim { get; set; }
        public decimal? SegValor { get; set; }

        public virtual Contribuinte? Con { get; set; }
        public virtual ICollection<VeiculosSeguro> VeiculosSeguros { get; set; }
    }
}
