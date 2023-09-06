using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribTiposBaseCalculo
    {
        public TribTiposBaseCalculo()
        {
            TribAtivTributosEmpresas = new HashSet<TribAtivTributosEmpresa>();
            TribTipoPublicidades = new HashSet<TribTipoPublicidade>();
            TribTipoTributosVencs = new HashSet<TribTipoTributosVenc>();
            TribTiposBaseCalculoTributos = new HashSet<TribTiposBaseCalculoTributo>();
        }

        public int Tcid { get; set; }
        public string? Tcdescricao { get; set; }

        public virtual ICollection<TribAtivTributosEmpresa> TribAtivTributosEmpresas { get; set; }
        public virtual ICollection<TribTipoPublicidade> TribTipoPublicidades { get; set; }
        public virtual ICollection<TribTipoTributosVenc> TribTipoTributosVencs { get; set; }
        public virtual ICollection<TribTiposBaseCalculoTributo> TribTiposBaseCalculoTributos { get; set; }
    }
}
