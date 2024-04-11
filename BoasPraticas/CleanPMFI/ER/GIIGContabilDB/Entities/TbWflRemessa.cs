using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbWflRemessa
{
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

    public virtual ICollection<TbWflAnexo> TbWflAnexos { get; set; } = new List<TbWflAnexo>();

    public virtual ICollection<TbWflRecebimento> IdRecebimentos { get; set; } = new List<TbWflRecebimento>();
}
