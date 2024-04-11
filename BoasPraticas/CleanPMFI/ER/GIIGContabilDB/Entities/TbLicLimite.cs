using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbLicLimite
{
    public int IdLimite { get; set; }

    public DateTime? DtDiarioOficial { get; set; }

    public string? NrPortaria { get; set; }

    public short? IdClassificacaoObjeto { get; set; }

    public short? IdModalidade { get; set; }

    public decimal? VlInicial { get; set; }

    public decimal? VlLimite { get; set; }

    public string? DsTipoLimite { get; set; }

    public virtual TbLicClassificacoesObjeto? IdClassificacaoObjetoNavigation { get; set; }

    public virtual TbLicModalidade? IdModalidadeNavigation { get; set; }
}
