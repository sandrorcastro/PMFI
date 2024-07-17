using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbFinExtratosBancario
    {
        public TbFinExtratosBancario()
        {
            TbFinCompensacaoDiarioTesouraria = new HashSet<TbFinCompensacaoDiarioTesourarium>();
            TbFinConciliacoesBancaria = new HashSet<TbFinConciliacoesBancaria>();
            IdLancamentos = new HashSet<TbFinContasContabeisLancamento>();
        }

        public int IdExtrato { get; set; }
        public short? IdEmpresa { get; set; }
        public int? IdCc { get; set; }
        public DateTime? DtExtrato { get; set; }
        public string? DsHistorico { get; set; }
        public string? NrDocumento { get; set; }
        public decimal? VlExtrato { get; set; }
        public DateTime? DtInclusao { get; set; }
        public string? DsLogin { get; set; }

        public virtual ICollection<TbFinCompensacaoDiarioTesourarium> TbFinCompensacaoDiarioTesouraria { get; set; }
        public virtual ICollection<TbFinConciliacoesBancaria> TbFinConciliacoesBancaria { get; set; }

        public virtual ICollection<TbFinContasContabeisLancamento> IdLancamentos { get; set; }
    }
}
