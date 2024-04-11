using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbCntResponsabilidadesAdministrativa
{
    public int IdRespAdmin { get; set; }

    public int IdContrato { get; set; }

    public short IdTipoRespAdm { get; set; }

    public DateTime? DtPeriodoIni { get; set; }

    public DateTime? DtPeriodoFim { get; set; }

    public int IdPessoa { get; set; }

    public string? DsCargo { get; set; }

    public string? DsAtoDesignacao { get; set; }

    public string? DsLogin { get; set; }

    public DateTime? DtInclusao { get; set; }

    public virtual TbCntContrato IdContratoNavigation { get; set; } = null!;

    public virtual TbGerPessoa IdPessoaNavigation { get; set; } = null!;

    public virtual TbCntTiposResponsabilidadeAdm IdTipoRespAdmNavigation { get; set; } = null!;
}
