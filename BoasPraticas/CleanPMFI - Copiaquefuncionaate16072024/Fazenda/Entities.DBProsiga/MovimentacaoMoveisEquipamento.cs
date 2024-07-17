using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class MovimentacaoMoveisEquipamento
{
    public long MmeId { get; set; }

    public long? MmeMovEquipId { get; set; }

    public long? MmeServidorIdAnt { get; set; }

    public long? MmeServidorId { get; set; }

    public string? MmeMotivo { get; set; }

    public DateTime? MmeData { get; set; }

    public DateTime? MmeDtConfirmacao { get; set; }

    public DateTime? MmeDtConfiPatrimonial { get; set; }

    public string? MmeTipoMovEquip { get; set; }

    public string? MmeSituacao { get; set; }

    /// <summary>
    /// Texto de confirmação da movimentação com servidor que confirmou
    /// </summary>
    public string? MmeObs { get; set; }

    public long? MmeLocalFisicoAnt { get; set; }

    public long? MmeLocalFisicoNovo { get; set; }

    public string? MmeUsuarioAlt { get; set; }

    public DateTime? MmeUsuarioAltDt { get; set; }

    public virtual LocalFisico? MmeLocalFisicoAntNavigation { get; set; }

    public virtual LocalFisico? MmeLocalFisicoNovoNavigation { get; set; }

    public virtual MoveisEquipamento? MmeMovEquip { get; set; }
}
