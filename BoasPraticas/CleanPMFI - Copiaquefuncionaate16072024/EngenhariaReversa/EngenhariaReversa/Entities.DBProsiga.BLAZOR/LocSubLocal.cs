using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class LocSubLocal
    {
        public LocSubLocal()
        {
            LocTaxas = new HashSet<LocTaxa>();
        }

        public int SubLocalId { get; set; }
        public int? SubLocLocalId { get; set; }
        public string? SubLocNome { get; set; }
        public string? SubLocFone { get; set; }
        public int? SubLocTipo { get; set; }
        public string? SubLocRespMatricula { get; set; }
        public string? SubLocRespNome { get; set; }
        public string? SubLocRespRg { get; set; }
        public string? SubLocTecUltAlt { get; set; }
        public DateTime? SubLocDtUltAlt { get; set; }

        public virtual Localizacao? SubLocLocal { get; set; }
        public virtual LocTpSubLocal? SubLocTipoNavigation { get; set; }
        public virtual ICollection<LocTaxa> LocTaxas { get; set; }
    }
}
