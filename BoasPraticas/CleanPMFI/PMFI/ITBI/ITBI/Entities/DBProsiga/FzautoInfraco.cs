using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class FzautoInfraco
{
    /// <summary>
    /// Número do auto de infração.
    /// </summary>
    public long AutiId { get; set; }

    /// <summary>
    /// Data do auto de infração.
    /// </summary>
    public DateTime? AutiDataAuto { get; set; }

    /// <summary>
    /// Número da notificação.
    /// </summary>
    public long? AutiNumNotificacao { get; set; }

    /// <summary>
    /// Data da notificação.
    /// </summary>
    public DateTime? AutiDataNotificacao { get; set; }

    /// <summary>
    /// Código de identificação do condutor.
    /// </summary>
    public long? ConId { get; set; }

    public long? FzpontoId { get; set; }

    public long? FzveiId { get; set; }

    public string AutiLocal { get; set; } = null!;

    public short AutiHora { get; set; }

    public short AutiMinuto { get; set; }

    public DateTime? AutiPrazoRegularizacao { get; set; }

    /// <summary>
    /// Código de identificação do fiscal que autuou.
    /// </summary>
    public long? FiscId { get; set; }

    /// <summary>
    /// Observações sobre o auto de infração.
    /// </summary>
    public string AutiObs { get; set; } = null!;

    /// <summary>
    /// Se o termo de infração é de remoção de veículo.
    /// </summary>
    public string? AutiRemocao { get; set; }

    /// <summary>
    /// Se o termo de infração é de retenção de veículo.
    /// </summary>
    public string? AutiRetencao { get; set; }

    /// <summary>
    /// (VERMELHA = Infracao  AZUL=Notificacao)
    /// </summary>
    public string? AutiCorInfracao { get; set; }

    public virtual Contribuinte? Con { get; set; }

    public virtual ICollection<FzautoInfracoesIten> FzautoInfracoesItens { get; set; } = new List<FzautoInfracoesIten>();

    public virtual FztermoVistorium? FztermoVistorium { get; set; }

    public virtual Fzveiculo? Fzvei { get; set; }
}
