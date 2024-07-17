using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbWflRemessa
    {
        public TbWflRemessa()
        {
            TbWflAnexos = new HashSet<TbWflAnexo>();
            IdRecebimentos = new HashSet<TbWflRecebimento>();
        }

        public int IdRemessa { get; set; }
        public int? IdRms { get; set; }
        public string? DsLoginRemetente { get; set; }
        public DateTime? DtRemessa { get; set; }
        public short? IdTipoFluxoRemetente { get; set; }
        public short? IdTipoFluxoDestino { get; set; }
        public short? IdDespachoPadrao { get; set; }
        public string? DsRemessa { get; set; }
        public string? CdHashAssinatura { get; set; }
        public string? DsSigner { get; set; }

        public virtual TbWflDespachosPadrao? IdDespachoPadraoNavigation { get; set; }
        public virtual TbWflTiposFluxo? IdTipoFluxoDestinoNavigation { get; set; }
        public virtual TbWflTiposFluxo? IdTipoFluxoRemetenteNavigation { get; set; }
        public virtual ICollection<TbWflAnexo> TbWflAnexos { get; set; }

        public virtual ICollection<TbWflRecebimento> IdRecebimentos { get; set; }
    }
}
