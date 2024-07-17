using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbWflTiposFluxo
    {
        public TbWflTiposFluxo()
        {
            TbWflFluxosTramitacaos = new HashSet<TbWflFluxosTramitacao>();
            TbWflRemessaIdTipoFluxoDestinoNavigations = new HashSet<TbWflRemessa>();
            TbWflRemessaIdTipoFluxoRemetenteNavigations = new HashSet<TbWflRemessa>();
        }

        public short IdTipoFluxo { get; set; }
        public string? NmTipoFluxo { get; set; }
        public string? DsTipoFluxo { get; set; }
        public string? FlRestringeOrgaoUnidade { get; set; }

        public virtual ICollection<TbWflFluxosTramitacao> TbWflFluxosTramitacaos { get; set; }
        public virtual ICollection<TbWflRemessa> TbWflRemessaIdTipoFluxoDestinoNavigations { get; set; }
        public virtual ICollection<TbWflRemessa> TbWflRemessaIdTipoFluxoRemetenteNavigations { get; set; }
    }
}
