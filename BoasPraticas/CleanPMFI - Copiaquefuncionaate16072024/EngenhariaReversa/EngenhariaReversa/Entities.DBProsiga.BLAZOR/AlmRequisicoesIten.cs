using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class AlmRequisicoesIten
    {
        public AlmRequisicoesIten()
        {
            AlmSaidasItens = new HashSet<AlmSaidasIten>();
        }

        public long RequisicaoItemId { get; set; }
        public long? RequisicaoId { get; set; }
        public long? AlmoxId { get; set; }
        public long? ItemId { get; set; }
        public decimal? ReqItQtde { get; set; }
        public decimal? ReqItQtdeAtendida { get; set; }
        public string? ReqIsituacao { get; set; }
        public string? ReqIobservacao { get; set; }

        public virtual Almoxarifado? Almox { get; set; }
        public virtual AlmoxarifIten? AlmoxarifIten { get; set; }
        public virtual AlmIten? Item { get; set; }
        public virtual AlmRequisico? Requisicao { get; set; }
        public virtual ICollection<AlmSaidasIten> AlmSaidasItens { get; set; }
    }
}
