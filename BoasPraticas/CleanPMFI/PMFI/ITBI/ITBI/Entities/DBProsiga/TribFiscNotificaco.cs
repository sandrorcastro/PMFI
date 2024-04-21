using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribFiscNotificaco
{
    public int NotifId { get; set; }

    public short? NotifAno { get; set; }

    public int? VistId { get; set; }

    public int? ItemVistId { get; set; }

    public DateTime? NotifDataHora { get; set; }

    public string? NotifObs { get; set; }

    public int? FiscalId { get; set; }

    public string? NotifFinalizada { get; set; }

    public DateTime? NotifDataFinalizacao { get; set; }

    public DateTime? DataInclusao { get; set; }

    public string? UsuarioInclusao { get; set; }

    public DateTime? NotifDiasPrazo { get; set; }

    public string? NotifSituacao { get; set; }

    public string? NotifMotivoSituacao { get; set; }

    public int? NotifNumero { get; set; }

    public string? VistNomeAssinatura { get; set; }

    public string? VistCpfrgassinatura { get; set; }

    public virtual TribFiscFiscai? Fiscal { get; set; }

    public virtual TribFiscItensVistorium? ItemVist { get; set; }

    public virtual ICollection<TribFiscAutoInfraco> TribFiscAutoInfracos { get; set; } = new List<TribFiscAutoInfraco>();

    public virtual TribFiscVistoria? Vist { get; set; }
}
