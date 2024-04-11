using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribNotificacaoDividasBkp
{
    public long NotificacaoId { get; set; }

    public DateTime? NotificacaoData { get; set; }

    public long? ImoIddivida { get; set; }

    public long? DivEmpId { get; set; }

    public long? ConIddivida { get; set; }

    public short? NotificacaoAno { get; set; }

    public long? NotificacaoNumero { get; set; }

    public long? TextoId { get; set; }

    public string? UsuarioInclusao { get; set; }

    public DateTime? DataInclusao { get; set; }

    public string? Host { get; set; }

    public string? Entregue { get; set; }

    public int? ObjetoId { get; set; }

    public string? BoleNossoNumero { get; set; }

    public string? ComDesconto { get; set; }
}
