﻿using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbLicLicitacoesAnexo
{
    public int IdAnexo { get; set; }

    public int? IdLicitacao { get; set; }

    public string? NmAnexo { get; set; }

    public DateTime? DtInclusao { get; set; }

    public byte[]? BnObjeto { get; set; }

    public string? DsExtencao { get; set; }

    public string? DsLogin { get; set; }

    public string? FlPublicaPortalTransparencia { get; set; }

    public string? FlPublicaPortalFornecedor { get; set; }

    public string? DsObjeto { get; set; }

    public int? IdContrato { get; set; }

    public short? IdTipoAnexo { get; set; }

    public string? DsLoginAlteracao { get; set; }

    public DateTime? DtAlteracao { get; set; }

    public virtual TbLicLicitaco? IdLicitacaoNavigation { get; set; }
}
